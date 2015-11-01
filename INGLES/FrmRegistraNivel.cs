using System;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;
using System.Collections.Generic;

namespace Ingles
{
    public partial class FrmRegistraNivel : Form 
    {

        BLL bll = null;
        List<Periodo> _periodos = new List<Periodo>();
        List<Nivel> _nivelesDisponibles = new List<Nivel>();
        Periodo _periodoselecionado = new Periodo();
        
        public FrmRegistraNivel()
        {
            InitializeComponent();
            bll = new BLL();
            Inicialized();
        }

        private void limpiaControles(int op)
        {
            switch (op)
            {
                case 0:
            lst_NIVELES.Items.Clear();
            lst_NIVELES_PERIODOS.Items.Clear();
            cbm_Periodo.Items.Clear();
                    break;

                case 1:
            lst_NIVELES.Items.Clear();
            lst_NIVELES_PERIODOS.Items.Clear();
                    break;
            }
            
        }

        private void validate()
        {

        }      

        private void Inicialized()
        {            
           // _periodos = bll.getPeriodos();                        
            cargaPeriodos();            
            lst_NIVELES.DisplayMember = "NIVEL";
            lst_NIVELES_PERIODOS.DisplayMember = "NIVEL";
            cbm_Periodo.DisplayMember = "PERIODO";
        }

        private void cargaPeriodos()
        {
            foreach (Periodo periodo in _periodos)
            {
               cbm_Periodo.Items.Add(periodo);
            }
        }

        private void btn_AgregaNivel_Click(object sender, EventArgs e)
        {
            if (lst_NIVELES.SelectedItem != null)
            {
                lst_NIVELES_PERIODOS.Items.Add(lst_NIVELES.SelectedItem);
                lst_NIVELES.Items.Remove(lst_NIVELES.SelectedItem);
            }
        }

        private void btn_AgregaNiveles_Click(object sender, EventArgs e)
        {
            foreach (var item in lst_NIVELES.Items)
            {
                lst_NIVELES_PERIODOS.Items.Add(item);
                lst_NIVELES.Items.Remove(item);
            }
        }        

        private void btn_QuitaNieveles_Click(object sender, EventArgs e)
        {            
            foreach (var item in lst_NIVELES_PERIODOS.Items)
            {
                lst_NIVELES.Items.Add(item);
                lst_NIVELES_PERIODOS.Items.Remove(item);
            }
        }
        
        private void cbm_Periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _periodoselecionado = (Periodo)((ComboBox)sender).SelectedItem;
           //_nivelesDisponibles = bll.nivelesDisponibles(_periodoselecionado);
            limpiaControles(1);
            cargaCatNiveles();
            cargaNivelesPeriodos();
        }
        
        private void cargaCatNiveles()
        {
            foreach (Nivel nivel in _nivelesDisponibles)
            {
                lst_NIVELES.Items.Add(nivel);
            }
            lst_NIVELES.DisplayMember = "NIVEL";
        }

        private void cargaNivelesPeriodos()
        {
            foreach (Nivel nivel in _periodoselecionado.NIVELES)
            {
                lst_NIVELES_PERIODOS.Items.Add(nivel);
            }
            lst_NIVELES_PERIODOS.DisplayMember = "NIVEL";
        }

        private void btn_uitaNieveles_Click(object sender, EventArgs e)
        {
            if (lst_NIVELES_PERIODOS.SelectedItem != null)
            {
            lst_NIVELES.Items.Add(lst_NIVELES_PERIODOS.SelectedItem);
            lst_NIVELES_PERIODOS.Items.Remove(lst_NIVELES_PERIODOS.SelectedItem);
            }
        }

        #region Botones de formulario
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            // Armar el periodo nuevamente con sus niveles a como quedaron en los paneles 
            // Mandar a actualizar los niveles asignados a ese periodo.
            // Aqui solo necesito un metodo a donde yo le pase el periodo con los nuevos objetos nivel que quiero que contenga.
            // Ese metodo debe hacerme la chamba de actualizar esos periodos en la base de datos.

            foreach (var item in lst_NIVELES_PERIODOS.Items)
            {
             _periodoselecionado.NIVELES.Add((Nivel)item);
            }           

           //bll.actualizaNivelesPeriodo(_periodoselecionado);

        }
        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            limpiaControles(0);
            Inicialized();
        }
        #endregion

    }
}