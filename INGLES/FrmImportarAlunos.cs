using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmImportarAlunos : FormBase
    {
        public FrmImportarAlunos(Session obj):base(obj)
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
