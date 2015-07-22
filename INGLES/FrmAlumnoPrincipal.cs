using System;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmAlumnoPrincipal : Form
    {
        public FrmAlumnoPrincipal()
        {
            InitializeComponent();
            rdb_Alumno_Registrar.Checked = true;
        }
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (rdb_Alumno_Registrar.Checked)
            {
                this.Hide();
                new FrmRegistrarAlumno().Show();
                //Lanzar el formulario para actualizar datos de alumno
            }
            if (rdb_Alumno_Actualizar.Checked)
            {
                this.Hide();
                new FrmActualizaAlumno().Show();
                //Lanzarformulario para dar de baja alumno
            }
            if (rdb_Alumno_Baja.Checked)
            {
                this.Hide();
                new FrmEliminaAlumno().Show();
                //lanzar formulario para registrar un alumno.
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Regresar al menu principal.
        }

        /// <summary>
        /// Realiza las validaciones de los datos.
        /// </summary>
        private void Validate(){

        }
        /// <summary>
        /// Limpia los controles del formulario.
        /// </summary>
        private void LimpiaControles()
        {

        }

    }
}
