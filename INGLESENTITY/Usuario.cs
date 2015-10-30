using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public class Usuario
    {
        public string Nombre { set; get; }
        public string ApellidoPaterno { set; get; }
        public string ApellidoMaterno { set; get; }
        public string Curp { set; get; }
        public string Rfc { set; get; }
        public string Edad { set; get; }
        public string PathFoto { set; get; }
        public string FullName {  get { return Nombre + " " + ApellidoPaterno + " " + ApellidoPaterno; } }
    }
}
