namespace Ingles
{
    partial class FrmActualizaDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_SearchDocente = new System.Windows.Forms.PictureBox();
            this.txt_SearchDocente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lbl_Curp = new System.Windows.Forms.Label();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lbl_ApellidoPaterno = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_NoDocente = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNoDocente = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.dtg_Docentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SearchDocente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Docentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(27, 6);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(90, 22);
            this.lbl_Search.TabIndex = 14;
            this.lbl_Search.Text = "SEARCH";
            // 
            // btn_SearchDocente
            // 
            this.btn_SearchDocente.Location = new System.Drawing.Point(642, 3);
            this.btn_SearchDocente.Name = "btn_SearchDocente";
            this.btn_SearchDocente.Size = new System.Drawing.Size(39, 29);
            this.btn_SearchDocente.TabIndex = 13;
            this.btn_SearchDocente.TabStop = false;
            this.btn_SearchDocente.Click += new System.EventHandler(this.BUSCARDOCENTE);
            // 
            // txt_SearchDocente
            // 
            this.txt_SearchDocente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchDocente.Location = new System.Drawing.Point(123, 3);
            this.txt_SearchDocente.Name = "txt_SearchDocente";
            this.txt_SearchDocente.Size = new System.Drawing.Size(512, 29);
            this.txt_SearchDocente.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbl_FechaNacimiento);
            this.panel1.Controls.Add(this.lbl_RFC);
            this.panel1.Controls.Add(this.txtRFC);
            this.panel1.Controls.Add(this.lbl_Curp);
            this.panel1.Controls.Add(this.lbl_ApellidoMaterno);
            this.panel1.Controls.Add(this.lbl_ApellidoPaterno);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Controls.Add(this.lbl_NoDocente);
            this.panel1.Controls.Add(this.txtCurp);
            this.panel1.Controls.Add(this.txtApellidoMaterno);
            this.panel1.Controls.Add(this.txtApellidoPaterno);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtNoDocente);
            this.panel1.Location = new System.Drawing.Point(11, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 345);
            this.panel1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(561, 29);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(6, 310);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(231, 22);
            this.lbl_FechaNacimiento.TabIndex = 25;
            this.lbl_FechaNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RFC.Location = new System.Drawing.Point(6, 258);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(50, 22);
            this.lbl_RFC.TabIndex = 23;
            this.lbl_RFC.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Arial Black", 14.25F);
            this.txtRFC.Location = new System.Drawing.Point(250, 252);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(561, 34);
            this.txtRFC.TabIndex = 22;
            // 
            // lbl_Curp
            // 
            this.lbl_Curp.AutoSize = true;
            this.lbl_Curp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Curp.Location = new System.Drawing.Point(6, 208);
            this.lbl_Curp.Name = "lbl_Curp";
            this.lbl_Curp.Size = new System.Drawing.Size(64, 22);
            this.lbl_Curp.TabIndex = 21;
            this.lbl_Curp.Text = "CURP";
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(6, 162);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(205, 22);
            this.lbl_ApellidoMaterno.TabIndex = 20;
            this.lbl_ApellidoMaterno.Text = "APELLIDO MATERNO";
            // 
            // lbl_ApellidoPaterno
            // 
            this.lbl_ApellidoPaterno.AutoSize = true;
            this.lbl_ApellidoPaterno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoPaterno.Location = new System.Drawing.Point(6, 116);
            this.lbl_ApellidoPaterno.Name = "lbl_ApellidoPaterno";
            this.lbl_ApellidoPaterno.Size = new System.Drawing.Size(202, 22);
            this.lbl_ApellidoPaterno.TabIndex = 19;
            this.lbl_ApellidoPaterno.Text = "APELLIDO PATERNO";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 65);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(93, 22);
            this.lbl_Nombre.TabIndex = 18;
            this.lbl_Nombre.Text = "NOMBRE";
            // 
            // lbl_NoDocente
            // 
            this.lbl_NoDocente.AutoSize = true;
            this.lbl_NoDocente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoDocente.Location = new System.Drawing.Point(6, 12);
            this.lbl_NoDocente.Name = "lbl_NoDocente";
            this.lbl_NoDocente.Size = new System.Drawing.Size(133, 22);
            this.lbl_NoDocente.TabIndex = 17;
            this.lbl_NoDocente.Text = "No DOCENTE";
            // 
            // txtCurp
            // 
            this.txtCurp.Font = new System.Drawing.Font("Arial Black", 14.25F);
            this.txtCurp.Location = new System.Drawing.Point(250, 202);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(561, 34);
            this.txtCurp.TabIndex = 16;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Arial Black", 14.25F);
            this.txtApellidoMaterno.Location = new System.Drawing.Point(250, 156);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(561, 34);
            this.txtApellidoMaterno.TabIndex = 15;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Arial Black", 14.25F);
            this.txtApellidoPaterno.Location = new System.Drawing.Point(250, 110);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(561, 34);
            this.txtApellidoPaterno.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Black", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(250, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(561, 34);
            this.txtNombre.TabIndex = 13;
            // 
            // txtNoDocente
            // 
            this.txtNoDocente.Font = new System.Drawing.Font("Arial Black", 14.25F);
            this.txtNoDocente.Location = new System.Drawing.Point(250, 12);
            this.txtNoDocente.Name = "txtNoDocente";
            this.txtNoDocente.Size = new System.Drawing.Size(561, 34);
            this.txtNoDocente.TabIndex = 12;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(667, 556);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(122, 49);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.CANCELAR);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(529, 556);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(131, 49);
            this.btn_Actualizar.TabIndex = 9;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.ACTUALIZAR);
            // 
            // dtg_Docentes
            // 
            this.dtg_Docentes.AllowUserToAddRows = false;
            this.dtg_Docentes.AllowUserToDeleteRows = false;
            this.dtg_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Docentes.Location = new System.Drawing.Point(12, 38);
            this.dtg_Docentes.Name = "dtg_Docentes";
            this.dtg_Docentes.ReadOnly = true;
            this.dtg_Docentes.Size = new System.Drawing.Size(813, 148);
            this.dtg_Docentes.TabIndex = 8;
            this.dtg_Docentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SELECCIONAR_DOCENTE);
            // 
            // FrmActualizaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 627);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.btn_SearchDocente);
            this.Controls.Add(this.txt_SearchDocente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.dtg_Docentes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmActualizaDocente";
            this.Text = "Actualizar    Docente";
            ((System.ComponentModel.ISupportInitialize)(this.btn_SearchDocente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Docentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.PictureBox btn_SearchDocente;
        private System.Windows.Forms.TextBox txt_SearchDocente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lbl_Curp;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
        private System.Windows.Forms.Label lbl_ApellidoPaterno;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_NoDocente;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNoDocente;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.DataGridView dtg_Docentes;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}