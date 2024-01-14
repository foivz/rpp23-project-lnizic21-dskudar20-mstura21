using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories; 
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

    }
}
