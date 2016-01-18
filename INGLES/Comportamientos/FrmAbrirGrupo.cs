//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using InglesEntity;
//using InglesBLL;


//namespace Ingles
//{
//    public partial class FrmAbrirGrupo
//    {

//        #region Comportamientos Horario
//        private void HabilitaLunes()
//        {
//            InicioHoraLunes.Enabled = true;
//            InicioMinutoLunes.Enabled = true;
//            FinHoraLunes.Enabled = true;
//            FinMinutoLunes.Enabled = true;
//        }
//        private void HabilitaMartes()
//        {
//            InicioHoraMartes.Enabled = true;
//            InicioMinutoMartes.Enabled = true;
//            FinHoraMartes.Enabled = true;
//            FinMinutoMartes.Enabled = true;
//        }
//        private void HabilitaMiercoles()
//        {
//            InicioHoraMiercoles.Enabled = true;
//            InicioMinutoMiercoles.Enabled = true;
//            FinHoraMiercoles.Enabled = true;
//            FinMinutoMiercoles.Enabled = true;
//        }
//        private void HabilitaJueves()
//        {
//            InicioHoraJueves.Enabled = true;
//            InicioMinutoJueves.Enabled = true;
//            FinHoraJueves.Enabled = true;
//            FinMinutoJueves.Enabled = true;
//        }
//        private void HabilitaViernes()
//        {
//            InicioHoraViernes.Enabled = true;
//            InicioMinutoViernes.Enabled = true;
//            FinHoraViernes.Enabled = true;
//            FinMinutoViernes.Enabled = true;
//        }
//        private void HabilitaSabado()
//        {
//            InicioHoraSabado.Enabled = true;
//            InicioMinutoSabado.Enabled = true;
//            FinHoraSabado.Enabled = true;
//            FinMinutoSabado.Enabled = true;
//        }
//        private void HabilitaDomingo()
//        {
//            InicioHoraDomingo.Enabled = true;
//            InicioMinutoDomingo.Enabled = true;
//            FinHoraDomingo.Enabled = true;
//            FinMinutoDomingo.Enabled = true;
//        }
//        private void DesHabilitaLunes()
//        {
//            InicioHoraLunes.Enabled = false;
//            InicioMinutoLunes.Enabled = false;
//            FinHoraLunes.Enabled = false;
//            FinMinutoLunes.Enabled = false;
//        }
//        private void DesHabilitaMartes()
//        {
//            InicioHoraMartes.Enabled = false;
//            InicioMinutoMartes.Enabled = false;
//            FinHoraMartes.Enabled = false;
//            FinMinutoMartes.Enabled = false;
//        }
//        private void DesHabilitaMiercoles()
//        {
//            InicioHoraMiercoles.Enabled = false;
//            InicioMinutoMiercoles.Enabled = false;
//            FinHoraMiercoles.Enabled = false;
//            FinMinutoMiercoles.Enabled = false;
//        }
//        private void DesHabilitaJueves()
//        {
//            InicioHoraJueves.Enabled = false;
//            InicioMinutoJueves.Enabled = false;
//            FinHoraJueves.Enabled = false;
//            FinMinutoJueves.Enabled = false;
//        }
//        private void DesHabilitaViernes()
//        {
//            InicioHoraViernes.Enabled = false;
//            InicioMinutoViernes.Enabled = false;
//            FinHoraViernes.Enabled = false;
//            FinMinutoViernes.Enabled = false;
//        }
//        private void DesHabilitaSabado()
//        {
//            InicioHoraSabado.Enabled = false;
//            InicioMinutoSabado.Enabled = false;
//            FinHoraSabado.Enabled = false;
//            FinMinutoSabado.Enabled = false;
//        }
//        private void DesHabilitaDomingo()
//        {
//            InicioHoraDomingo.Enabled = false;
//            InicioMinutoDomingo.Enabled = false;
//            FinHoraDomingo.Enabled = false;
//            FinMinutoDomingo.Enabled = false;
//        }
//        #endregion





//        /// <summary>
//        /// 
//        /// </summary>
//        private void EscenaClearControles()
//        {

//        }
//        private void LeerCatalogos()
//        {
//            /*Cargar los catalogos en los controles necesarios.*/

//            this.cbm_Periodo.DataSource = TestEntity.getPeriodos();
//            this.cbm_Nivel.DisplayMember = "NIVEL";
//            this.cbm_Nivel.DataSource = TestEntity.getNiveles();
//            this.cbm_Periodo.DisplayMember = "PERIODO";
//        }
//        private void ClearCatalogos()
//        {

//        }
//        #region ESCENARIOS
//        /// <summary>
//        /// 
//        /// </summary>
//        private void EscenarioStart()
//        {

//            LeerCatalogos();
//        }
//        /// <summary>
//        /// 
//        /// </summary>
//        private void EscenarioCancelar()
//        {

//        }

//        #endregion

//        /// <summary>
//        /// 
//        /// </summary>
//        private void DoSendInformation()
//        {
//            try
//            {
//                _validaciones.ExecuteValidation();

//                if (_validaciones.IsValid)
//                {
//                    //bll.DoCreateAlumno(DoCaptureInformation());
//                    FrmPruebasDatos pruebas = new FrmPruebasDatos();
//                    pruebas.Asignar(DoCaptureInformation());
//                    pruebas.Show();
//                }
//            }
//            catch (Exception e)
//            {

//            }
//        }
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        private Curso DoCaptureInformation()
//        {
//            CursoBuilder obj = new CursoBuilder();
//            //obj.AsignarHorario(DoCapturaHorario());
//            //obj.AsignarNivel(new Nivel());
//            //obj.AsignarPeriodo(new Periodo());
//            obj.AgregarComentario(rtb_Comentarios.Text);
//            return obj.GetCurso(); 
//        }
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        private Horario DoCapturaHorario()
//        {
//            HorarioBuilder obj = new HorarioBuilder();            
//            if (chk_Lunes.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.LUNES, HoraFin = this.FinHoraLunes.Value.ToString(), HoraInicio = this.InicioHoraLunes.Value.ToString() });
//            if (chk_Martes.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.MARTES, HoraFin = this.FinHoraMartes.Value.ToString(), HoraInicio = this.InicioHoraMartes.Value.ToString() });
//            if (chk_Miercoles.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.MIERCOLES, HoraFin = this.FinHoraMiercoles.Value.ToString(), HoraInicio = this.InicioHoraMiercoles.Value.ToString() });
//            if (chk_Jueves.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.JUEVES, HoraFin = this.FinHoraJueves.Value.ToString(), HoraInicio = this.InicioHoraJueves.Value.ToString() });
//            if (chk_Viernes.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.VIERNES, HoraFin = this.FinHoraViernes.Value.ToString(), HoraInicio = this.InicioHoraViernes.Value.ToString() });
//            if (chk_Sabado.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.SABADO, HoraFin = this.FinHoraSabado.Value.ToString(), HoraInicio = this.InicioHoraSabado.Value.ToString() });
//            if (chk_Domingo.Checked)
//                obj.AddDias(new Dia() { DiaP = DIAS.DOMINGO, HoraFin = this.FinHoraDomingo.Value.ToString(), HoraInicio = this.InicioHoraDomingo.Value.ToString() });
//            return obj.getHorario();
//        }
//    }
//}
