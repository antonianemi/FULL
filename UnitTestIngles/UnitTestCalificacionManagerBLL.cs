using InglesBLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestCalificacionManagerBLL
    {
        [TestMethod]
        public void TestInicializaCalificacionManagerBLL()
        {
            CalificacionManagerBLL obj = new CalificacionManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
