using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using InglesBLL;
using InglesEntity;
using System.Windows.Forms;

namespace Ingles
{
    public partial class FrmAbrirGrupo : FormBase
    {
        GrupoManagerBLL _bll;
        public FrmAbrirGrupo()
        {
            InitializeComponent();
            _bll = new GrupoManagerBLL();
            EscenarioStart();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LUNES(object sender, EventArgs e)
        {
            if(chk_Lunes.Checked)
            HabilitaLunes();
            else
            DesHabilitaLunes();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MARTES(object sender, EventArgs e)
        {
            if (chk_Martes.Checked)
                HabilitaMartes();
            else
                DesHabilitaMartes();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIERCOLES(object sender, EventArgs e)
        {
            if (chk_Miercoles.Checked)
                HabilitaMiercoles();
            else
                DesHabilitaMiercoles();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JUEVES(object sender, EventArgs e)
        {
            if (chk_Jueves.Checked)
                HabilitaJueves();
            else
                DesHabilitaJueves();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VIERNES(object sender, EventArgs e)
        {
            if (chk_Viernes.Checked)
                HabilitaViernes();
            else
                DesHabilitaViernes();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SABADO(object sender, EventArgs e)
        {
            if (chk_Sabado.Checked)
                HabilitaSabado();
            else
                DesHabilitaSabado();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DOMINGO(object sender, EventArgs e)
        {
            if (chk_Domingo.Checked)
                HabilitaDomingo();
            else
                DesHabilitaDomingo();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GENERA_HORARIO(object sender, EventArgs e)
        {
            DoCapturaHorario();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ACEPTAR(object sender, EventArgs e)
        {
            DoSendInformation();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CANCELAR(object sender, EventArgs e)
        {
            
        }
       
    }
}
