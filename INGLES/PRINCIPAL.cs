using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InglesEntity;



namespace Ingles
{
    public partial class PRINCIPAL : Form
    {

        /// <summary>
        /// 
        /// </summary>
        private Session _Session { set; get; }

        private int childFormNumber = 0;

        public PRINCIPAL(Session obj)
        {    
            if (obj != null)
            {
                _Session = obj;
                InitializeComponent();
                FillInformationPrincipal();
            }
            else
            {
                this.Dispose();
            }
        }

        private void showNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void openFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void exitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void OP_ABRIRPERIODO(object sender, EventArgs e)
        {
            try{
                FrmRegistraPeriodo childForm = new FrmRegistraPeriodo(_Session);
                childForm.MdiParent = this;
                childForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                childForm.Show();
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        private void OP_UPDATEPERIODO(object sender, EventArgs e)
        {
        try{
            FrmEliminaPeriodo childForm = new FrmEliminaPeriodo(_Session);
            childForm.MdiParent = this;
            //childForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            childForm.Show();
        }
        catch (Exception ex)
        {
            showMessage(ex.Message);
        }
        }

        private void modificarPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
            FrmActualizaPeriodo childForm = new FrmActualizaPeriodo(_Session);
            childForm.MdiParent = this;            
            childForm.Show();
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        private void abrirNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {try{
            FrmRegistraNivel childForm = new FrmRegistraNivel();
            childForm.MdiParent = this;
            //childForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            childForm.Show();
        }
        catch (Exception ex)
        {
            showMessage(ex.Message);
        }
        }

        private void eliminarNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
            FrmEliminaNivel childForm = new FrmEliminaNivel(_Session);
            childForm.MdiParent = this;
            //childForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            childForm.Show();
             }
            catch(Exception ex){
                showMessage(ex.Message);
            }
        }

        private void modificarNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                         
                FrmActualizaNivel childForm = new FrmActualizaNivel(_Session);
                childForm.MdiParent = this;
                //childForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                childForm.Show();
                
            }
            catch(Exception ex){
                showMessage(ex.Message);
            }
        }

        private void showMessage(string msg)
        {
            MessageBox.Show(msg);
        }
      
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAcerdaDe().Show();
        }

        private void alumnosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alumnosExternosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private Form MdiChildExist(String sNombreChild)
        {
            foreach (Form frmExiste in this.MdiChildren)
                if (frmExiste.Name == sNombreChild)
                    return frmExiste;
            return null;
        }

        /// <summary>
        /// Se encarga de printar la informacion principal en el formulario.
        /// </summary>
        private void FillInformationPrincipal()
        {
            this.Text = _Session.User.Nombre;
            FillMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillMenu()
        {

            //List<object> items = new List<object>();
            //foreach (var item in this.menuStrip.Items)
            //{                
            //    items.Add(item);
            //}


        }

        private void REGISTRAR_ALUMNO(object sender, EventArgs e)
        {
            try
            {
                FrmRegistraAlumno childForm = new FrmRegistraAlumno(_Session);
                childForm.MdiParent = this;
                childForm.Show();
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        private void actualizarInformacionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarInformacionEstatusAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaDeCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //FrmAbrirGrupo childForm = new FrmAbrirGrupo(_Session);
                //childForm.MdiParent = this;
                //childForm.Show();
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }
    }
}
