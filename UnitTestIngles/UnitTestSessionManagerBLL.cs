using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestSessionManagerBLL
    {
        [TestMethod]
        public void TestInicializaSessionManagerBLL()
        {
            SessionManagerBLL obj = new SessionManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
