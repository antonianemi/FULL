using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;

namespace Ingles
{
    public partial class FrmRegistraDocente
    {


        /// <summary>
        /// 
        /// </summary>
        private void MessageConfirm()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void MessageError()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        private void EscenaClearControles()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void LeerCatalogos()
        {
            /*Cargar los catalogos en los controles necesarios.*/

            //this.cbm_Periodo.
        }
        /// <summary>
        /// 
        /// </summary>
        private void ClearCatalogos()
        {

        }

        #region ESCENARIOS
        /// <summary>
        /// 
        /// </summary>
        private void EscenarioStart()
        {

            LeerCatalogos();
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenarioCancelar()
        {

        }

        #endregion




        /// <summary>
        /// 
        /// </summary>
        private void DoSendInformation()
        {
            //bll.DoCreateAlumno(DoCaptureInformation());
            FrmPruebasDatos pruebas = new FrmPruebasDatos();
            pruebas.Asignar(DoCaptureInformation());
            pruebas.Show();
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Docente DoCaptureInformation()
        {
            return new Docente()
            {
                NOMBRE = txt_Nombre.Text,
                APELLIDO_PATERNO = txt_Apellido_Paterno.Text,
                APELLIDO_MATERNO = txt_Apellido_Materno.Text,
                CURP = txt_Curp.Text,
                FECHANACIMIENTO = FormatDate.DoConverFormato(dtm_FechaNacimiento.Value),
                RFC = txt_RFC.Text
            };
        }
    }
}
