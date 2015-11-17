using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;

namespace Ingles
{
    public partial class FrmRegistraDocente : FormBase
    {
        DocenteManagerBLL _bll;   
        public FrmRegistraDocente(Session obj):base(obj)
        {
         InitializeComponent();
            ConfigureForm();
            _bll = new DocenteManagerBLL();
        }

        private void REGISTRAR(object sender, EventArgs e)
        {
            DoSendInformation();
        }

        private void CANCELAR(object sender, EventArgs e)
        {
           /*Codigo limpiar los */
        }

    }
}
