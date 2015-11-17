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
    public partial class FrmActualizaPeriodo : FormBase
    {

        /// <summary>
        /// Representa el objeto para conectarse a la logica de negocio.
        /// </summary>
        BLL objbll = null;
        /// <summary>
        /// 
        /// </summary>
        public FrmActualizaPeriodo(Session obj) : base(obj)
        {
            InitializeComponent();
            objbll = new BLL();
            ConfigureForm();
            EscenaStart();
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SELECCIONAPERIODO(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row  in ((DataGridView)sender).SelectedRows)
            {
                ShowPeriodoSeleccionado(row);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACTUALIZAR(object sender, EventArgs e)
        {
            DoSendInformation();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CANCELAR(object sender, EventArgs e)
        {
            EscenaCancelar();
        }
    }
}
