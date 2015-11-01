using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestAutenticationManagerBLL
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestInicializaAutenticationManagerBLL()
        {
            UnitTestAutenticationManagerBLL obj = new UnitTestAutenticationManagerBLL();
            Assert.IsNotNull(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestLogin()
        {
            AutenticationManagerBLL obj = new AutenticationManagerBLL();
            
            Credentials _credential = new Credentials("antonio", "cortes");
            Assert.IsNotNull(obj.DoLogin(_credential));



        }


    }
}
