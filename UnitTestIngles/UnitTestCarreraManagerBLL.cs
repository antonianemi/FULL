using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestCarreraManagerBLL
    {
        [TestMethod]
        public void TestInicializaCarreraManagerBLL()
        {
            CalificacionManagerBLL obj = new CalificacionManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
