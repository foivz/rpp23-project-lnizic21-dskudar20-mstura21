using DataAccessLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests.DataAcessLayerTest.Repositories
{
    [TestClass]
    public class ReservationTest
    {


        [TestMethod]
        public void GetLoansInProgress()
        {
            using (var repo = new ReservationsRepository())
            {
                var reservations = repo.GetReservations(4);
                Assert.IsNotNull(reservations);
            }
        }
    }
}
