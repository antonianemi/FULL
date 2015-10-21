using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    
    
    /// <summary>
    /// Se encarga de validar los controles de usuario y notifica algun error que se encuentre especificado.
    /// </summary>
    public class Validator
    {

        /// <summary>
        /// 
        /// </summary>
        public bool IsValid { get; set; }

        public bool IsSave { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<ItemValidarTextBox> _validacionesTextBox;

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
            _validacionesTextBox = new List<ItemValidarTextBox>();
        }


        /// <summary>
        /// Agrega Validacion a un textbox
        /// </summary>
        /// <param name="control">Control Textbox a validar.</param>
        /// <param name="Tipo">Tipo de Validaciones a aplicar al textbox indicado.</param>
        public void Add(ItemValidarTextBox ValidacionesTextBox)
        {
            this._validacionesTextBox.Add(ValidacionesTextBox);
        }        







        /// <summary>
        /// Ejecuta las Validaciones Pertinentes en 
        /// </summary>
        public void ExecuteValidation()
        {

            
            int count = 0;
            if (_ErrorProvider != null)
            {
                _ErrorProvider.Clear();

                foreach (var item in _validacionesTextBox)
                {
                    item.Validate(_ErrorProvider);

                    if (item.IsValid)
                        count++;
                    
                }
                if (count.Equals(_validacionesTextBox.Count)) { 
                    IsValid = true;
                    IsSave = true;
                }
            }


            if(_ErrorProvider == null)
            {
                foreach (var item in _validacionesTextBox)
                {
                    item.Validate();
                    if (item.IsValid)
                        count++;
                }
                if (count.Equals(_validacionesTextBox.Count))
                {
                    IsValid = true;
                    IsSave = true;
                }


            }



        }






    }









    /// <summary>
    /// Representa un iten a validar mismo que contiene
    /// </summary>
    public abstract class ItemValidarTextBox
    {
        protected TextBox _control { set; get; }
        protected RadioButton _rdbcontrol { set; get; }
        protected DateTimePicker _dtmcontrol { set; get; }
        protected string pattern;
        public bool IsValid { set; get; }
        protected string Mensaje = "Campo invalido";
        public ItemValidarTextBox(TextBox control)
        {
            this._control = control;
        }
        
        /// <summary>
        /// Realiza las validaciones pertinentes al control indicado y manifiesta en la aplicacion de los campos.
        /// Falta Indicarle donde y como manifestara cada mensaje de error. si sera por error provider o si se mandara un mensaje
        /// o si sera una eqtiqueta global.
        /// </summary>
        public virtual void Validate()
        {
            if (Regex.IsMatch(_control.Text, pattern, RegexOptions.IgnoreCase))
            {
                _control.BackColor = Color.Green;
                IsValid = true;
            }
            else
            {
                _control.BackColor = Color.Red;
                IsValid = false;
            }
        }
        /// <summary>
        /// Manifiesta el error en un proveedor de errores que la vista puede tener.
        /// </summary>
        /// <param name="errorProvider"></param>
        public virtual void Validate(ErrorProvider errorProvider)
        {
            if (Regex.IsMatch(_control.Text, pattern, RegexOptions.IgnoreCase))
            {
                errorProvider.SetError(_control, "El Formato de Email No es Valido!!");
                IsValid = true;
            }
            else
            {
                errorProvider.SetError(_control, "El Formato de Email No es Valido!!");
                IsValid = false;
            }
        }
    }








    public class ValidatorTextBoxRequired: ItemValidarTextBox
    {
        public ValidatorTextBoxRequired(TextBox control) : base(control)
        {

        }


        public override void Validate()
        {
            if (_control.Text == String.Empty)
            {
                _control.BackColor = Color.Red;
                IsValid = false;
            }
            else
            {
                _control.BackColor = Color.Green;
                IsValid = true;
            }
        }
        public override void Validate(ErrorProvider errorProvider)
        {
            if (_control.Text == String.Empty)
            {
                errorProvider.SetError(_control, "Este Campo es Requerido!!");
                IsValid = false;
            }
            else
            {
                _control.BackColor = Color.Green;
                IsValid = true;
            }
        }

    }



    public class ValidatorTextBoxEmail : ItemValidarTextBox
    {
        
        public ValidatorTextBoxEmail(TextBox control) : base(control)
        {
            pattern = @"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            Mensaje = "Formato de Email Invalido!!";
        }
    }
    public class ValidatorTextBoxCurp : ItemValidarTextBox
    {
        public ValidatorTextBoxCurp(TextBox control) : base(control) {
            pattern = @"^[+-]?\d+(\.\d+)?$*";
            Mensaje = "Formato de Curp Invalido!!";
        }
    }
    public class ValidatorTextBoxNombre : ItemValidarTextBox
    {
        public ValidatorTextBoxNombre(TextBox control) : base(control) { }
        public override void Validate()
        {
            
        }
    }
    public class ValidatorTextBoxApellidoPaterno : ItemValidarTextBox
    {
        public ValidatorTextBoxApellidoPaterno(TextBox control) : base(control) { }
        public override void Validate()
        {
           
        }
    }
    public class ValidatorTextBoxApellidoMaterno : ItemValidarTextBox
    {
        public ValidatorTextBoxApellidoMaterno(TextBox control) : base(control) { }
        public override void Validate()
        {
           
        }
    }
    public class ValidatorTextBoxEdad : ItemValidarTextBox
    {
        public ValidatorTextBoxEdad(TextBox control) : base(control) { }
        public override void Validate()
        {
            
        }
    }
    public class ValidatorTextBoxFechaNacimiento : ItemValidarTextBox
    {
        public ValidatorTextBoxFechaNacimiento(TextBox control) : base(control) { }
        public override void Validate()
        {
           
        }
    }
    public class ValidatorTextBoxSexo : ItemValidarTextBox
    {
        public ValidatorTextBoxSexo(TextBox control) : base(control) { }
        public override void Validate()
        {
          
        }
    }
    public class ValidatorTextBoxCalle : ItemValidarTextBox
    {
        public ValidatorTextBoxCalle(TextBox control) : base(control) { }
        public override void Validate()
        {
           
        }

    }
    public class ValidatorTextBoxEstado : ItemValidarTextBox
    {
        public ValidatorTextBoxEstado(TextBox control) : base(control) { }
        public override void Validate()
        {
            
        }
    }
    public class ValidatorTextBoxMunicipio : ItemValidarTextBox
    {
        public ValidatorTextBoxMunicipio(TextBox control) : base(control) { }
        public override void Validate()
        {
           
        }
    }
    public class ValidatorTextBoxNumeroInterior : ItemValidarTextBox
    {
        public ValidatorTextBoxNumeroInterior(TextBox control) : base(control) { }
        public override void Validate()
        {
           
        }
    }
    public class ValidatorTextBoxNumeroExterior : ItemValidarTextBox
    {
        public ValidatorTextBoxNumeroExterior(TextBox control) : base(control) { }
        public override void Validate()
        {
            
        }
    }
    public class ValidatorTextBoxProfesion : ItemValidarTextBox
    {
        public ValidatorTextBoxProfesion(TextBox control) : base(control) { }
        public override void Validate()
        {

            if (_control != null)
            {
                /*
              1 caso de exito

            1.- Extraer la propiedad donde debe estar el texto
            2.- Comparar esa propiedad para ver si es una profesion.
            3.- No tocar la Bandera de Falso.
            
            
            2 caso de fracaso
            
            1.- extraer la propiedad donde debe estar el texto.
            2.- Comparar esa propiedad para ver si es una profesion.
            3.- Establecer la bandera en falso.
            4.- Manifestar en el control el mensaje del error.
             
            */


            }

        }
    }

}
