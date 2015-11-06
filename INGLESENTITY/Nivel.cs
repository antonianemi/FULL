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
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
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
    }
}
