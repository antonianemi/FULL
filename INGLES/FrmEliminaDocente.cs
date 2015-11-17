using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmEliminaDocente : FormBase
    {
        public FrmEliminaDocente(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }
    }
}
