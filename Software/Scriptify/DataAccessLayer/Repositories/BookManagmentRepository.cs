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
        public int GetBookIdByName(string name) {
            var sql = from book in Context.Books
                      where book.book_name == name
                      select book.idBook;
            return sql.FirstOrDefault();
        }
        public bool AddBookToLibrary(int idLibrary,string bookName) {
            int idBook = GetBookIdByName(bookName);
            Library_has_Books library_has_Books = new Library_has_Books() {
                Books_idBook = idBook,
                Library_idLibrary = idLibrary
            };
            Entities.Add(library_has_Books);
            Context.SaveChanges();
            return true;
        }
        public bool AddBook(Book book) {
            Context.Books.Add(book);
            Context.SaveChanges();
            return true; 
        }
        public Book GetBookByID(int Id) {
            var sql = from book in Context.Books
                      where book.idBook == Id
                      select book;
            return sql.FirstOrDefault();
        }
        public bool UpdateBook(Book book) {
            var sql = from b in Context.Books
                      where b.idBook == book.idBook
                      select b;
            Book bookToUpdate = sql.FirstOrDefault();
            bookToUpdate.book_name = book.book_name;
            bookToUpdate.author = book.author;
            bookToUpdate.overview = book.overview;
            bookToUpdate.genre = book.genre;
            Context.SaveChanges();
            return true;

        }
        public bool DeleteBook(int id) {
            var sql = from b in Context.Library_has_Books
                      where b.Books_idBook == id
                      select b;
            Library_has_Books bookToDelete = sql.FirstOrDefault();
            Context.Library_has_Books.Remove(bookToDelete);
            Context.SaveChanges();
            return true;
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}
