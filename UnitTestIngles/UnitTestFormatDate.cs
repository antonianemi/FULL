using InglesBLL;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestFormatDate
    {
        [TestMethod]
        public void TestMethod1()
        {

            string fecha = FormatDate.DoConverFormato(DateTime.Now);


        }
    }
}
