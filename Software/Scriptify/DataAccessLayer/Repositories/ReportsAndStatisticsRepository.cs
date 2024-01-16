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

            var sql = (from loan in Entities
                       join book in Context.Books on loan.idBook equals book.idBook
                       join libraryBook in Context.Library_has_Books on book.idBook equals libraryBook.Books_idBook
                       join library in Context.Librarians on libraryBook.Library_idLibrary equals library.Library_idLibrary
                       where library.idLibrarians == librarianId
                       group loan by new { book.idBook, book.book_name, book.overview, book.author, book.genre } into g
                       select new Book
                       {

                           idBook = g.Key.idBook,
                           book_name = g.Key.book_name,
                           overview = g.Key.overview,
                           author = g.Key.author,
                           genre = g.Key.genre,

                       })
        .Take(10);

            return sql;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
