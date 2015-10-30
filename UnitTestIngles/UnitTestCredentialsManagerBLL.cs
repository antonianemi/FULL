using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestCredentialsManagerBLL
    {
        [TestMethod]
        public void TestInicializaCredentialsManagerBLL()
        {
            CalificacionManagerBLL obj = new CalificacionManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
