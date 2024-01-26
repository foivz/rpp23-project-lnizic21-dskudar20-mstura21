using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
namespace Unit_Tests.ServicesTest {
    [TestClass]
    public class PendingLoanServiceTest {
        [TestMethod]
        public void GetAllPendingLoansTest() {
            var pending = new PendingLoansService();
            var loans = pending.GetAllPendingLoans(1);
            Assert.IsNotNull(loans);
        }
    }
}
