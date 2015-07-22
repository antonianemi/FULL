using System;

namespace InglesEntity
{
    /// <summary>
    /// Representa un docente en el sistema.
    /// </summary>
    public class Docente : Persona
    {

        private int _iddocente;

        public int ID_DOCENTE
        {
            get
            {
                return _iddocente;
            }
            set
            {
                _iddocente = value;
            }
        }

        ~Docente() { }
    }
}
