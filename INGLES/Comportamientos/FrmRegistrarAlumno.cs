﻿using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;


namespace Ingles
{

    public partial class FrmRegistrarAlumno
    {
        #region COMPORTAMIENTOS
        /// <summary>
        /// Habilita los controles para su primer uso 
        /// </summary>
        private void EscenaStart()
        {
            this.txt_Apellido_Materno.Enabled = true;
            this.txt_Apellido_Paterno.Enabled = true;
            this.txt_Curp.Enabled = true;
            this.txt_NoControl.Enabled = true;
            this.txt_Nombre.Enabled = true;
            this.txt_RFC.Enabled = true;
            this.btn_Registrar.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaReadyForSave()
        {
            _validaciones.ExecuteValidation();
            if (_validaciones.IsSave)
            {
                this.btn_Registrar.Enabled = true;
            }


        }
        /// <summary>
        /// se limpian los controles de captura y se deshabilita 
        /// </summary>
        private void EscenaClearControles()
        {
            EscenaStart();
            this.txt_Apellido_Materno.Text = "";
            this.txt_Apellido_Paterno.Text = "";
            this.txt_Curp.Text = "";
            this.txt_NoControl.Text = "";
            this.txt_Nombre.Text = "";
            this.txt_RFC.Text = "";
        }
        /// <summary>
        /// Excenas
        /// </summary>
        private void EscenaCancelar()
        {
            EscenaClearControles();
        }
        #endregion


        /// <summary>
        /// Registra las validaciones pertinentes para cada control de captura.
        /// </summary>
        private void LoadValidation()
        {
            _validaciones.ErrorProvider = this.err_FrmRegistraAlumno;
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_Apellido_Materno));
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_Apellido_Paterno));
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_Curp));
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_NoControl));
            _validaciones.Add(new ValidatorTextBoxRequired(this.txt_Nombre));
            _validaciones.Add(new ValidatorTextBoxCurp(this.txt_Curp));
        }

        /// <summary>
        /// Captura la informacion del los controles de usuario y 
        /// </summary>
        /// <returns></returns>
        private InglesEntity.Alumno DoCaptureInformation()
        {
            return new InglesEntity.Alumno()
            {
                NOMBRE = txt_Nombre.Text,
                APELLIDO_MATERNO = txt_Apellido_Materno.Text,
                APELLIDO_PATERNO = txt_Apellido_Paterno.Text,
                CURP = txt_Curp.Text,
                NO_CONTROL = txt_NoControl.Text
            };
        }


        /// <summary>
        /// Envia la informacion capturada a la logica de negocio.
        /// </summary>
        private void DoSendInformation()
        {
            _validaciones.ExecuteValidation();

            if (_validaciones.IsValid)
            {
                bll.DoCreateAlumno(DoCaptureInformation());
            }
        }
    }
}