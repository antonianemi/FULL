using System;
using System.Windows.Forms;
using InglesEntity;
using InglesBLL;

namespace Ingles
{
    public partial class FrmRegistraAlumno
    {


        private void setTipoPersonaInterno()
        {
            Interno = true;
            InternoNuevoIngreso = false;
            Foraneo = false;
            ForaneoNuevoIngreso = false;
        }
        private void setTipoPersonaInternoNuevoIngreso()
        {

            Interno = false;
            InternoNuevoIngreso = true;
            Foraneo = false;
            ForaneoNuevoIngreso = false;
        }
        private void setTipoPersonaForaneo()
        {
            Interno = false;
            InternoNuevoIngreso = false;
            Foraneo = true;
            ForaneoNuevoIngreso = false;
        }
        private void setTipoPersonaForaneoNuevoIngreso()
        {
            Interno = false;
            InternoNuevoIngreso = false;
            Foraneo = false;
            ForaneoNuevoIngreso = true;
        }

        #region COMPORTAMIENTOS
        /// <summary>
        /// Habilita los controles para su primer uso 
        /// </summary>
        private void EscenaStart()
        {
            this.txt_NoControl.Text = String.Empty;
            this.lbl_NOCONTROL.Visible = true;
            this.txt_NoControl.Visible = true;
            this.txt_Apellido_Materno.Enabled = true;
            this.txt_Apellido_Paterno.Enabled = true;
            this.txt_NoControl.Enabled = true;
            this.txt_Nombre.Enabled = true;
            this.TXT_SEMESTRE.Enabled = true;
            this.rdbInterno.Checked = true;
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaReadyForSave()
        {
            _validaciones.ExecuteValidation();
            if (_validaciones.IsSave)            
                this.btn_Registrar.Enabled = true;
        }
        /// <summary>
        /// se limpian los controles de captura y se deshabilita 
        /// </summary>
        private void EscenaClearControles()
        {
            EscenaStart();
            this.txt_Apellido_Materno.Text = String.Empty;
            this.txt_Apellido_Paterno.Text = String.Empty;
            this.txt_NoControl.Text = String.Empty;
            this.txt_Nombre.Text = String.Empty;
            this.TXT_SEMESTRE.Text = String.Empty;
            this.TXT_DOMICILIO.Text = String.Empty;
            this.TXT_CARRERA.Text = String.Empty;
        }
        /// <summary>
        /// Excenas
        /// </summary>
        private void EscenaCancelar()
        {
            EscenaClearControles();
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaForaneoNuevoIngreso()
        {
            txt_NoControl.Text = String.Empty;
            txt_NoControl.Visible = false;
            lbl_NOCONTROL.Visible = false;
            setTipoPersonaForaneoNuevoIngreso();
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaForaneo()
        {
            txt_NoControl.Text = String.Empty;
            txt_NoControl.Visible = false;
            lbl_NOCONTROL.Visible = false;
            chk_NuevoIngreso.Visible = false;
            setTipoPersonaForaneo();
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaInternoNuevoIngreso()
        {
            if (chk_NuevoIngreso.Checked)
            {
                txt_NoControl.Text = String.Empty;
                txt_NoControl.Visible = true;
                lbl_NOCONTROL.Visible = true;
                txt_NoControl.Enabled = false;
                setTipoPersonaInternoNuevoIngreso();
            }
            else
            { 
            txt_NoControl.Text = String.Empty;
            txt_NoControl.Visible = true;
            lbl_NOCONTROL.Visible = true;
            setTipoPersonaInterno();
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        private void EscenaInterno()
        {           
          txt_NoControl.Text = String.Empty;
          txt_NoControl.Visible = true;
          lbl_NOCONTROL.Visible = true;
          setTipoPersonaInterno();
          chk_NuevoIngreso.Visible = true;
        }
        #endregion






        /// <summary>
        /// 
        /// </summary>
        private void LoadCatalogos() { }
        /// <summary>
        /// Registra las validaciones pertinentes para cada control de captura.
        /// </summary>
        private void LoadValidation()
        {
            //_validaciones.ErrorProvider = this.err_FrmRegistraAlumno;
            //_validaciones.Add(new ValidatorTextBoxRequired(this.txt_Apellido_Materno));
            //_validaciones.Add(new ValidatorTextBoxRequired(this.txt_Apellido_Paterno));
            ////_validaciones.Add(new ValidatorTextBoxRequired(this.txt_Curp));
            //_validaciones.Add(new ValidatorTextBoxRequired(this.txt_NoControl));
            //_validaciones.Add(new ValidatorTextBoxRequired(this.txt_Nombre));
            ////_validaciones.Add(new ValidatorTextBoxCurp(this.txt_Curp));
            //_validaciones.Add(new ValidatorTextBoxEstado(this.txt_Apellido_Materno));
        }
        /// <summary>
        /// Captura la informacion del los controles de usuario y 
        /// </summary>
        /// <returns></returns>
        private Alumno DoCaptureInformation()
        {
            return new Alumno()
            {
                NOMBRE = txt_Nombre.Text,
                APELLIDO_MATERNO = txt_Apellido_Materno.Text,
                APELLIDO_PATERNO = txt_Apellido_Paterno.Text,
                CARRERA = TXT_CARRERA.Text,
                TIPOALUMNO= getTipoAlumno(),
                DOMICILIO = TXT_DOMICILIO.Text,
                SEMESTRE = TXT_SEMESTRE.Text,
                NO_CONTROL = txt_NoControl.Text
            };
        }
        

        private TIPOALUMNO getTipoAlumno()
        {
            if (InternoNuevoIngreso)
            {
                return TIPOALUMNO.InternoNuevoIngreso;
            }
            else if (Interno)
            {
                return TIPOALUMNO.Interno;
            }
            else if (Foraneo)
            {
                return TIPOALUMNO.Foraneo;
            }

            else if (ForaneoNuevoIngreso)
            {
                return TIPOALUMNO.ForaneoNuevoIngreso;
            }
            return TIPOALUMNO.Interno;
        }



        /// <summary>
        /// Envia la informacion capturada a la logica de negocio.
        /// </summary>
        private void DoSendInformation()
        {
            try {
                _validaciones.ExecuteValidation();

                if (_validaciones.IsValid)
                {
                    //bll.DoCreateAlumno(DoCaptureInformation());
                    FrmPruebasDatos pruebas=new FrmPruebasDatos();
                    pruebas.Asignar(DoCaptureInformation());
                    pruebas.Show();
                }
            }
            catch(Exception)
            {

            }
        }


    }
}
