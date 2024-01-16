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

            var loans = from loan in Entities
                        join book in Context.Library_has_Books on loan.idBook equals book.Books_idBook
                        join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                        where library.idLibrarians == librarianId
                        select loan;

            var bookIds = loans.Select(loan => loan.idBook);

            var books = (from book in Context.Books
                         where bookIds.Contains(book.idBook)
                         select book);

        
            return books;
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
