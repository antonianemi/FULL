using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmActualizaAlumno : FormBase
    {
        public FrmActualizaAlumno(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void BUSCARALUMNO(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Buscando Coincidencia de Alumno....");
            }
        }
        private void ACTUALIZAR(object sender, EventArgs e)
        {
            MessageBox.Show("Se Envia a Actualizar.!!!");
        }
    }
}
