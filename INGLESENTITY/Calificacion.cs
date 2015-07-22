using System;

namespace InglesEntity
{
    /// <summary>
    /// Representa una calificacion en el sistema.
    /// </summary>
    public class Calificacion
    {

        private int _idcalificacion;
        private string _calificacion;
        private string _descripcion;

        public string CALIFICACION
        {
            get
            {
                return _calificacion.ToUpperInvariant();
            }
            set
            {
                _calificacion = value;
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

        ~Calificacion(){}
    }
}
