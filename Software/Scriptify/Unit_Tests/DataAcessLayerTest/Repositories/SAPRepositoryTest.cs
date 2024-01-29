using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Unit_Tests.DataAcessLayerTest.Repositories {
    [TestClass] 
    public class SAPRepositoryTest {
        [TestMethod]
        public void TestGetScriptifyAproovedData() {
            // Arrange
            SAPRepository sapRepository = new SAPRepository();
            // Act
            var result = sapRepository.getScriptifyAproovedData();
            // Assert
            Assert.IsNotNull(result);
        }   
    }
}
