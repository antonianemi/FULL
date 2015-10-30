using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InglesBLL;
using InglesEntity;

namespace UnitTestIngles
{
    /// <summary>
    /// Summary description for UnitTestPeriodoManagerBLL
    /// </summary>
    [TestClass]
    public class UnitTestPeriodoManagerBLL
    {
        [TestMethod]
        public void TestInicializaPeriodoManagerBLL()
        {
            PeriodoManagerBLL obj = new PeriodoManagerBLL();
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void TestNewPeriodoSinNiveles()
        {
            //new PeriodoManagerBLL().NewPeriodoSinNiveles(new Periodo()
            //{
            //    ID_PERIODO = 1,
            //    DESCRIPCION = "",
            //    NIVELES = null,
            //    PERIODO = "",
            //    STATUS = estatusPeriodo.Activo,
            //});
        }

    }
}
