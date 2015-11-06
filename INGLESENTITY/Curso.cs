using System.Collections.Generic;

namespace InglesEntity
{
    public class Curso
    { 
        public int ID_CURSO { set; get; }
        /// <summary>
        /// REPRESENTA A EL DOCENTE QUE IMPARTE ESTE CURSO.
        /// </summary>
        public Docente DOCENTE { set; get; }
        /// <summary>
        /// REPRESENTA AL NIVEL QUE SE IMPARTE EN ESTE CURSO.
        /// </summary>
        public Nivel NIVEL { set; get; }
        /// <summary>
        /// REPRESENTA AL PERIODO EN EL QUE SE ENCUENTRA ESTE CURSO.
        /// </summary>
        public Periodo PERIODO { set; get; }
        /// <summary>
        /// REPRESENTA EL HORARIO ASIGNADO A ESTE CURSO.
        /// </summary>
        public Horario HORARIO { set; get; }
        /// <summary>
        /// CONTIENE LA LISTA DE ALUMNOS DE ESTE CURSO.
        /// </summary>
        public List<Alumno> ALUMNOS { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPCION { set; get; }
    }
}
