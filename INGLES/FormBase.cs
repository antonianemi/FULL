﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using InglesEntity;



namespace Ingles
{

    /*Poner aqui el como validar y notificar pero sera esta clase la encargada de validar.*/
    public class FormBase : Form
    {
        protected Validator _validaciones;
        private Session _session;
        /// <summary>
        /// Indica si se pueden enviar a guardar los datos en la base de datos.
        /// </summary>
        public FormBase(Session session)
        {
            _validaciones = new Validator();
            this._session = session;
        }
        public FormBase()
        {
            _validaciones = new Validator();
        }
        public Usuario User
        {
            get { return _session.User; }
        }      
        /// <summary>
        /// 
        /// </summary>
        protected virtual void ShowError(Exception ex)
        {
            MessageBox.Show("AQUI HUBO UN PEDO WEY NO MAMES!!!!","Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Manifiesta un mensaje de Notificacion 
        /// </summary>
        /// <param name="Mensaje"></param>
        protected virtual void ShowNotification(string Mensaje)
        {
            MessageBox.Show(Mensaje, "",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mensaje"></param>
        /// <returns></returns>
        protected virtual bool ShowQuestion(string Mensaje)
        {
           if(DialogResult.OK == MessageBox.Show(Mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information))
                return true;            
            else            
                return false;
        }
        /// <summary>
        /// Asigna el nombre del usuario y la ip del equipo en la parte superior de la pantalla.
        /// </summary>
        protected virtual void ConfigureForm()
        {
            this.Text = String.Format("[{0}]   [Host {1}]", User.FullName, Environment.MachineName);
        }
    }






    /*
    Validar datos es el proceso de confirmar que los valores que se especifican en los objetos de datos son compatibles con las restricciones dentro
    de un esquema del conjunto de datos, al igual que las reglas establecidas para su aplicación. Validar datos antes de enviar actualizaciones a la 
    base de datos subyacente es una buena práctica que reduce los errores y la cantidad potencial de acciones de ida y vuelta entre una aplicación y 
    la base de datos. Para confirmar que son válidos los datos que se escriben en un conjunto de datos, se pueden construir comprobaciones de 
    validación en el propio conjunto de datos. El conjunto de datos puede comprobar los datos independientemente de cómo se esté realizando la 
    actualización, ya sea directamente mediante los controles de un formulario, desde dentro de un componente o de alguna otra manera. Dado que 
    el conjunto de datos forma parte de la aplicación, es lógico construir una validación específica de la aplicación (a diferencia de integrar 
    las mismas comprobaciones en el servidor de bases de datos).
        */
    /// <summary>
    /// Se encarga de validar los controles de usuario y notifica algun error que se encuentre especificado.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IsValid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSave { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<ItemValidar> _validaciones;

        /// <summary>
        /// 
        /// </summary>
        private ErrorProvider _ErrorProvider;

        /// <summary>
        /// 
        /// </summary>
        public ErrorProvider ErrorProvider
        {
            get { return _ErrorProvider; }
            set { _ErrorProvider = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Validator()
        {
            _validaciones = new List<ItemValidar>();
        }
        /// <summary>
        /// Agrega Validacion a un textbox
        /// </summary>
        /// <param name="control">Control Textbox a validar.</param>
        /// <param name="Tipo">Tipo de Validaciones a aplicar al textbox indicado.</param>
        public void Add(ItemValidar ValidacionesTextBox)
        {
            this._validaciones.Add(ValidacionesTextBox);
        }
        /// <summary>
        /// Ejecuta las Validaciones Pertinentes en 
        /// </summary>



        public void ExecuteValidation()
        {

            
            int ValidationSuccess = 0;


            //ESTA SECCION ES PARA CUANDO ESTE UN ERROR PROVIDER REGISTRADO
            if (_ErrorProvider != null)
            {
                _ErrorProvider.Clear();

                foreach (var item in _validaciones)
                {
                    item.Validate(_ErrorProvider);
                    if (item.IsValid)
                        ValidationSuccess++;
                    
                }
              
            }

            // ESTA SECCION ES PARA CUANDO NO SE TENGA NINGUN ERROR PROVIDER REGISTRADO COMO NOTIFICADOR DE ERROR.
            if(_ErrorProvider == null)
            {
                foreach (var item in _validaciones)
                {
                    item.Validate();
                    if (item.IsValid)
                        ValidationSuccess++;
                }            
            }


            if (ValidationSuccess.Equals(_validaciones.Count))
            {
                IsValid = true;
                IsSave = true;
            }


        }
        
    }
   


    #region VALIDACIONES
    /// <summary>
    /// Representa un iten a validar mismo que contiene
    /// </summary>
    public abstract class ItemValidar
    {

        #region CONSTANTES
        protected const string _PATTERNCURP = @"";
        protected const string _PATTERNEMAIL = @"";
        protected const string _PATTERNAPELLIDOPATERNO = @"";
        protected const string _PATTERNAPELLIDOMATERNO = @"";
        protected const string _PATTERNRFC = @"";
        protected const string _PATTERNEDAD = @"";
        protected const string _PATTERNCALLE = @"";
        protected const string _PATTERNESTADO = @"";
        protected const string _PATTERNSEXO = @"";
        #endregion

        #region CONTROLES
        protected TextBox _txtcontrol { set; get; }
        protected RadioButton _rdbcontrol { set; get; }
        protected DateTimePicker _dtmcontrol { set; get; }
        protected CheckBox _chkcontrol { set; get; }
        #endregion

        #region CONSTRUCTORES
        public ItemValidar(TextBox control)
        {
            this._txtcontrol = control;
        }
        public ItemValidar(RadioButton control)
        {
            this._rdbcontrol = control;
        }
        public ItemValidar(DateTimePicker control)
        {
            this._dtmcontrol = control;
        }
        public ItemValidar(CheckBox control)
        {
            this._chkcontrol = control;
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// 
        /// </summary>
        protected string pattern = "";
        /// <summary>
        /// 
        /// </summary>
        public bool IsValid { set; get; }
        /// <summary>
        /// 
        /// </summary>
        protected string Mensaje = "Campo invalido";
        #endregion

        #region METODOS
        /// <summary>
        /// Realiza las validaciones pertinentes al control indicado y manifiesta en la aplicacion de los campos.
        /// Falta Indicarle donde y como manifestara cada mensaje de error. si sera por error provider o si se mandara un mensaje
        /// o si sera una eqtiqueta global.
        /// </summary>
        public virtual void Validate()
        {
          
        }
        /// <summary>
        /// Manifiesta el error en un proveedor de errores que la vista puede tener.
        /// </summary>
        /// <param name="errorProvider"></param>
        public virtual void Validate(ErrorProvider errorProvider)
        {
           
        }
        #endregion
    }
    public class ValidatorTextBoxRequired: ItemValidar
    {
        public ValidatorTextBoxRequired(TextBox control) : base(control)
        {

        }
        public override void Validate()
        {
            if (_txtcontrol.Text == String.Empty)
            {   
                _txtcontrol.BackColor = Color.Orange;
                IsValid = false;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
        }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (_txtcontrol.Text == String.Empty)
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "Este Campo es Requerido!!");
                IsValid = false;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
        }
    }
    public class ValidatorTextBoxEmail : ItemValidar
    {
        
        public ValidatorTextBoxEmail(TextBox control) : base(control)
        {
            base.pattern = @"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            base.Mensaje = "Formato de Email Invalido!!";
        }

        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxCurp : ItemValidar
    {
        public ValidatorTextBoxCurp(TextBox control) : base(control) {
            pattern = @"^[+-]?\d+(\.\d+)?$*";
            Mensaje = "Formato de Curp Invalido!!";
        }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxNombre : ItemValidar
    {
        public ValidatorTextBoxNombre(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxApellidoPaterno : ItemValidar
    {
        public ValidatorTextBoxApellidoPaterno(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxApellidoMaterno : ItemValidar
    {
        public ValidatorTextBoxApellidoMaterno(TextBox control) : base(control)
        {
            base.pattern = @"\b(\w+)\W+(\1)\b";
            base.Mensaje = "Formato de Apellido Materno Invalido!!";
            
        }

        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxEdad : ItemValidar
    {
        public ValidatorTextBoxEdad(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxFechaNacimiento : ItemValidar
    {
        public ValidatorTextBoxFechaNacimiento(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }
        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxSexo : ItemValidar
    {
        public ValidatorTextBoxSexo(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }
        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxCalle : ItemValidar
    {
        public ValidatorTextBoxCalle(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }

    }
    public class ValidatorTextBoxEstado : ItemValidar
    {
        public ValidatorTextBoxEstado(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxMunicipio : ItemValidar
    {
        public ValidatorTextBoxMunicipio(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxNumeroInterior : ItemValidar
    {
        public ValidatorTextBoxNumeroInterior(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxNumeroExterior : ItemValidar
    {
        public ValidatorTextBoxNumeroExterior(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    public class ValidatorTextBoxProfesion : ItemValidar
    {
        public ValidatorTextBoxProfesion(TextBox control) : base(control) { }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Orange;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }

        public override void Validate()
        {
            if (Regex.IsMatch(_txtcontrol.Text, pattern, RegexOptions.IgnoreCase))
            {
                _txtcontrol.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _txtcontrol.BackColor = Color.Red;
                IsValid = false;
            }
        }
    }
    #endregion




















}
