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
        public void AddBookToLibraryTest() {
            using (BookManagmentRepository repo = new BookManagmentRepository()) {

               bool sucess =  repo.AddBookToLibrary(1, "Test knjiga 3");
                Assert.IsTrue(sucess);
            }
        }

    }
}
