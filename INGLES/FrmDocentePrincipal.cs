using System;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmDocentePrincipal : Form
    {
        public FrmDocentePrincipal()
        {
            InitializeComponent();
            rdb_Docente_Registrar.Checked = true;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (rdb_Docente_Registrar.Checked)
            {
                this.Hide();
                new FrmRegistraDocente().Show();
            }

            if (rdb_Docente_Actualizar.Checked)
            {
                this.Hide();
                new FrmActualizaDocente().Show();
            }

            if (rdb_Docente_Baja.Checked)
            {
                this.Hide();
                new FrmEliminaDocente().Show();
            }
          
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Regresar Al Menu Principal.
        }

        /// <summary>
        /// Valida la informacion del formulario.
        /// </summary>
        private void validar()
        {

        }
        /// <summary>
        /// Limpia los controles del formulario.
        /// </summary>
        private void LimpiaControles()
        {

        }
    }
}
