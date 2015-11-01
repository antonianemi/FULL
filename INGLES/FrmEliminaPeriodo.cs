using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;


namespace Ingles
{
    public partial class FrmEliminaPeriodo : Form
    {
        BLL objbll = null;
        public FrmEliminaPeriodo()
        {
            InitializeComponent();
            objbll = new BLL();
            Inicialize();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj">OBJETO PERIODO.</param>
        private void showData(Periodo obj)
        {
            lbl_Descripcion.Text = obj.DESCRIPCION;
            lbl_periodo.Text = obj.PERIODO;
        }
        /// <summary>
        /// 
        /// </summary>
        private void Inicialize()
        {
            List<Periodo> periodos = new List<Periodo>();
            dtg_periodos.DataSource = periodos;
        }
        /// <summary>
        /// 
        /// </summary>
        private void cleanControls()
        {
            Inicialize();
        }
        /// <summary>
        /// llEVAR ACABO LAS VALIDACIONES PERTINENTES ANTES DE ENVIAR CUALQUIER TRANSACCION.
        /// </summary>
        private void validate()
        {

        }
        private void dtg_periodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                Periodo obj = new Periodo();
                obj.ID_PERIODO = Convert.ToInt32(row.Cells[0].Value.ToString().ToUpperInvariant());
                obj.DESCRIPCION = row.Cells[1].Value.ToString().ToUpperInvariant();
                obj.PERIODO = row.Cells[2].Value.ToString().ToUpperInvariant();
                showData(obj);
            }
        }
        public void clearControl()
        {
            throw new NotImplementedException();
        }
        public void Initialized()
        {
            throw new NotImplementedException();
        }
       
    }
}
