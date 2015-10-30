using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    /// <summary>
    /// Summary description for UnitTestCursoManagerBLL
    /// </summary>
    [TestClass]
    public class UnitTestCursoManagerBLL
    {

        [TestMethod]
        public void TestInicializaCursoManagerBLL()
        {
            CursoManagerBLL obj = new CursoManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
