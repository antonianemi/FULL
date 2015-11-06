using System;
using InglesEntity;
using InglesBLL;
using System.Data;
using System.Drawing;



namespace Ingles
{

    public partial class FrmLogin : FormBase 
    {
        AutenticationManagerBLL _bll;
        public Session _session { get; set; }        
        /// <summary>
        /// 
        /// </summary>
        public FrmLogin()
        {            
            InitializeComponent();
            LoadValidation();
            _bll = new AutenticationManagerBLL();

        }

        private void LOGIN(object sender, EventArgs e)
        {
            DoSendInformation();
        }    
    }
}
