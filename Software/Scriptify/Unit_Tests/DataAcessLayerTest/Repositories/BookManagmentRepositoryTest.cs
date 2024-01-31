using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntityLayer;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Unit_Tests.DataAcessLayerTest.Repositories {
    [TestClass]
    public class BookManagmentRepositoryTest  {
        

        [TestMethod]
        public void GetBooksForLibraryTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {
                var books = repo.GetBooksForLibrary(1);
                Assert.IsNotNull(books);
            }

        }
        [TestMethod]
        public void AddBookToLibraryExceptionTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {
                
                Assert.ThrowsException<DbUpdateException>(() =>  repo.AddBookToLibrary(1, "xxxx"));
            }
        }
        [TestMethod]
        public void AddBookToLibraryTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {

               bool sucess =  repo.AddBookToLibrary(1, "Test knjiga 3");
                Assert.IsTrue(sucess);
            }
        }
        [TestMethod]
        public void GetBookByIdTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {

                Book book = repo.GetBookByID(1);
                Assert.IsNotNull(book);
            }
        }
        [TestMethod]
        public void UpdateBookTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {
                Book book = repo.GetBookByID(1);
                book.book_name = "Test knjiga 3";
                bool sucess = repo.UpdateBook(book);
                Assert.IsTrue(sucess);
            }
        }
        [TestMethod]
        public void DeleteBookTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {
                bool sucess = repo.DeleteBook(1);
                Assert.IsTrue(sucess);
            }
        }
        [TestMethod]
        public void DuplicateAuthorsTest() {
            using(BookManagmentRepository repo = new BookManagmentRepository()) {
                bool sucess = repo.InsertAuthor("William Shakespeare");
                Assert.IsFalse(sucess);
            }
        }

    }
}
