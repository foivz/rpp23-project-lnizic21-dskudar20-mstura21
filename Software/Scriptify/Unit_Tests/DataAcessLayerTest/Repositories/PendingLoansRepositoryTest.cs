using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
namespace Unit_Tests.DataAcessLayerTest.Repositories {
    [TestClass]
    public class PendingLoansRepositoryTest {
        [TestMethod]
        public void GetAllPendingLoansTest() {
            var pending = new PendingLoansRepository();
            var loans = pending.GetAllPendingLoans(1);
            Assert.IsNotNull(loans);
        }

    }
}
