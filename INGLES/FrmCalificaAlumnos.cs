using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmCalificaAlumnos : FormBase
    {
        public FrmCalificaAlumnos(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }

      
    }
}
