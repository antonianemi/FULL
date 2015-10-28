using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;




namespace Ingles
{

    /*Poner aqui el como validar y notificar pero sera esta clase la encargada de validar.*/
    public class FormBase : Form
    {
        protected Validator _validaciones;
        /// <summary>
        /// Indica si se pueden enviar a guardar los datos en la base de datos.
        /// </summary>
        public FormBase()
        {
            _validaciones = new Validator();
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
        private bool IsValidRequired { set; get; }
        public ValidatorTextBoxRequired(TextBox control) : base(control)
        {

        }

        public override void Validate()
        {
            if (_txtcontrol.Text == String.Empty)
            {
                
                _txtcontrol.BackColor = Color.Orange;
                IsValidRequired = false;
            }
            else
            {
                _txtcontrol.BackColor = Color.Green;
                IsValidRequired = true;
            }
        }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (_txtcontrol.Text == String.Empty)
            {
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
                errorProvider.SetError(_txtcontrol, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
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
    }
    public class ValidatorTextBoxNombre : ItemValidar
    {
        public ValidatorTextBoxNombre(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de Nombre Invalido!!";
        }
    }
    public class ValidatorTextBoxApellidoPaterno : ItemValidar
    {
        public ValidatorTextBoxApellidoPaterno(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de ApellidoPaterno Invalido!!";
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
                errorProvider.SetError(_txtcontrol, "El Formato de Apellido Materno No es Valido!!");
                IsValid = true;
            }
            else
            {
                errorProvider.SetError(_txtcontrol, "El Formato de Apellido Materno No es Valido!!");
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
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de Edad Invalido!!";
        }
    }
    public class ValidatorTextBoxFechaNacimiento : ItemValidar
    {
        public ValidatorTextBoxFechaNacimiento(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de FechaNacimiento Invalido!!";
        }
    }
    public class ValidatorTextBoxSexo : ItemValidar
    {
        public ValidatorTextBoxSexo(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de Sexo Invalido!!";
        }
    }
    public class ValidatorTextBoxCalle : ItemValidar
    {
        public ValidatorTextBoxCalle(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de Calle Invalido!!";
        }

    }
    public class ValidatorTextBoxEstado : ItemValidar
    {
        public ValidatorTextBoxEstado(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de Estado Invalido!!";
        }
    }
    public class ValidatorTextBoxMunicipio : ItemValidar
    {
        public ValidatorTextBoxMunicipio(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de Municipio Invalido!!";
        }
    }
    public class ValidatorTextBoxNumeroInterior : ItemValidar
    {
        public ValidatorTextBoxNumeroInterior(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de NumeroInterior Invalido!!";
        }
    }
    public class ValidatorTextBoxNumeroExterior : ItemValidar
    {
        public ValidatorTextBoxNumeroExterior(TextBox control) : base(control) { }
        public override void Validate()
        {
            pattern = @"";
            Mensaje = "Formato de NumeroExterior Invalido!!";
        }
    }
    public class ValidatorTextBoxProfesion : ItemValidar
    {
        public ValidatorTextBoxProfesion(TextBox control) : base(control) { }
        public override void Validate()
        {

            pattern = @"";
            Mensaje = "Formato de Profesion Invalido!!";

        }
    }

    #endregion


}
