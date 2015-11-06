using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public class Horario
    {
        private int _idhorario;
       
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

        public List<Dia> Dias { set; get; }

    }
}
