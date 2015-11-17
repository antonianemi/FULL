using InglesDLL;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;


namespace InglesBLL
{
    public class DocenteManagerBLL : BaseBusiness
    {
        DocenteManagerDLL _dll;
        public DocenteManagerBLL()
        {
            _dll = new DocenteManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }

        /// <summary>
        /// This method is think for 
        /// </summary>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public List<Docente> search(string criterio)
        {
            List<Docente> objs = new List<Docente>();
            Docente obj = new Docente();
            obj.ID_DOCENTE = 1;
            obj.ID_PERSONA = 1;
            obj.NOMBRE = "Docente de Prueba";
            obj.NO_DOCENTE = 2;
            obj.RFC = "CXLA910421";
            obj.APELLIDO_PATERNO = "CORTES";
            obj.APELLIDO_MATERNO = "LAGUNES";
            obj.CURP = "CXLA910421";
            objs.Add(obj);
            return objs;
        }
    }
}
