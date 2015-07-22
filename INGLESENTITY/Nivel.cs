using System;

namespace InglesEntity
{
    /// <summary>
    /// Representa un nivel en el sistema.
    /// </summary>
    public class Nivel
    {
        private int _idNivel;
        private string _descripcion;
        private string _mision;
        private string _vision;
        private string _objetivo;
        private string _nivel;
        private int _idPeriodo;
        private int _status;

        /// <summary>
        /// Constructor para abrir un nuevo periodo.
        /// </summary>
        /// <param name="obj">Representa el periodo que se va a abrir</param>
        public Nivel(Periodo obj)
        {

        }

        public Nivel()
        {

        }
        /// <summary>
        /// REPRESENTA EL ID_NIVEL DEL NIVEL
        /// </summary>
        public int ID_NIVEL {
            set
            {
                _idNivel = value;
            }
            get
            {
                return _idNivel;
            }
        }

        public string DESCRIPCION
        {
            get
            {
                return _descripcion.ToUpperInvariant();
            }
            set
            {
                _descripcion = value;
            }
        }

        public string MISION
        {
            get
            {
                return _mision.ToUpperInvariant(); 
            }
            set
            {
                _mision = value;
            }
        }

        public string VISION
        {
            get
            {
                return _vision.ToUpperInvariant();
            }
            set
            {
                _vision = value;
            }
        }

        public string OBJETIVO
        {
            get
            {
                return _objetivo.ToUpperInvariant();
            }
            set
            {
                _objetivo = value;
            }
        }

        public string NIVEL
        {
            get
            {
                return _nivel.ToUpperInvariant();
            }
            set
            {
                _nivel = value;
            }
        }

        public int STATUS
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public int ID_PERIODO
        {
            get
            {
                return _idPeriodo;
            }
            set
            {
                _idPeriodo = value;
            }
        }


        ~Nivel() { }

    }
}
