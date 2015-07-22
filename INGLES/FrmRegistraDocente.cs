using System;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmRegistraDocente : Form
    {
        public FrmRegistraDocente()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Lleva acabo las vaidaciones pertinentes del formulario.
        /// </summary>
        private void Validate()
        {

        }

        /// <summary>
        /// LLeva acabo la limpieza de los controlesdel formulario.
        /// </summary>
        private void limpiaControles()
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            //Armarobjeto de tipo docente y ejecutar su llamada a guardar en la base de datos.

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiaControles();
        }

     

        
    }
}
