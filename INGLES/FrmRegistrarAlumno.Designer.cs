﻿namespace Ingles
{
    partial class FrmRegistrarAlumno
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
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Curp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Apellido_Materno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Apellido_Paterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NoControl = new System.Windows.Forms.TextBox();
            this.lbl_NOCONTROL = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.err_FrmRegistraAlumno = new System.Windows.Forms.ErrorProvider(this.components);
            this.grb_Datos_Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_FrmRegistraAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Datos_Alumno
            // 
            this.grb_Datos_Alumno.Controls.Add(this.txt_Nombre);
            this.grb_Datos_Alumno.Controls.Add(this.label6);
            this.grb_Datos_Alumno.Controls.Add(this.dateTimePicker1);
            this.grb_Datos_Alumno.Controls.Add(this.label3);
            this.grb_Datos_Alumno.Controls.Add(this.txt_RFC);
            this.grb_Datos_Alumno.Controls.Add(this.label5);
            this.grb_Datos_Alumno.Controls.Add(this.txt_Curp);
            this.grb_Datos_Alumno.Controls.Add(this.label4);
            this.grb_Datos_Alumno.Controls.Add(this.txt_Apellido_Materno);
            this.grb_Datos_Alumno.Controls.Add(this.label2);
            this.grb_Datos_Alumno.Controls.Add(this.txt_Apellido_Paterno);
            this.grb_Datos_Alumno.Controls.Add(this.label1);
            this.grb_Datos_Alumno.Controls.Add(this.txt_NoControl);
            this.grb_Datos_Alumno.Controls.Add(this.lbl_NOCONTROL);
            this.grb_Datos_Alumno.Location = new System.Drawing.Point(10, 20);
            this.grb_Datos_Alumno.Margin = new System.Windows.Forms.Padding(2);
            this.grb_Datos_Alumno.Name = "grb_Datos_Alumno";
            this.grb_Datos_Alumno.Padding = new System.Windows.Forms.Padding(2);
            this.grb_Datos_Alumno.Size = new System.Drawing.Size(524, 235);
            this.grb_Datos_Alumno.TabIndex = 0;
            this.grb_Datos_Alumno.TabStop = false;
            this.grb_Datos_Alumno.Text = "Datos Alumno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(216, 54);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(286, 26);
            this.txt_Nombre.TabIndex = 1;
            this.txt_Nombre.Enter += new System.EventHandler(this.EscenaReadyForSave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "NOMBRE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 202);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // txt_RFC
            // 
            this.txt_RFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RFC.Location = new System.Drawing.Point(216, 169);
            this.txt_RFC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(286, 26);
            this.txt_RFC.TabIndex = 5;
            this.txt_RFC.Enter += new System.EventHandler(this.EscenaReadyForSave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "RFC";
            // 
            // txt_Curp
            // 
            this.txt_Curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Curp.Location = new System.Drawing.Point(216, 141);
            this.txt_Curp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Curp.Name = "txt_Curp";
            this.txt_Curp.Size = new System.Drawing.Size(286, 26);
            this.txt_Curp.TabIndex = 4;
            this.txt_Curp.Enter += new System.EventHandler(this.EscenaReadyForSave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CURP";
            // 
            // txt_Apellido_Materno
            // 
            this.txt_Apellido_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_Materno.Location = new System.Drawing.Point(216, 113);
            this.txt_Apellido_Materno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Apellido_Materno.Name = "txt_Apellido_Materno";
            this.txt_Apellido_Materno.Size = new System.Drawing.Size(286, 26);
            this.txt_Apellido_Materno.TabIndex = 3;
            this.txt_Apellido_Materno.Enter += new System.EventHandler(this.EscenaReadyForSave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDO MATERNO";
            // 
            // txt_Apellido_Paterno
            // 
            this.txt_Apellido_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_Paterno.Location = new System.Drawing.Point(216, 84);
            this.txt_Apellido_Paterno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Apellido_Paterno.Name = "txt_Apellido_Paterno";
            this.txt_Apellido_Paterno.Size = new System.Drawing.Size(286, 26);
            this.txt_Apellido_Paterno.TabIndex = 2;
            this.txt_Apellido_Paterno.Enter += new System.EventHandler(this.EscenaReadyForSave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "APELLIDO PATERNO";
            // 
            // txt_NoControl
            // 
            this.txt_NoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoControl.Location = new System.Drawing.Point(216, 24);
            this.txt_NoControl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NoControl.Name = "txt_NoControl";
            this.txt_NoControl.Size = new System.Drawing.Size(286, 26);
            this.txt_NoControl.TabIndex = 0;
            this.txt_NoControl.Enter += new System.EventHandler(this.EscenaReadyForSave);
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
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(282, 271);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(122, 19);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(439, 271);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(103, 19);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // err_FrmRegistraAlumno
            // 
            this.err_FrmRegistraAlumno.ContainerControl = this;
            // 
            // FrmRegistrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 331);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Apellido_Paterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NoControl;
        private System.Windows.Forms.Label lbl_NOCONTROL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Curp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ErrorProvider err_FrmRegistraAlumno;
    }
}