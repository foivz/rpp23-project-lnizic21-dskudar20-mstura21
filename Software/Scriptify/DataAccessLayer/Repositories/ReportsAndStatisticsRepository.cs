using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReportsAndStatisticsRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Book> Entities { get; set; }
        public ReportsAndStatisticsRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Book>();
        }
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public IQueryable<Book> GetTopBooks(int librarianId)
        {
            DateTime today = DateTime.Now.Date;

            var loans = GetLoansForLibrarian(librarianId, today);

            List<int?> bookIds = loans.Select(loan => loan.book_id).ToList();

            var topBooks = GetTopBooksByLoanCount(bookIds);

            return topBooks;
        }

        private IQueryable<Loan> GetLoansForLibrarian(int librarianId, DateTime today)
        {
            return from loan in Context.Loans
                   join book in Context.Library_has_Books on loan.book_id equals book.Books_idBook
                   join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                   where library.idLibrarians == librarianId && loan.planned_return <= today
                   select loan;
        }

         private IQueryable<Book> GetTopBooksByLoanCount(List<int?> bookIds)
        {
            return (from book in Context.Books
                    where bookIds.Contains(book.idBook)
                    select book)
                   .AsEnumerable()
                   .OrderByDescending(book => bookIds.Count(id => id == book.idBook))
                   .Take(10)
                   .AsQueryable();
        }


        public IQueryable<BookWithCount> GetTop10Books(int librarianId)
        {
            DateTime today = DateTime.Now.Date;

            var loans = GetLoansForLibrarian(librarianId, today);

            var bookIds = loans.Select(loan => loan.book_id).ToList();

            return GetTop10BooksByLoanCount(bookIds);
        }

        private IQueryable<BookWithCount> GetTop10BooksByLoanCount(List<int?> bookIds)
        {
            var bookWithCounts = from book in Context.Books
                                 where bookIds.Contains(book.idBook)
                                 let count = bookIds.Count(id => id == book.idBook)
                                 orderby count descending
                                 select new BookWithCount
                                 {
                                     idBook = book.idBook,
                                     book_name = book.book_name,
                                     overview = book.overview,
                                     author = book.author,
                                     genre = book.genre,
                                     LoanCount = count
                                 };

            return bookWithCounts.Take(10).AsQueryable();
        }

        public IQueryable<UserWithCount> GetTop10Users(int librarianId)
        {

            DateTime today = DateTime.Now.Date;

            var loans = from loan in Context.Loans
                        join book in Context.Library_has_Books on loan.book_id equals book.Books_idBook
                        join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                        where library.idLibrarians == librarianId && loan.planned_return <= today
                        select loan;

            List<int> userIds = loans.Select(loan => loan.idUser).ToList();


            var usersWithLoanCount = ((from user in Context.Users
                          where userIds.Contains(user.id_user)
                          select new UserWithCount
                          {
                              id_user = user.id_user,
                              username = user.username,
                              email = user.email,
                              password = user.password,
                              create_time = user.create_time,
                              Money = user.Money,
                              First_Name = user.First_Name,
                              Last_Name = user.Last_Name,
                              LoanCount = userIds.Count(id => id == user.id_user)
                          })
                          .AsEnumerable()
                          .OrderByDescending(item => item.LoanCount)
                          .Take(10))
                          .AsQueryable();

            return usersWithLoanCount;


        }

        public IQueryable<ChartData> GetChartData(DateTime start, DateTime end)
        {
            var loans = from loan in Context.Loans
                        where loan.date_of_loan >= start && loan.date_of_loan <= end
                        group loan by loan.date_of_loan into grouped
                        select new ChartData
                        {
                            Date = grouped.Key,
                            Count = grouped.Count()
                        };

            return loans;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
