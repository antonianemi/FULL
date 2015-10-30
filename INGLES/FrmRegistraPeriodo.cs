using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;


namespace Ingles
{
    public partial class FrmRegistraPeriodo : FormBase
    {
        PeriodoManagerBLL _bll = null;
        public FrmRegistraPeriodo(Session obj):base(obj)
        {
            InitializeComponent();
           _bll = new PeriodoManagerBLL();
            CondigureForm();
            EscenaStart();
        }        
        private void Cancelar(object sender, EventArgs e)
        {
            EscenaCancelar();
        }
        private void Abrir(object sender, EventArgs e)
        {            
          try
            { 
            //DoSendInformation();
            ShowNotification("Se Creo un Nuevo Periodo Con Exito");
            }
            catch(Exception ex)
            { 
                ShowError(ex);
            }

        }
    }
}
