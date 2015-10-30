using InglesBLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestAsistenciaManagerBLL
    {
        [TestMethod]
        public void TestInicializaAsistenciaManagerBLL()
        {
            AsistenciaManagerBLL obj = new AsistenciaManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
