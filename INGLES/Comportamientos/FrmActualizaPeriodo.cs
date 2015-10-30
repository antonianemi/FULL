using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InglesBLL;
using InglesEntity;



namespace Ingles
{
    public partial class FrmActualizaPeriodo
    {

        #region COMPORTAMIENTOS
        /// <summary>
        /// Habilita los controles para su primer uso 
        /// </summary>
        private void EscenaStart()
        {
            //Este es el escenario por default para esta pantalla.
            LoadCatalogs();
            cbm_year_start.SelectedIndex = 0;
            cbm_year_end.SelectedIndex = 0;
            cbm_mount_start.SelectedIndex = 0;
            cbm_mount_end.SelectedIndex = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaReadyForSave()
        {
            /*
            poner todo el codigo de comportamiento de los controles para permitir que estos puedan enviar a la base de datos.
            */
        }
        /// <summary>
        /// se limpian los controles de captura y se deshabilita 
        /// </summary>
        private void ClearControles()
        {
            this.cbm_mount_end.Items.Clear();
            this.cbm_mount_start.Items.Clear();
            this.cbm_year_start.Items.Clear();
            this.cbm_year_end.Items.Clear();
            this.rtb_Descripcion.Clear();
        }
        /// <summary>
        /// Excenas
        /// </summary>
        private void EscenaCancelar()
        {
            ShowQuestion("Tienes una modificacion pendiente con un periodo, si cancelas se perderan los datos en pantalla, estas seguro que deseas cancelar?");
            EscenaStart();
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaErrorGuardar()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaError()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        private void ShowPeriodoSeleccionado(System.Windows.Forms.DataGridViewRow row)
        {
                Periodo obj = new Periodo();
                obj.ID_PERIODO = Convert.ToInt32(row.Cells[0].Value.ToString().ToUpperInvariant());
                obj.DESCRIPCION = row.Cells[1].Value.ToString().ToUpperInvariant();
                obj.PERIODO = row.Cells[2].Value.ToString().ToUpperInvariant();

        }
        #endregion

        #region FUNCIONES PRINCIPALES

        /// <summary>
        /// LLeva acabo las configuraciones para acoplar el formulario.
        /// </summary>
        private void CondigureForm()
        {
            this.Text = String.Format("[{0}]   [Host {1}]", User.FullName, Environment.MachineName);
        }
        /// <summary>
        /// 
        /// </summary>
        private void LoadCatalogs()
        {

            ClearControles();

            string[] mounts = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            string[] years = { "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };

            cbm_mount_end.Items.AddRange(mounts);
            cbm_mount_start.Items.AddRange(mounts);
            cbm_year_start.Items.AddRange(years);
            cbm_year_end.Items.AddRange(years);
        }
        /// <summary>
        /// Registra las validaciones pertinentes para cada control de captura.
        /// </summary>
        private void LoadValidation()
        {
            //_validaciones.Add(new ValidatorTextBoxRequired(this.txt_Apellido_Materno));
        }
        /// <summary>
        /// Da de Alta un Periodo Activo
        /// </summary>
        /// <returns></returns>
        private Periodo DoCaptureInformation()
        {
            string inicio = cbm_mount_start.SelectedItem.ToString() + "-" + cbm_year_start.SelectedItem;
            string fin = cbm_mount_end.SelectedItem.ToString() + "-" + cbm_year_end.SelectedItem;
            return new Periodo()
            {
                PERIODO = String.Format("{0} - {1}", inicio, fin),
                DESCRIPCION = rtb_Descripcion.Text.ToUpperInvariant(),
                ID_PERIODO = 1,
                STATUS = estatusPeriodo.Activo
            };
        }
        /// <summary>
        /// Envia la informacion capturada a la logica de negocio.
        /// </summary>
        private void DoSendInformation()
        {

            _validaciones.ExecuteValidation();

            if (_validaciones.IsValid) { }
                //_bll.NewPeriodoSinNiveles(DoCaptureInformation());
        }
        #endregion


    }
}
