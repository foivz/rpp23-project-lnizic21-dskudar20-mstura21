using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests.DataAcessLayerTest.Repositories
{
    [TestClass]
    public class LibraryRepostoryTest
    {
        [TestMethod]
        public void GetAllLibrariesTest() {
            LibraryRepository libraryRepository = new LibraryRepository();
            var libraries = libraryRepository.GetAllLibraries();
            Assert.IsNotNull(libraries);
        }
    }
}
