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
    public partial class FrmPeriodoPrincipal : Form
    {
        public FrmPeriodoPrincipal()
        {
            InitializeComponent();
            rdb_Periodo_Registrar.Checked = true;
        }

       

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (rdb_Periodo_Actualizar.Checked)
            {
                //Lanzar formulario para actualizar datos de un alumno.
                this.Hide();
                new FrmActualizaPeriodo().Show();
            }
            if (rdb_Periodo_Baja.Checked)
            {
                //Lanzar formulario para registrar baja de alumno.
                this.Hide();
                new FrmEliminaPeriodo().Show();
            }
            if (rdb_Periodo_Registrar.Checked)
            {
                //Lanzar Formulario para registrar alumno.
                this.Hide();
                new FrmRegistraPeriodo().Show();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //verificar si se guardara algun componente o si se llevara acabo alguna
            //validacion.
        }

    }
}
