using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LoanHistoryAndSanctionRepository : IDisposable
    {
        public EntityModels Context { get; set; }
        public DbSet<Loan> Entities { get; set; }
        public LoanHistoryAndSanctionRepository()
        {
                Context = new EntityModels();
                Entities = Context.Set<Loan>();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public IQueryable<Loan> GetAllExpiredLoans(int librarianId)
        {
            DateTime today = DateTime.Now.Date;

            var loans = from loan in Entities
                        join book in Context.Library_has_Books on loan.book_id equals book.Books_idBook
                        join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                        where library.idLibrarians == librarianId && loan.planned_return <= today
                        select loan;

            return loans;
        }

        public IQueryable<Loan> GetLoansInProgress(int librarianId)
        {

            var loans = from loan in Entities
                        join book in Context.Library_has_Books on loan.book_id equals book.Books_idBook
                        join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                        where library.idLibrarians == librarianId && loan.loan_status == "In progress"
                        select loan;

            return loans;
        }


        public int LoanStatusCompleted(Loan loan, bool saveChanges = true)
        {
            var existingLoan = Entities.FirstOrDefault(e => e.idUser == loan.idUser && e.book_id == loan.book_id);

            if (existingLoan != null)
            {
                existingLoan.loan_status = "Completed";

                if (saveChanges)
                {
                    return SaveChanges();
                }
            }

            return 0;
        }


        public int IssueSanction(Loan loan, bool saveChanges = true)
        {
            var existingLoan = Entities.FirstOrDefault(e => e.idUser == loan.idUser && e.book_id == loan.book_id);

            if (existingLoan != null)
            {
                existingLoan.loan_status = "Sanction issued";

                if (saveChanges)
                {
                    return SaveChanges();
                }
            }

            return 0;
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
