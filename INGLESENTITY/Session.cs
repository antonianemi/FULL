using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public class Session
    {
        public int IdSession { get; set; }
        public Usuario User { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public STATUSSESSION Status { get; set; }
    }
}
