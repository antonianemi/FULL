﻿using System;
using InglesEntity;
using InglesBLL;
using System.Data;
using System.Drawing;



namespace Ingles
{

    public partial class frmLogin : FormBase 
    {
        AutenticationManagerBLL _bll;

        public Session _session { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public frmLogin()
        {            
            InitializeComponent();

            _validaciones.ErrorProvider = ErrP_Login;                        
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_NameUser));
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_Password));
            _bll = new AutenticationManagerBLL();

        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            _validaciones.ExecuteValidation();// this is very important!!!   in this instruction we send to validate the controls of form 

            if (_validaciones.IsValid)
            { 
                _session = _bll.DoLogin(new Credentials(this.txt_NameUser.Text, this.txt_Password.Text));
                new PRINCIPAL(_session).Show();
                this.Hide();
            }
        }    
    }
}
