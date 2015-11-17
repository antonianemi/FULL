using System;

namespace InglesEntity
{
    /// <summary>
    /// Representa un alumno en el sistema.
    /// </summary>
    public class Alumno
    {
        public int ID_ALUMNO
        {
            set; get;
        }
        public string CARRERA
        {
            set; get;
        }
        public string NO_CONTROL
        {
            set; get;
        }
        public string FECHANACIMIENTO
        {
            set; get;
        }
        public string NOMBRE
        {
            set; get;
        }
        public string RFC
        {
            set; get;
        }
        public string CURP
        {
            set; get;
        }
        public string APELLIDO_PATERNO
        {
            set; get;
        }
        public string DOMICILIO
        {
            set; get;
        }
        public string SEMESTRE
        {
            set; get;
        }
        public string APELLIDO_MATERNO
        {
            set; get;
        }
        public int ID_PERSONA
        {
            set; get;
        }
        public TIPOALUMNO TIPOALUMNO
        {
            set; get;
        }
    }
}
