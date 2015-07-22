﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InglesBLL;
using InglesEntity;
using Microsoft.Office.Interop.Excel; 

namespace Ingles
{
    public partial class FrmReportes : Form
    {

        public FrmReportes()
        {
            InitializeComponent();
            dataGridView1.DataSource = new List<Horario>
        {
            new Horario() {ID_HORARIO=1, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=2, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=3, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=4, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=5, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=6, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=7, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=8, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=9, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=10, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=11, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=12, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=13, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=14, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=15, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"},
            new Horario() {ID_HORARIO=16, HORA_INI="12:00pm", HORA_FIN="1:00pm", FECHA="20/04/1991", DESCRIPCION="HORARIO DE VERANO"}
        
        };

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    //creamos un objeto de tipo Excel sobre le cual vamos a trabajar (solo si ya agregamos la  referencia y la libreria) 
        //    using (Microsoft.Office.Interop.Excel.ApplicationClass excel = new Microsoft.Office.Interop.Excel.ApplicationClass())
        //    {
        //        //agregamos un nuevo libro a nuestro objeto excel
        //        excel.Application.Workbooks.Add(true);
        //        //contador para las columnas
        //        int ColumnIndex = 0;
        //        //este ciclo es para saber cuantas columnas y que nombre de encabezado tiene nuestro grid e irlas agregando a nuestro objeto excel
        //        foreach (DataGridViewColumn col in dataGridView1.Columns)
        //        {
        //            //aumentamos la variable de uno en uno por cada columna en el grid
        //            ColumnIndex++;
        //            //agregamos una nueva celda con el nombre de la columna para tener el encabezado de nuestra tabla de registro:
        //            //ejemplo:
        //            /*
        //             * Nombre | apellido | direccion | telefono
        //             * 
        //             * y de esta forma copiamos el encabezado de nuestro data grid a nuestro objeto de escel
        //             * */
        //            excel.Cells[1, ColumnIndex] = col.Name;
        //        }
        //        //variable para saber el numero de renglones
        //        int rowIndex = 0;
        //        //recorremos el grid cumpliedo la condicion del foreach que por cada renglon que halla en el grid hara lo que esta dentro del ciclo
        //        foreach (DataGridViewRow row in dataGridView1.Rows)
        //        {
        //            //aumentamos el numero del renglon
        //            rowIndex++;
        //            //el numero de columnas lo regresamos a cero
        //            ColumnIndex = 0;
        //            //en este ciclo recorremos cada columna del renglon en el que estamos trabajando, el recorrido es simple es recorrer una matriz
        //            foreach (DataGridViewColumn col in dataGridView1.Columns)
        //            {
        //                //aumentamos la columna
        //                ColumnIndex++;
        //                //agregamos el valor contenido en determinada posicion del grid a nuestro objeto de excel.
        //                /*
        //                 ejemplo: excel.cell[0+1,1]= row.cell["Nombre].value"
        //                 * 
        //                 * 
        //                 */
        //                excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
        //                //vamos a ir recorriendo todas las columnas, renglon por renglon hasta terminar los renglones que tenga nuestro grid
        //            }
        //        }
        //        //finalmente mostramos en pantalla nuestro archivo de excel listo para ser guardado.
        //        excel.Visible = true;
        //        //habilitamos una hoja
        //        Worksheet worksheet = (Worksheet)excel.ActiveSheet;
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {

                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                //hoja_trabajo =  (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        //hoja_trabajo.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
    }
}