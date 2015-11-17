using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmPruebasDatos : FormBase
    {
        public BindingSource BS = new BindingSource();

        public FrmPruebasDatos()
        {
            InitializeComponent();
        }
        
        public void Asignar(object obj)
        {
            BS.DataSource = obj;
            dataGridView1.DataSource = BS;
        }
       
    }
}
