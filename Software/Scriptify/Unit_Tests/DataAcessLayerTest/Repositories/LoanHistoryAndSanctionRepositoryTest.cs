using DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests.DataAcessLayerTest.Repositories
{
    [TestClass]
    public class LoanHistoryAndSanctionRepositoryTest
    {

        [TestMethod]
        public void GetAllExpiredLoans()
        {
            using (var repo = new LoanHistoryAndSanctionRepository())
            {
                var loans = repo.GetAllExpiredLoans(4);
                Assert.IsNotNull(loans);
            }
        }

        [TestMethod]
        public void IssueSanction()
        {
            var loan = new Loan()
            {
                book_name = "Test",
                first_name = "testt",
                last_name = "testt",
                loan_status = "In progress",
            };

            using (var repo = new LoanHistoryAndSanctionRepository())
            {
                repo.IssueSanction(loan);
                Assert.IsTrue(loan.loan_status == "In progress");
            }
        }
    }
}
