using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmBoletas : FormBase
    {
        public FrmBoletas(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void FrmBoletas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
