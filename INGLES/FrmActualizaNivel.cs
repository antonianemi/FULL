using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmActualizaNivel : FormBase
    {
        public FrmActualizaNivel(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }
    }
}
