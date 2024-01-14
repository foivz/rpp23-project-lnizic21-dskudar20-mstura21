using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories {
    public class BookManagmentRepository : IDisposable {
        protected EntityModels Context { get; set; }
        public DbSet<Library_has_Books> Entities { get; set; }
        public BookManagmentRepository() {
            Context = new EntityModels();
            Entities = Context.Set<Library_has_Books>();
        }
        public IQueryable<Book> GetBooksForLibrary(int idLibrary) {
            var sql = from book in Context.Books
                      join libraryBook in Entities
                      on book.idBook equals libraryBook.Books_idBook
                      where libraryBook.Library_idLibrary == idLibrary
                      select book;
            return sql.Include("Users").Include("Library_has_Books");
        }
        public void Dispose() {
            Context.Dispose();
        }
    }
}
