using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories { 
    
    public class PendingLoansRepository  : IDisposable {
       private EntityModels Context { get; set; }
    private DbSet<Loan> Entities { get; set; }
public PendingLoansRepository() {
        Context = new EntityModels();
        Entities = Context.Set<Loan>();
    }
        public IQueryable<Loan> GetAllPendingLoans(int librarianId) {
        DateTime today = DateTime.Now.Date;

        var loans = from loan in Entities
                    join book in Context.Library_has_Books on loan.book_id equals book.Books_idBook
                    join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                    where library.idLibrarians == librarianId && loan.planned_return >= today
                    select loan;

        return loans;
    }

        public void Dispose() {
            Context.Dispose();
        }
    }
   
}
