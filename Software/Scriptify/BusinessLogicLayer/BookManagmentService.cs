using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using System.Data.Entity.Infrastructure;

namespace BusinessLogicLayer {
    public class BookManagmentService {
        public List<Book> GetBooksForLibrary(int id) {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetBooksForLibrary(id).ToList();
            }   
        }
        public bool AddBookToLibrary(int idLibrary,string bookName) {
            using(var repo = new BookManagmentRepository()) {
                try {
                    repo.AddBookToLibrary(idLibrary,bookName);
                    return true;
                }catch(DbUpdateException ex) {
                    return false;
                }
                
            }
        }
        public bool AddBook(Book book) {
            using(var repo = new BookManagmentRepository()) {
                try {
                    return repo.AddBook(book);
                }catch(DbUpdateException ex) {
                    return false;
                }
                
            }
        }
        public Book GetBookById(int id) {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetBookByID(id);
            }
        }
        public bool UpdateBook(Book book) {
            using(var repo = new BookManagmentRepository()) {
                try {
                    repo.UpdateBook(book);
                    return true;
                }catch(DbUpdateException ex) {
                    return false;
                }
                
            }
        }
        public List<Genre> GetGenres() {
            using (var repo = new BookManagmentRepository()) {
                return repo.GetGenres().ToList();
            }
        }
        public List<Authors> GetAuthors() {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetAuthors().ToList();
            }
        }
        public List<Authors> GetSpecificAuthor(string name) {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetSpecificAuthor(name).ToList();
            }
        }
        public bool AddAuthor(string name) {
            using(var repo = new BookManagmentRepository()) {
                try {
                    return repo.InsertAuthor(name);
                }catch(DbUpdateException ex) {
                    return false;
                }
                
            }   
        }
        public List<Genre> GetSpecificGenre(string genre) {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetSpecificGenre(genre).ToList();
            }
        }
        public bool DeleteBook(int id) {
            using (var repo = new BookManagmentRepository()) {
                try {
                    repo.DeleteBook(id);
                    return true;
                } catch (DbUpdateException ex) {
                    return false;
                }

            }
        }
    }
}
