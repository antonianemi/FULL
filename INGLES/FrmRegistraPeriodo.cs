using System;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;


namespace Ingles
{
    public partial class FrmRegistraPeriodo : Form, IForm
    {
        BLL objbll = null;
        public FrmRegistraPeriodo()
        {
            InitializeComponent();
            objbll = new BLL();
            Initialized();
        }

        public void clearControl()
        {
            cbm_mount_end.Items.Clear();
            cbm_mount_start.Items.Clear();
            cbm_year_start.Items.Clear();
            cbm_year_end.Items.Clear();
            rtb_Descripcion.Clear();
        }

        public void Initialized()
        {
            string[] mounts = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            string[] years = { "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            clearControl();

            cbm_mount_end.Items.AddRange(mounts);
            cbm_mount_start.Items.AddRange(mounts);
            cbm_year_start.Items.AddRange(years);
            cbm_year_end.Items.AddRange(years);

            cbm_year_start.SelectedIndex = 0;
            cbm_year_end.SelectedIndex = 0;
            cbm_mount_start.SelectedIndex = 0;
            cbm_mount_end.SelectedIndex = 0;
        }

        void IForm.validate()
        {
          
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            clearControl();

        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {            
            string inicio = cbm_mount_start.SelectedItem.ToString() + "-" + cbm_year_start.SelectedItem;
            string fin = cbm_mount_end.SelectedItem.ToString() + "-" + cbm_year_end.SelectedItem;
            Periodo obj = new Periodo();
            obj.PERIODO = String.Format("{0} - {1}", inicio, fin);
            obj.DESCRIPCION = rtb_Descripcion.Text.ToUpperInvariant();
            obj.STATUS = estatusPeriodo.Activo;
            objbll.insertPeriodo(obj);
            clearControl();
        }

        private void FrmRegistraPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

    }
}
