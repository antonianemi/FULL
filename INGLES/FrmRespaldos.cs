using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmRespaldos : FormBase
    {
        public FrmRespaldos(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }
    }
}
