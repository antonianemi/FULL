using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmActualizaDocente : Form
    {
        public FrmActualizaDocente()
        {
            InitializeComponent();
            //Cargar objetos de docentes para actualizarlos.
            //No si el usuario realiza la busqueda que sea sobre los objetos
            //que ya esten en memorya.
            

            // De otra manera cargar los contenedores de objetos y
            // Realizar las busqueda y llenar el objeto con los resultados
            // 
            // 1.- buscar docente este llenara el objeto 
            // y lo traera al formulario con la unica opcion de poder actualizar
            // al momento de ejecutar el metodo de actualizar, enviar los datos
            // a la base de datos.



        }
        /// <summary>
        /// Valida los campos registrados.
        /// </summary>
        private void validate()
        {
            //validar el objeto antes de enviarlo a guardar a la base de 
            //datos.
        }
        /// <summary>
        /// Limpia los controles del formulario.
        /// </summary>
        private void limpiaControles()
        {
            //Limpiar los controles del formulario.
            //
        }
    }
}
