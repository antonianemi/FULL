namespace Ingles
{
    partial class FrmCalificaAlumnos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_Docente = new System.Windows.Forms.Label();
            this.lbl_Periodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(360, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // lbl_Docente
            // 
            this.lbl_Docente.AutoSize = true;
            this.lbl_Docente.Location = new System.Drawing.Point(21, 30);
            this.lbl_Docente.Name = "lbl_Docente";
            this.lbl_Docente.Size = new System.Drawing.Size(59, 13);
            this.lbl_Docente.TabIndex = 2;
            this.lbl_Docente.Text = "DOCENTE";
            // 
            // lbl_Periodo
            // 
            this.lbl_Periodo.AutoSize = true;
            this.lbl_Periodo.Location = new System.Drawing.Point(316, 30);
            this.lbl_Periodo.Name = "lbl_Periodo";
            this.lbl_Periodo.Size = new System.Drawing.Size(38, 13);
            this.lbl_Periodo.TabIndex = 3;
            this.lbl_Periodo.Text = "NIVEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PERIODO";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(86, 71);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(212, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // FrmCalificaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lbl_Periodo);
            this.Controls.Add(this.lbl_Docente);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmCalificaAlumnos";
            this.Text = "FrmCalificaAlumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_Docente;
        private System.Windows.Forms.Label lbl_Periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}