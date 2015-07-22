using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    /// <summary>
    /// REpresenta una carrera en el sistema.
    /// </summary>
    public class Carrera
    {

        private int _idcarrera;
        private string _nombre;
        private string _descripcion;

        public int ID_CARRERA
        {
            get
            {
                return _idcarrera;
            }
            set
            {
                _idcarrera = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return _nombre.ToUpperInvariant();
            }
            set
            {
                _nombre = value;
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

        ~Carrera(){}
    }
}
