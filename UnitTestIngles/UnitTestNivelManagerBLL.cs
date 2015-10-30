using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestNivelManagerBLL
    {
        [TestMethod]
        public void TestInicializaNivelManagerBLL()
        {
            NivelManagerBLL obj = new NivelManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
