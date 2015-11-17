using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;
using System.Speech.Synthesis;

namespace Ingles
{

    public partial class FrmRegistraAlumno : FormBase
    {
        AlumnoManagerBLL bll;

        bool Interno = false;
        bool InternoNuevoIngreso = false;
        bool Foraneo = false;
        bool ForaneoNuevoIngreso = false;

        public FrmRegistraAlumno(Session obj):base(obj)
        {
            InitializeComponent();
            bll = new AlumnoManagerBLL();
            ConfigureForm();
            EscenaStart();
        }

        private void REGISTRAR(object sender, EventArgs e)
        {
            DoSendInformation();
        }

        private void CANCELAR(object sender, EventArgs e)
        {
            EscenaCancelar();      
        }
        
        private void FORANEO(object sender, EventArgs e)
        {
            EscenaForaneo();
        }

        private void INTERNO(object sender, EventArgs e)
        {
            EscenaInterno();
        }

        private void NUEVOINGRESO(object sender, EventArgs e)
        {
            if (chk_NuevoIngreso.Checked) {
            EscenaInternoNuevoIngreso();
            }
            else
            {
                EscenaStart();
            }
                
        }

    }

}
