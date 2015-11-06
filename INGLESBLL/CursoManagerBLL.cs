using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class CursoManagerBLL : BaseBusiness
    {
        CursoManagerDLL _dll;
        public CursoManagerBLL()
        {
            _dll = new CursoManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Curso GenerarCurso()
        {
            CursoBuilder curso = new CursoBuilder();

            ///Preparar curso
            curso.Horario = new Horario();

            curso.BuildCurso();

            return curso.GetCurso();
        }
    }
}