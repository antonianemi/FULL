﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Ingles
{

    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            
            /* Inicializar su BLL 
            El bll debe responder a los eventos de este formulario de tal forma que 

            Solicitar a AutenticationManagerBLL mediante el metodo login que 
            valide las credenciales del usuario.


            */


            InitializeComponent();
        }





        private void btn_Login_Click(object sender, EventArgs e)
        {
            /*Capturar l*/
            
            /* Enviar credenciales para login Las validaciones las hara la pantalla y nomas se le pasara al bll ya dijgerido*/

            if (this.ValidateChildren())
            {
                MessageBox.Show("Faltan Campos Por Validar");
            }
            else
            {
                MessageBox.Show("Listo Ya LLenaste El formulario Correctamente!!!!");
            }
        }
        




        private void ValidaCampos(object sender, CancelEventArgs e)
        {
            if (sender.GetType().ToString().ToUpper().Equals("SYSTEM.WINDOWS.FORMS.TEXTBOX"))
            {
                switch (((TextBox)sender).Name.ToUpper()){

                    case "TXT_NAMEUSER":
                        if (txt_NameUser.Text == string.Empty)
                        Error_Login.SetError(txt_NameUser, "Este campo no puede quedar vacio");
                        break;

                    case "TXT_PASSWORD":
                        if (txt_Password.Text == string.Empty)
                            Error_Login.SetError(txt_Password, "Este campo no puede quedar vacio");
                        break;
                    default:
                        Error_Login.Clear();
                        break;
                }

            }
        }

       
    }
}