using InglesDLL;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;

namespace InglesBLL
{

    public class AlumnoManagerBLL : BaseBusiness
    {
        AlumnoManagerDLL _dll;
        public AlumnoManagerBLL()
        {
            _dll = new AlumnoManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }

        public void DoCreateAlumno(Alumno alumno)
        {

        }



        /// <summary>
        /// this method create a list of Alumnos, keep the file .csv
        /// </summary>
        public List<Alumno> DoLoadAlumnos()
        {
            List<Alumno> objs = new List<Alumno>();


            return objs;

        }
    }
}
