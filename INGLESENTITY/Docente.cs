using System;

namespace InglesEntity
{
    /// <summary>
    /// Representa un docente en el sistema.
    /// </summary>
    public class Docente
    {
        public int NO_DOCENTE
        {
            set; get;
        }
        public int ID_DOCENTE
        {
            set; get;
        }
        public string NOMBRE
        {
            set; get;
        }
        public string APELLIDO_PATERNO
        {
            set; get;
        }
        public string APELLIDO_MATERNO
        {
            set; get;
        }
        public string CURP
        {
            set; get;
        }
        public string RFC
        {
            set; get;
        }
        public string FECHANACIMIENTO
        {
            set; get;
        }
        public int ID_PERSONA
        {
            set; get;
        }
        ~Docente() { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        public static explicit operator Docente(System.Windows.Forms.DataGridViewRow row)
        {
            Docente obj = new Docente();            
            obj.NO_DOCENTE = Convert.ToInt32((row.Cells[0].Value != null) ? row.Cells[0].Value.ToString() : String.Empty);
            obj.NOMBRE = (row.Cells[2].Value != null) ? row.Cells[2].Value.ToString() : String.Empty;
            obj.APELLIDO_MATERNO = (row.Cells[3].Value != null) ? row.Cells[3].Value.ToString() : String.Empty;
            obj.APELLIDO_PATERNO = (row.Cells[4].Value != null) ? row.Cells[4].Value.ToString() : String.Empty;
            obj.CURP = (row.Cells[5].Value != null) ? row.Cells[5].Value.ToString() : String.Empty;
            obj.RFC = (row.Cells[6].Value != null) ? row.Cells[6].Value.ToString() : String.Empty;
            return obj;
        }

       
    }
}
