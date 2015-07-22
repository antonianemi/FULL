using System;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmRegistrarAlumno : Form
    {
        public FrmRegistrarAlumno()
        {
            InitializeComponent();

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            //Crear un objeto de tipo alumno
            //llenar sus propiedades del objeto y enviarlo a la
            //base de datos.
            //LLamar a su metodo para que se inserte en la base de datos.
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiaControles();            
        }
        /// <summary>
        /// Limpia los controles y cancela la transaccion.
        /// </summary>
        private void limpiaControles()
        {
            txt_Apellido_Materno.Clear();
            txt_Apellido_Paterno.Clear();
            txt_Curp.Clear();
            txt_NoControl.Clear();
            txt_Nombre.Clear();
            txt_RFC.Clear();
        }
        /// <summary>
        /// Este metodo se encarga de validar los datos.
        /// </summary>
        private void Valida()
        {

        }
    }
}
