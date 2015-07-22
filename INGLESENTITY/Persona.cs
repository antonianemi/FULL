using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{

   public class Persona
    {
       private int _idpersona;
       private string _nombre;
       private string _apellidopaterno;
       private string _apellidomaterno;
       private string _fechanacimiento;
       private string _rfc;
       private string _curp;

       public string FECHANACIMIENTO
       {
           get
           {
               return _fechanacimiento.ToUpperInvariant(); ;
           }
           set
           {
               _fechanacimiento = value;
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

       public string RFC
       {
           get
           {
               return _rfc.ToUpperInvariant();
           }
           set
           {
               _rfc = value;
           }
       }

       public string CURP
       {
           get
           {
               return _curp.ToUpperInvariant();
           }
           set
           {
               _curp = value;
           }
       }

       public string APELLIDO_PATERNO
       {
           get
           {
               return _apellidopaterno.ToUpperInvariant();
           }
           set
           {
               _apellidopaterno = value;
           }
       }

       public string APELLIDO_MATERNO
       {
           get
           {
               return _apellidomaterno.ToUpperInvariant();
           }
           set
           {
               _apellidomaterno = value;
           }
       }

       public int ID_PERSONA
       {
           get
           {
               return _idpersona;
           }
           set
           {
               _idpersona = value;
           }
       }

       ~Persona(){}
   }
}
