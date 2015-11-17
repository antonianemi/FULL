using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InglesEntity;

namespace Ingles
{
    public partial class FrmInscripcion : FormBase
    {
        private BindingSource bindingSource1 = new BindingSource();

        public FrmInscripcion()
        {
            InitializeComponent();
            ConfigureForm();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;

            
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NOMBRE";
            column.Name = "NOMBRE";
            dataGridView1.Columns.Add(column);

            
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "CARRERA";
            column.Name = "CARRERA";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "NIVEL";
            column.Name = "NIVEL";
            dataGridView1.Columns.Add(column);


            DataGridViewButtonColumn column2 = new DataGridViewButtonColumn();
            column2.DataPropertyName = "INSCRIBIR";
            column2.Name = "INSCRIBIR";
            column2.HeaderText = "INSCRIBIR";
            column2.ToolTipText = "INSCRIBIR";
            dataGridView1.Columns.Add(column2);
            
        }

        private void SELECCIONARCURSO(object sender, EventArgs e)
        {
            //new FrmSelectedCurso().Show();
        }

        private void INSCRIBIR(object sender, EventArgs e)
        {

        }
    }
}
