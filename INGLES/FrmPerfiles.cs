using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;

namespace Ingles
{
    public partial class FrmPerfiles : Form
    {
        BLL objBll = null;

        public FrmPerfiles()
        {
            InitializeComponent();
           objBll = new BLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivel objNivel = new Nivel();
            objNivel.ID_NIVEL = 1;
            objNivel.DESCRIPCION = "Esta es la prueba";
            objNivel.MISION = "esta si es una verdadera prueba";
            objNivel.VISION = "ojdnbvonv";
            objNivel.OBJETIVO = "El objetivo antonio";
            Carrera objCarrera = new Carrera();
            objCarrera.NOMBRE = "ingenieria en sistemasc omputacionales";
            objCarrera.DESCRIPCION = "carrera pesada para estudiar sistemas";
            

           //List<Carrera> carreras = objBll.getCarreras();
           //List<Calificacion> calificaciones = objBll.getCalificaciones(); 
           //List<Curso> cursos = objBll.getCursos();
           //List<Docente> docentes = objBll.getDocentes();
           //List<Horario> horarios = objBll.getHorarios();
           //List<Nivel> niveles = objBll.getCatNiveles();
           //List<Periodo> periodos = objBll.getPeriodos();
           MessageBox.Show("");
        }
    }
}
