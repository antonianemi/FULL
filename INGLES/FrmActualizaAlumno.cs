using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmActualizaAlumno : Form
    {
        public FrmActualizaAlumno()
        {
            InitializeComponent();
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
