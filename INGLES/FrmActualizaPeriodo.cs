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
    public partial class FrmActualizaPeriodo : Form,IForm
    {

        /// <summary>
        /// Representa el objeto para conectarse a la logica de negocio.
        /// </summary>
        BLL objbll = null;
        Periodo periodoSeleccionado = null;
        /// <summary>
        /// 
        /// </summary>
        public FrmActualizaPeriodo()
        {
            periodoSeleccionado = new Periodo();
            InitializeComponent();
            objbll = new BLL();
            Initialized();
        }
        /// <summary>
        /// 
        /// </summary>
        private void cleanControl()
        {
            
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
        /// Inicializa los parametros para ese formulario.
        /// </summary>
        public void Initialized()
        {
            btn_ACTUALIZAR.Enabled = false;
            grb_DatosNuevos.Enabled = false;           
            List<Periodo> periodos = objbll.getPeriodos();
            dtg_PERIODOS.DataSource = periodos;
            noPeriodos.Text = String.Format("Cantidad Periodos : {0} ", periodos.Count.ToString());
            string[] mounts = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            string[] years = { "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            cbm_mount_end.Items.Clear();
            cbm_mount_start.Items.Clear();
            cbm_year_start.Items.Clear();
            cbm_year_end.Items.Clear();
            cbm_mount_end.Items.AddRange(mounts);
            cbm_mount_start.Items.AddRange(mounts);
            cbm_year_start.Items.AddRange(years);
            cbm_year_end.Items.AddRange(years);
            cbm_year_start.SelectedIndex = 0;
            cbm_year_end.SelectedIndex = 0;
            cbm_mount_start.SelectedIndex = 0;
            cbm_mount_end.SelectedIndex = 0;
        }
        /// <summary>
        /// LLeva acabo las validadiones necesarias para ese formulario.
        /// </summary>
        void IForm.validate()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        public void clearControl()
        {
            Initialized();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtg_PERIODOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ((DataGridView)sender).SelectedRows)
            {
                Periodo obj = new Periodo();
                obj.ID_PERIODO = Convert.ToInt32(row.Cells[0].Value.ToString().ToUpperInvariant());
                obj.DESCRIPCION = row.Cells[1].Value.ToString().ToUpperInvariant();
                obj.PERIODO = row.Cells[2].Value.ToString().ToUpperInvariant();
                periodoSeleccionado = obj;
                showData(obj);
            }
            btn_ACTUALIZAR.Enabled = true;
            grb_DatosNuevos.Enabled = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            string inicio = cbm_mount_start.SelectedItem.ToString() + "-" + cbm_year_start.SelectedItem;
            string fin = cbm_mount_end.SelectedItem.ToString() + "-" + cbm_year_end.SelectedItem;

            periodoSeleccionado.PERIODO = String.Format("{0} - {1}", inicio, fin);
            periodoSeleccionado.DESCRIPCION = rtb_Descripcion.Text;
            objbll.updatePeriodo(periodoSeleccionado);
            dtg_PERIODOS.DataSource = objbll.getPeriodos();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
