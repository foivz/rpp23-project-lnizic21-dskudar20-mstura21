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
            using (var repo = new UserRepository())
            {
                User user = repo.GetUserByUsernameAndPasssword("test", "test");
                Assert.IsNotNull(user);
            }
        }
        [TestMethod]
        public void ExistingUserExceptionTest()
        {
            using (UserRepository repo = new UserRepository())
            {
                Assert.ThrowsException<RegistrationException>(() => repo.CreateNewUser(new User()
                {
                    username = "test",
                    password = "test",
                    email = "",
                }));
            }
            
        }
    }
}
