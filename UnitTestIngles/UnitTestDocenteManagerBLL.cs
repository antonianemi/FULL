using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestDocenteManagerBLL
    {
        [TestMethod]
        public void TestInicializaDocenteManagerBLL()
        {
            UnitTestDocenteManagerBLL obj = new UnitTestDocenteManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
