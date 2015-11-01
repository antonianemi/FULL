using System;
using System.Collections.Generic;

namespace InglesEntity
{
    public class Periodo
    {
        private int _idperiodo;
        private string _descripcion;
        private string _periodo;
        private estatusPeriodo _status;
        private List<Nivel> _niveles;

        /// <summary>
        /// Representa el id de este periodo.
        /// </summary>
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
        /// <summary>
        /// Representa la descripcion de este periodo.
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
        /// Representa el periodo
        /// </summary>
        public string PERIODO
        {
            get
            {
                return _periodo.ToUpperInvariant();
            }
            set
            {
                _periodo = value;
            }
        }
        /// <summary>
        /// Representa el status del periodo
        /// </summary>
        public estatusPeriodo STATUS
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
        /// <summary>
        /// Almacena los niveles correspondientes a este periodo
        /// </summary>
        public List<Nivel> NIVELES
        {
            set
            {
                _niveles = value;
            }

            get
            {
                return _niveles;
            }
        }

        ~Periodo() { }
    }
}
