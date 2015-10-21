using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;


namespace Ingles
{

    public partial class FrmRegistrarAlumno : FormBase
    {
        AlumnoManagerBLL bll;

        public FrmRegistrarAlumno()
        {
            InitializeComponent();
            bll = new AlumnoManagerBLL();
            LoadValidation();
            EscenaStart();
         }
        
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            DoSendInformation();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            EscenaCancelar();      
        }

        private void EscenaReadyForSave(object sender, EventArgs e)
        {   
            EscenaReadyForSave();
        }
        
    }

}
