using Microsoft.VisualStudio.TestTools.UnitTesting;
using InglesBLL;

namespace UnitTestIngles
{
    /// <summary>
    /// Summary description for UnitTestAlumnoBLL
    /// </summary>
    [TestClass]
    public class UnitTestAlumnoManagerBLL
    {        
        [TestMethod]
        public void TestInicializaAlumnoManagerBLL()
        {            
            AlumnoManagerBLL obj = new AlumnoManagerBLL();
            Assert.IsNotNull(obj);
        }
    }
}
