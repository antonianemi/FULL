namespace Ingles
{
    partial class FrmRegistraAlumno
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
            this.components = new System.ComponentModel.Container();
            this.grb_Datos_Alumno = new System.Windows.Forms.GroupBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.TXT_DOMICILIO = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_CARRERA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_NuevoIngreso = new System.Windows.Forms.CheckBox();
            this.rdbInterno = new System.Windows.Forms.RadioButton();
            this.rdbForaneo = new System.Windows.Forms.RadioButton();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.TXT_SEMESTRE = new System.Windows.Forms.TextBox();
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.txt_Apellido_Materno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.txt_Apellido_Paterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoPaterno = new System.Windows.Forms.Label();
            this.txt_NoControl = new System.Windows.Forms.TextBox();
            this.lbl_NOCONTROL = new System.Windows.Forms.Label();
            this.err_FrmRegistraAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.grb_Datos_Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_FrmRegistraAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Datos_Alumno
            // 
            this.grb_Datos_Alumno.Controls.Add(this.txt_Nombre);
            this.grb_Datos_Alumno.Controls.Add(this.btn_Cancelar);
            this.grb_Datos_Alumno.Controls.Add(this.TXT_DOMICILIO);
            this.grb_Datos_Alumno.Controls.Add(this.btn_Registrar);
            this.grb_Datos_Alumno.Controls.Add(this.label2);
            this.grb_Datos_Alumno.Controls.Add(this.TXT_CARRERA);
            this.grb_Datos_Alumno.Controls.Add(this.label1);
            this.grb_Datos_Alumno.Controls.Add(this.chk_NuevoIngreso);
            this.grb_Datos_Alumno.Controls.Add(this.rdbInterno);
            this.grb_Datos_Alumno.Controls.Add(this.rdbForaneo);
            this.grb_Datos_Alumno.Controls.Add(this.lbl_Nombre);
            this.grb_Datos_Alumno.Controls.Add(this.TXT_SEMESTRE);
            this.grb_Datos_Alumno.Controls.Add(this.lbl_RFC);
            this.grb_Datos_Alumno.Controls.Add(this.txt_Apellido_Materno);
            this.grb_Datos_Alumno.Controls.Add(this.lbl_ApellidoMaterno);
            this.grb_Datos_Alumno.Controls.Add(this.txt_Apellido_Paterno);
            this.grb_Datos_Alumno.Controls.Add(this.lbl_ApellidoPaterno);
            this.grb_Datos_Alumno.Controls.Add(this.txt_NoControl);
            this.grb_Datos_Alumno.Controls.Add(this.lbl_NOCONTROL);
            this.grb_Datos_Alumno.Location = new System.Drawing.Point(10, 20);
            this.grb_Datos_Alumno.Margin = new System.Windows.Forms.Padding(2);
            this.grb_Datos_Alumno.Name = "grb_Datos_Alumno";
            this.grb_Datos_Alumno.Padding = new System.Windows.Forms.Padding(2);
            this.grb_Datos_Alumno.Size = new System.Drawing.Size(620, 361);
            this.grb_Datos_Alumno.TabIndex = 0;
            this.grb_Datos_Alumno.TabStop = false;
            this.grb_Datos_Alumno.Text = "Datos Alumno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(222, 55);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(286, 26);
            this.txt_Nombre.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(356, 315);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 42);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.CANCELAR);
            // 
            // TXT_DOMICILIO
            // 
            this.TXT_DOMICILIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DOMICILIO.Location = new System.Drawing.Point(222, 204);
            this.TXT_DOMICILIO.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_DOMICILIO.Multiline = true;
            this.TXT_DOMICILIO.Name = "TXT_DOMICILIO";
            this.TXT_DOMICILIO.Size = new System.Drawing.Size(286, 20);
            this.TXT_DOMICILIO.TabIndex = 6;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(230, 315);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(122, 42);
            this.btn_Registrar.TabIndex = 9;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.REGISTRAR);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "DOMICILIO";
            // 
            // TXT_CARRERA
            // 
            this.TXT_CARRERA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CARRERA.Location = new System.Drawing.Point(222, 144);
            this.TXT_CARRERA.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_CARRERA.Name = "TXT_CARRERA";
            this.TXT_CARRERA.Size = new System.Drawing.Size(286, 26);
            this.TXT_CARRERA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "CARRERA";
            // 
            // chk_NuevoIngreso
            // 
            this.chk_NuevoIngreso.AutoSize = true;
            this.chk_NuevoIngreso.Location = new System.Drawing.Point(513, 28);
            this.chk_NuevoIngreso.Name = "chk_NuevoIngreso";
            this.chk_NuevoIngreso.Size = new System.Drawing.Size(96, 17);
            this.chk_NuevoIngreso.TabIndex = 17;
            this.chk_NuevoIngreso.Text = "Nuevo Ingreso";
            this.chk_NuevoIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chk_NuevoIngreso.UseVisualStyleBackColor = true;
            this.chk_NuevoIngreso.CheckedChanged += new System.EventHandler(this.NUEVOINGRESO);
            // 
            // rdbInterno
            // 
            this.rdbInterno.AutoSize = true;
            this.rdbInterno.Location = new System.Drawing.Point(271, 235);
            this.rdbInterno.Name = "rdbInterno";
            this.rdbInterno.Size = new System.Drawing.Size(119, 17);
            this.rdbInterno.TabIndex = 8;
            this.rdbInterno.TabStop = true;
            this.rdbInterno.Text = "ALUMNO DEL TEC";
            this.rdbInterno.UseVisualStyleBackColor = true;
            this.rdbInterno.CheckedChanged += new System.EventHandler(this.INTERNO);
            // 
            // rdbForaneo
            // 
            this.rdbForaneo.AutoSize = true;
            this.rdbForaneo.Location = new System.Drawing.Point(114, 235);
            this.rdbForaneo.Name = "rdbForaneo";
            this.rdbForaneo.Size = new System.Drawing.Size(77, 17);
            this.rdbForaneo.TabIndex = 7;
            this.rdbForaneo.TabStop = true;
            this.rdbForaneo.Text = "FORANEO";
            this.rdbForaneo.UseVisualStyleBackColor = true;
            this.rdbForaneo.CheckedChanged += new System.EventHandler(this.FORANEO);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(5, 58);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(85, 20);
            this.lbl_Nombre.TabIndex = 14;
            this.lbl_Nombre.Text = "NOMBRE";
            // 
            // TXT_SEMESTRE
            // 
            this.TXT_SEMESTRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEMESTRE.Location = new System.Drawing.Point(222, 174);
            this.TXT_SEMESTRE.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_SEMESTRE.Name = "TXT_SEMESTRE";
            this.TXT_SEMESTRE.Size = new System.Drawing.Size(286, 26);
            this.TXT_SEMESTRE.TabIndex = 5;
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RFC.Location = new System.Drawing.Point(5, 177);
            this.lbl_RFC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(106, 20);
            this.lbl_RFC.TabIndex = 10;
            this.lbl_RFC.Text = "SEMESTRE";
            // 
            // txt_Apellido_Materno
            // 
            this.txt_Apellido_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_Materno.Location = new System.Drawing.Point(222, 114);
            this.txt_Apellido_Materno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Apellido_Materno.Name = "txt_Apellido_Materno";
            this.txt_Apellido_Materno.Size = new System.Drawing.Size(286, 26);
            this.txt_Apellido_Materno.TabIndex = 3;
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(5, 117);
            this.lbl_ApellidoMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(187, 20);
            this.lbl_ApellidoMaterno.TabIndex = 4;
            this.lbl_ApellidoMaterno.Text = "APELLIDO MATERNO";
            // 
            // txt_Apellido_Paterno
            // 
            this.txt_Apellido_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_Paterno.Location = new System.Drawing.Point(222, 85);
            this.txt_Apellido_Paterno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Apellido_Paterno.Name = "txt_Apellido_Paterno";
            this.txt_Apellido_Paterno.Size = new System.Drawing.Size(286, 26);
            this.txt_Apellido_Paterno.TabIndex = 2;
            // 
            // lbl_ApellidoPaterno
            // 
            this.lbl_ApellidoPaterno.AutoSize = true;
            this.lbl_ApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoPaterno.Location = new System.Drawing.Point(5, 88);
            this.lbl_ApellidoPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ApellidoPaterno.Name = "lbl_ApellidoPaterno";
            this.lbl_ApellidoPaterno.Size = new System.Drawing.Size(184, 20);
            this.lbl_ApellidoPaterno.TabIndex = 2;
            this.lbl_ApellidoPaterno.Text = "APELLIDO PATERNO";
            // 
            // txt_NoControl
            // 
            this.txt_NoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoControl.Location = new System.Drawing.Point(222, 25);
            this.txt_NoControl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NoControl.Name = "txt_NoControl";
            this.txt_NoControl.Size = new System.Drawing.Size(286, 26);
            this.txt_NoControl.TabIndex = 0;
            // 
            // lbl_NOCONTROL
            // 
            this.lbl_NOCONTROL.AutoSize = true;
            this.lbl_NOCONTROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NOCONTROL.Location = new System.Drawing.Point(5, 28);
            this.lbl_NOCONTROL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NOCONTROL.Name = "lbl_NOCONTROL";
            this.lbl_NOCONTROL.Size = new System.Drawing.Size(204, 20);
            this.lbl_NOCONTROL.TabIndex = 0;
            this.lbl_NOCONTROL.Text = "NUMERO DE CONTROL";
            // 
            // err_FrmRegistraAlumno
            // 
            this.err_FrmRegistraAlumno.ContainerControl = this;
            // 
            // FrmRegistrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 392);
            this.Controls.Add(this.grb_Datos_Alumno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistrarAlumno";
            this.Text = "Registrar Alumno";
            this.grb_Datos_Alumno.ResumeLayout(false);
            this.grb_Datos_Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_FrmRegistraAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Datos_Alumno;
        private System.Windows.Forms.TextBox txt_Apellido_Materno;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
        private System.Windows.Forms.TextBox txt_Apellido_Paterno;
        private System.Windows.Forms.Label lbl_ApellidoPaterno;
        private System.Windows.Forms.TextBox txt_NoControl;
        private System.Windows.Forms.Label lbl_NOCONTROL;
        private System.Windows.Forms.TextBox TXT_SEMESTRE;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ErrorProvider err_FrmRegistraAlumno;
        private System.Windows.Forms.RadioButton rdbInterno;
        private System.Windows.Forms.RadioButton rdbForaneo;
        private System.Windows.Forms.CheckBox chk_NuevoIngreso;
        private System.Windows.Forms.TextBox TXT_DOMICILIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_CARRERA;
        private System.Windows.Forms.Label label1;
    }
}