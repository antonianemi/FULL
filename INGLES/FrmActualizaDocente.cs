using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;


namespace Ingles
{
    public partial class FrmActualizaDocente : FormBase
    {
        DocenteManagerBLL _bll;

        public FrmActualizaDocente(Session obj):base(obj)
        {
            InitializeComponent();
            _bll = new DocenteManagerBLL();
            ConfigureForm();
        }
   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACTUALIZAR(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CANCELAR(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BUSCARDOCENTE(object sender, EventArgs e)
        {
            DoLoadResultsDocente();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SELECCIONAR_DOCENTE(object sender, DataGridViewCellEventArgs e)
        {
            MuestraDatosEditar(e.RowIndex);
        }


        /// <summary>
        /// 
        /// </summary>
        private void DoLoadResultsDocente()
        {   
            dtg_Docentes.DataSource = _bll.search(txt_SearchDocente.Text);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        private void MuestraDatosEditar(int Index)
        {
            Docente item = BuildDocente(Index);
            txtNoDocente.Text = item.NO_DOCENTE.ToString();
            txtNombre.Text = item.NOMBRE;
            txtApellidoMaterno.Text = item.APELLIDO_MATERNO;
            txtApellidoPaterno.Text = item.APELLIDO_PATERNO;
            txtCurp.Text = item.CURP;
            txtRFC.Text = item.RFC;
        }
        /// <summary>
        /// Se encarga de construir un objeto docente para mostrarlo en los controles.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Docente BuildDocente(int index)
        {
            Docente obj = new Docente();
            Docente obj2 = ((Docente)dtg_Docentes.Rows[index]);
            obj.NO_DOCENTE = obj2.NO_DOCENTE;
            obj.NOMBRE = obj2.NOMBRE;
            obj.APELLIDO_MATERNO = obj2.APELLIDO_MATERNO;
            obj.APELLIDO_PATERNO = obj2.APELLIDO_PATERNO;
            obj.CURP = obj2.CURP;
            obj.RFC = obj2.RFC;
            return obj;
        }
    }
}
