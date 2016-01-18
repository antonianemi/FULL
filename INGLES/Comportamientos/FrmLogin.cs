using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InglesEntity;
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


        /// <summary>
        /// 
        /// </summary>
        private void LoadCatalogos() { }
        /// <summary>
        /// Registra las validaciones pertinentes para cada control de captura.
        /// </summary>
        private void LoadValidation()
        {
            _validaciones.ErrorProvider = ErrP_Login;
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_NameUser));
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_Password));
        }
        /// <summary>
        /// Envia la informacion capturada a la logica de negocio.
        /// </summary>
        private void DoSendInformation()
        {
            _validaciones.ExecuteValidation();// this is very important!!!   in this instruction we send to validate the controls of form 

            if (_validaciones.IsValid)
            {
                //Credentials _Credenciales=new Credenciales();
                _session = _bll.DoLogin(DoCaptureInformation());
                //_BLL.getCredenciales(DoCaptureInformation());
                //if(credencialesisvalid()) crearsesion;
                
                if (_session != null)
                {
                    new PRINCIPAL(_session).Show();
                    this.Hide();
                }
                else
                {
                    EscenaClearControles();
                    EscenaCredencialesIncorrectas();
                }


            }
        }


        /// <summary>
        /// Captura la informacion del los controles de usuario y 
        /// </summary>
        /// <returns></returns>
        private Credentials DoCaptureInformation()
        {
            return new Credentials(this.txt_NameUser.Text, this.txt_Password.Text);
        }

    }

}
