using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer {
    public class SAPRepository : IDisposable {
        public EntityModels Context { get; set; }
        public DbSet<Library_has_Books> Entities { get; set; }

        public SAPRepository() {
            Context = new EntityModels();
            Entities = Context.Set<Library_has_Books>();
        }
        public IQueryable<SAPData> getScriptifyAproovedData() {
            var query = from lhb in Context.Library_has_Books
                        join b in Context.Books on lhb.Books_idBook equals b.idBook
                        join l in Context.Loans on lhb.Books_idBook equals l.book_id into loansGroup
                        from loan in loansGroup.DefaultIfEmpty()
             join l2 in Context.Libraries on lhb.Library_idLibrary equals l2.idLibrary
            where lhb.Books_idBook == loan.book_id
            group new { l2, lhb } by new { l2.idLibrary, l2.name } into grouped
            select new SAPData {
                IdLibrary = grouped.Key.idLibrary,
                Name = grouped.Key.name,
                Loans = grouped.Count()
            };
            return query;
        }
        public IQueryable<SAPData> getScriptifyAlgoData() {
            var query = from lhb in Context.Library_has_Books
                        join l in Context.Loans on lhb.Books_idBook equals l.book_id into loansGroup
                        from loan in loansGroup.DefaultIfEmpty()
                        join l2 in Context.Libraries on lhb.Library_idLibrary equals l2.idLibrary
                        where lhb.Books_idBook == loan.book_id
                        group loan by new { l2.idLibrary, l2.name } into grouped
                        select new SAPData {
                            IdLibrary = grouped.Key.idLibrary,
                            Name = grouped.Key.name,
                            Loans = grouped.Select(l => l.idUser).Distinct().Count()
                        };


            return query;
        }
        public IQueryable<SAPLibrary> getLibraryBookCounts() {
            var result = from libraryBook in Context.Library_has_Books
                         group libraryBook by libraryBook.Library_idLibrary into grouped
                         select new SAPLibrary{
                             Library_idLibrary = grouped.Key,
                             BookCount = grouped.Count()
                         };
            return result;
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}
