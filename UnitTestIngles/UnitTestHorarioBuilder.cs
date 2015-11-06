using InglesBLL;
using InglesEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIngles
{
    [TestClass]
    public class UnitTestHorarioBuilder
    {

        [TestMethod]
        public void TestBuildHorarioSemanaCompleta()
        {
            HorarioBuilder obj = new HorarioBuilder();
            obj.AddDias(new Dia() { DiaP = DIAS.LUNES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.MARTES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.MIERCOLES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.JUEVES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.VIERNES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.SABADO, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.DOMINGO, HoraFin = "", HoraInicio = "" });
            Assert.AreEqual(obj.getHorario().Dias.Count, 7);
        }



        [TestMethod]
        public void TestBuildHorarioSemanaInglesa()
        {
            HorarioBuilder obj = new HorarioBuilder();
            obj.AddDias(new Dia() { DiaP = DIAS.LUNES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.MARTES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.MIERCOLES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.JUEVES, HoraFin = "", HoraInicio = "" });
            obj.AddDias(new Dia() { DiaP = DIAS.VIERNES, HoraFin = "", HoraInicio = "" });
            Assert.AreEqual(obj.getHorario().Dias.Count, 7);
        }



    }
}
