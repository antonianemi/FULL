using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public class Horario: IDisposable
    {
        private int _idhorario;
        private string _descripcion;
        private string _horaini;
        private string _horafin;
        private string _fecha;

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

        public string HORA_INI
        {
            get
            {
                return _horaini.ToUpperInvariant();  
            }
            set
            {
                _horaini = value;
            }
        }

        public string HORA_FIN
        {
            get
            {
                return _horafin.ToUpperInvariant();
            }
            set
            {
                _horafin = value;
            }
        }

        public string FECHA
        {
            get
            {
                return _fecha.ToUpperInvariant();
            }
            set
            {
                _fecha = value;
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


        ~Horario() { }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
