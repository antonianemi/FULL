using System;

namespace InglesEntity
{
    /// <summary>
    /// Representa un alumno en el sistema.
    /// </summary>
    public class Alumno:Persona
    {
        private int _idalumno;
        private string _carrera;
        private string _nocontrol;
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
        public string CARRERA
        {
            get
            {
                return _carrera.ToUpperInvariant();
            }
            set
            {
                _carrera = value;
            }
        }
        public string NO_CONTROL
        {
            get
            {
                return _nocontrol.ToUpperInvariant();
            }
            set
            {
                _nocontrol = value;
            }
        }

        ~Alumno(){}
    }
}
