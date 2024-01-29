using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
namespace Unit_Tests.ServicesTest {
    [TestClass]
    public class SAPServicesTest {
        [TestMethod]
        public void TestGetScriptifyAproovedData() {
            // Arrange
            SAPService sapService = new SAPService();
            // Act
            var result = sapService.getScriptifyAproovedData();
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
