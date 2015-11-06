using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InglesEntity;

namespace InglesBLL
{
    public class CursoBuilder
    {
        private List<Alumno> _Alumnos;
        private Docente _Docente;
        private Nivel _Nivel;
        private Periodo _Periodo;
        private Horario _Horario;
        private Curso _Curso;

        /// <summary>
        /// 
        /// </summary>
        public CursoBuilder() {
            _Alumnos = new List<Alumno>();
            _Docente = new Docente();
            _Nivel = new Nivel();
            _Periodo = new Periodo();
            _Horario = new Horario();
        }
        /// <summary>
        /// set or get an Horario for this course.
        /// </summary>
        public Horario Horario { set { _Horario = value; }  get { return _Horario; } }
        /// <summary>
        /// set or get a Nivel for this course
        /// </summary>
        public Nivel Nivel       { set { _Nivel = value; }  get { return _Nivel;   } }
        /// <summary>
        /// set or get a Periodo for this course. 
        /// </summary>
        public Periodo Periodo { set { _Periodo = value; }  get { return _Periodo; } }
        /// <summary>
        /// set or get a Docente for this course.
        /// </summary>
        public Docente Docente { set { _Docente = value; }  get { return _Docente; } }
        /// <summary>
        /// Agrega un nuevo alumno al objeto.
        /// </summary>
        /// <param name="obj"></param>
        public void AddAlumno(Alumno obj)
        {
            _Alumnos.Add(obj);
        }
        /// <summary>
        /// get Course.
        /// </summary>
        /// <returns></returns>
        public Curso GetCurso()
        {
            BuildCurso();
            return _Curso;
        }
        /// <summary>
        /// construye el curso en cuestion.
        /// </summary>
        public void BuildCurso()
        {
            if (_Docente != null) 
                _Curso.DOCENTE = _Docente;
            if (_Horario != null)
                _Curso.HORARIO = _Horario;
            if (_Periodo != null)
                _Curso.PERIODO = _Periodo;
            if (_Nivel != null)
                _Curso.NIVEL = _Nivel;
            if (_Alumnos != null)
                _Curso.ALUMNOS = _Alumnos;
        }
    }
}