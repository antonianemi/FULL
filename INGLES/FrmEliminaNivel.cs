using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmEliminaNivel : FormBase
    {
        public FrmEliminaNivel(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }
    }
}
