using DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Unit_Tests.DataAcessLayerTest.Repositories
{
    [TestClass]
    public class LoanHistoryTest
    {
        [TestMethod]
        public void GetLoansInProgress()
        {
            using (var repo = new LoanHistoryRepository())
            {
                var loans = repo.GetLoansInProgress(4);
                Assert.IsNotNull(loans);
            }
        }
       
    }
}

