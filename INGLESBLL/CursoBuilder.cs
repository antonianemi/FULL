using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InglesEntity;

namespace InglesBLL
{
    /// <summary>
    /// 
    /// </summary>
    public class CursoBuilder
    {
        private Curso _Curso;

        /// <summary>
        /// 
        /// </summary>
        public CursoBuilder() {
            _Curso = new Curso();
            //_Curso.ALUMNOS = new List<Alumno>();
            //_Curso.DOCENTE = new Docente();
            //_Curso.NIVEL = new Nivel();
            //_Curso.PERIODO = new Periodo();
            //_Curso.HORARIO = new Horario();
        }
        /// <summary>
        /// set or get an Horario for this course.
        /// </summary>
        private Horario Horario { set; get; }
        /// <summary>
        /// set or get a Nivel for this course
        /// </summary>
        private Nivel Nivel       { set; get; }
        /// <summary>
        /// set or get a Periodo for this course. 
        /// </summary>
        private Periodo Periodo { set; get; }
        /// <summary>
        /// set or get a Docente for this course.
        /// </summary>
        private Docente Docente { set; get; }
        /// <summary>
        /// Agrega un nuevo alumno al objeto.
        /// </summary>
        /// <param name="obj"></param>
        public void AddAlumno(Alumno obj)
        {
            if (_Curso.ALUMNOS == null)
                _Curso.ALUMNOS = new List<Alumno>();

            _Curso.ALUMNOS.Add(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void AsignarPeriodo(Periodo obj)
        {
            if (Periodo == null)
                Periodo = new Periodo();

            Periodo = obj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void AsignarNivel(Nivel obj)
        {
            if (Nivel == null)
                Nivel = new Nivel();

            
            Nivel = obj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void AsignarHorario(Horario obj)
        {
            if (Horario == null)
                Horario = new Horario();
            
            Horario = obj;

        }
        /// <summary>
        /// get Course.
        /// </summary>
        /// <returns></returns>
        public Curso GetCurso()
        {
            //BuildCurso();
            return _Curso;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public void AgregarComentario(string mensaje)
        {
            _Curso.DESCRIPCION = mensaje;
        }
    }
}