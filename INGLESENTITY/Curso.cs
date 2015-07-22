using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public class Curso
    {

        private int _idcurso;
        private int _idalumno;
        private int _idnivel;
        private int _idperiodo;
        private int _idcalificacion;
        private int _idhorario;

        public int ID_CURSO
        {
            get
            {
                return _idcurso;
            }
            set
            {
                _idcurso = value;
            }
        }

        public int ID_NIVEL
        {
            get
            {
                return _idnivel;
            }
            set
            {
                _idnivel = value;
            }
        }

        public int ID_PERIODO
        {
            get
            {
                return _idperiodo;
            }
            set
            {
                _idperiodo = value;
            }
        }

        public int ID_HORARIO
        {
            get
            {
                return _idhorario;
            }
            set
            {
                _idhorario = value;
            }
        }

        public int ID_ALUMNO
        {
            get
            {
                return _idalumno;
            }
            set
            {
                _idalumno = value;
            }
        }

        public int ID_CALIFICACION
        {
            get
            {
                return _idcalificacion;
            }
            set
            {
                _idcalificacion = value;
            }
        }

        /// <summary>
        /// Reglas para crear un nuevo curso como minimo
        /// </summary>
        /// <param name="idnivel">nivel que se impartira en el curso.</param>
        /// <param name="idperiodo">Periodo en el que se encuentra el nivel.</param>
        public Curso(int idnivel, int idperiodo)
        {
            _idnivel = idnivel;
            _idperiodo = idperiodo;
        }

        /// <summary>
        /// Creacion de curso por defecto.
        /// </summary>
        public Curso()
        {
            //Calcular automaticamente el id del curso a crear.
        }

        ~Curso() { }



    }
}
