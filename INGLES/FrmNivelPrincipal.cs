using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmNivelPrincipal : Form
    {
        public FrmNivelPrincipal()
        {
            InitializeComponent();
            rdb_Nivel_Registrar.Checked = true;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (rdb_Nivel_Registrar.Checked)
            {
                this.Hide();
                new FrmRegistraNivel().Show();
            }
            if (rdb_Nivel_Actualizar.Checked)
            {
                this.Hide();
                new FrmActualizaNivel().Show();
            }
            if (rdb_Nivel_Baja.Checked)
            {
                this.Hide();
                new FrmEliminaNivel().Show();
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Lanzar formulario principal.
            //Ocultar este formulario.
        }

        /// <summary>
        /// Realiza las validaciones de los datos.
        /// </summary>
        private void validate()
        {

        }
        /// <summary>
        /// Limpia el contenido de los controles y los pone
        /// a como estaban al principio.
        /// </summary>
        private void LimpiaControles()
        {

        }
    }
}
