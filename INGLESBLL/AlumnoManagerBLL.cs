using InglesDLL;
using BaseAcces;
using InglesEntity;


namespace InglesBLL
{

    public class AlumnoManagerBLL : BaseBusiness
    {
        AlumnoManagerDLL dll;
        public AlumnoManagerBLL()
        {
            dll = new AlumnoManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }


        public void DoCreateAlumno(Alumno alumno)
        {

        }
    }
}
