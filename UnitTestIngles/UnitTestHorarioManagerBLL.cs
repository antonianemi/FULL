using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestHorarioManagerBLL
    {
        [TestMethod]
        public void TestInicializaHorarioManagerBLL()
        {
            HorarioManagerBLL obj = new HorarioManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
