using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InglesEntity;



namespace INGLES
{
    /*
     * EN ESTA CLASE SE DESARROLLARAN CONTROLES PERSONALIZADOS ECHOS POR ANTONIO DE JESUS CORTES LAGUNES.
     */
    public class CustomTree : TreeView
    {
        /// <summary>
        /// Constructor para este control.
        /// </summary>
        public CustomTree() : base() { }

        /// <summary>
        /// Representa una lista de periodos para dibujar en el treeview.
        /// </summary>
        List<Periodo> Periodos { set; get; }
        /// <summary>
        /// Representa una lista de alumnos para dibujar en el treeview.
        /// </summary>
        List<Alumno>  Alumnos { set; get; }
        /// <summary>
        /// Representa una lista de docente para dibujar en el treeview.
        /// </summary>
        List<Docente> Docentes { set; get; }
        /// <summary>
        /// Representa una lista de niveles para dibujar en el treeview.
        /// </summary>
        List<Nivel> Niveles { set; get; }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

  

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

    }






}
