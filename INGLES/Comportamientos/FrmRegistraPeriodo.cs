using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;

namespace Ingles
{
    public partial class FrmRegistraPeriodo
    {
        #region COMPORTAMIENTOS
        /// <summary>
        /// Habilita los controles para su primer uso 
        /// </summary>
        private void EscenaStart()
        {
            
            //Este es el escenario por default para esta pantalla.
            LoadCatalogs();
           
            
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
            
        }
        /// <summary>
        /// Excenas
        /// </summary>
        private void EscenaCancelar()
        {
            // validar si hay cambios pendientes antes de cancelar Enviar un mensaje, Esta seguro que desea cancelar sin haber guardado los cambios?
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
        #endregion

        #region FUNCIONES PRINCIPALES
        /// <summary>
        /// 
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
            
        }
        /// <summary>
        /// Registra las validaciones pertinentes para cada control de captura.
        /// </summary>
        private void LoadValidation()
        {
            /*
            Carga las Validaciones para la aplicacion.
            */
        }
        /// <summary>
        /// Da de Alta un Periodo Activo
        /// </summary>
        /// <returns></returns>
        private Periodo DoCaptureInformation()
        {
            /*crea un nuevo periodo con los datos actualizados de la entidad para enviarlos a la base de datos.*/
            return new Periodo();
        }
        /// <summary>
        /// Envia la informacion capturada a la logica de negocio.
        /// </summary>
        private void DoSendInformation()
        {            
            _validaciones.ExecuteValidation();

            if (_validaciones.IsValid) { }
         /* enviar a actualizar la informacion del periodo
        _bll.UpdatePeriodo(DoCaptureInformation());    
        */
        }
        #endregion
    }
}
