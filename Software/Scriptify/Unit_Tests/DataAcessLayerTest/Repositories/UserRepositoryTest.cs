using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntityLayer;
using DataAccessLayer.Iznimke;

namespace Unit_Tests.DataAcessLayerTest.Repositories
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod]
        public void TestGetUserByUsernameAndPassswordTest()
        {
            using (var repo = new LibrarianRepository())
            {
                Librarian user = repo.GetUserByUsernameAndPasssword("test", "test");
                Assert.IsNotNull(user);
            }
        }
        [TestMethod]
        public void ExistingUserExceptionTest()
        {
            using (LibrarianRepository repo = new LibrarianRepository())
            {
                Assert.ThrowsException<RegistrationException>(() => repo.CreateNewUser(new Librarian()
                {
                    username = "test",
                    password = "test",
                    email = "",
                }));
            }
            
        }
        [TestMethod]
        public void DeleteLibrarianTest() {
            LibrarianRepository librarianRepository = new LibrarianRepository();
           bool test = librarianRepository.DeleteLibrarianById(librarianRepository.GetUserByUsernameAndPasssword("test", "test").idLibrarians);
            Assert.IsTrue(test);
        }
        [TestMethod]
        public void GetLibraryByNameTest() {
            LibraryRepository librarianRepository = new LibraryRepository();
            Library librarians = librarianRepository.GetLibraryByName("Verbum knjižnica");
            Assert.IsNotNull(librarians);
        }
        [TestMethod]
        public void GetLibraryByIdTest() {
            LibraryRepository librarianRepository = new LibraryRepository();
            Library librarians = librarianRepository.GetLibraryById(1);
            Assert.IsNotNull(librarians);
        }
        [TestMethod]
        public void GetLibrarianLibraryIDbyName() {
            LibrarianRepository librarian = new LibrarianRepository();
            int id = librarian.GetLibrarianLibraryIDbyName("test");
            Assert.IsNotNull(id);
        }
    }
}
