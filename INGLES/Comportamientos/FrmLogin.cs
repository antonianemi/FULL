using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ingles
{
    public partial class FrmLogin
    {

        #region ESCENAS
        private void EscenaCredencialesIncorrectas()
        {
            EscenaClearControles();
            this.lbl_MensajeLogin.ForeColor = System.Drawing.Color.Red;
            this.lbl_MensajeLogin.Text = "* Las Credenciales no son Validas !!";
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaUsuarioIncorrecto()
        {
            EscenaClearControles();
            this.lbl_MensajeLogin.Text = "* No se tiene registrado ningun usuario con ese usuario !!";
        }
        /// <summary>
        /// 
        /// </summary>
        private void PasswordIncorrecto()
        {
            EscenaClearControles();
            this.lbl_MensajeLogin.Text = "* Password incorrecto !!";
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaStart()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaClearControles()
        {
            this.txt_NameUser.Text = String.Empty;
            this.txt_NameUser.BackColor = System.Drawing.Color.White;
            this.txt_Password.Text = String.Empty;
            this.txt_Password.BackColor = System.Drawing.Color.White;
        }
        #endregion
    }

}
