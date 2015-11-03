using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestUsuarioManagerBLL
    {
        [TestMethod]
        public void TestInicializaUsuarioManagerBLL()
        {
            UsuarioManagerBLL obj = new UsuarioManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
