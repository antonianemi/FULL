namespace Ingles
{
    partial class FrmRegistraNivel
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
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cbm_Periodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_NIVELES = new System.Windows.Forms.ListBox();
            this.lst_NIVELES_PERIODOS = new System.Windows.Forms.ListBox();
            this.btn_AgregaNivel = new System.Windows.Forms.Button();
            this.btn_AgregaNiveles = new System.Windows.Forms.Button();
            this.btn_quitaNiveles = new System.Windows.Forms.Button();
            this.btn_uitaNieveles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(221, 368);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 33);
            this.btn_Registrar.TabIndex = 0;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(375, 368);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // cbm_Periodo
            // 
            this.cbm_Periodo.FormattingEnabled = true;
            this.cbm_Periodo.Location = new System.Drawing.Point(155, 12);
            this.cbm_Periodo.Name = "cbm_Periodo";
            this.cbm_Periodo.Size = new System.Drawing.Size(415, 24);
            this.cbm_Periodo.TabIndex = 2;
            this.cbm_Periodo.SelectedIndexChanged += new System.EventHandler(this.cbm_Periodo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "PERIODO";
            // 
            // lst_NIVELES
            // 
            this.lst_NIVELES.FormattingEnabled = true;
            this.lst_NIVELES.ItemHeight = 16;
            this.lst_NIVELES.Location = new System.Drawing.Point(123, 141);
            this.lst_NIVELES.Name = "lst_NIVELES";
            this.lst_NIVELES.Size = new System.Drawing.Size(173, 196);
            this.lst_NIVELES.TabIndex = 7;
            // 
            // lst_NIVELES_PERIODOS
            // 
            this.lst_NIVELES_PERIODOS.FormattingEnabled = true;
            this.lst_NIVELES_PERIODOS.ItemHeight = 16;
            this.lst_NIVELES_PERIODOS.Location = new System.Drawing.Point(375, 141);
            this.lst_NIVELES_PERIODOS.Name = "lst_NIVELES_PERIODOS";
            this.lst_NIVELES_PERIODOS.Size = new System.Drawing.Size(173, 196);
            this.lst_NIVELES_PERIODOS.TabIndex = 8;
            // 
            // btn_AgregaNivel
            // 
            this.btn_AgregaNivel.Location = new System.Drawing.Point(314, 192);
            this.btn_AgregaNivel.Name = "btn_AgregaNivel";
            this.btn_AgregaNivel.Size = new System.Drawing.Size(43, 25);
            this.btn_AgregaNivel.TabIndex = 9;
            this.btn_AgregaNivel.Text = ">";
            this.btn_AgregaNivel.UseVisualStyleBackColor = true;
            this.btn_AgregaNivel.Click += new System.EventHandler(this.btn_AgregaNivel_Click);
            // 
            // btn_AgregaNiveles
            // 
            this.btn_AgregaNiveles.Enabled = false;
            this.btn_AgregaNiveles.Location = new System.Drawing.Point(314, 221);
            this.btn_AgregaNiveles.Name = "btn_AgregaNiveles";
            this.btn_AgregaNiveles.Size = new System.Drawing.Size(43, 25);
            this.btn_AgregaNiveles.TabIndex = 10;
            this.btn_AgregaNiveles.Text = ">>";
            this.btn_AgregaNiveles.UseVisualStyleBackColor = true;
            this.btn_AgregaNiveles.Click += new System.EventHandler(this.btn_AgregaNiveles_Click);
            // 
            // btn_quitaNiveles
            // 
            this.btn_quitaNiveles.Enabled = false;
            this.btn_quitaNiveles.Location = new System.Drawing.Point(314, 250);
            this.btn_quitaNiveles.Name = "btn_quitaNiveles";
            this.btn_quitaNiveles.Size = new System.Drawing.Size(43, 25);
            this.btn_quitaNiveles.TabIndex = 11;
            this.btn_quitaNiveles.Text = "<<";
            this.btn_quitaNiveles.UseVisualStyleBackColor = true;
            // 
            // btn_uitaNieveles
            // 
            this.btn_uitaNieveles.Location = new System.Drawing.Point(314, 279);
            this.btn_uitaNieveles.Name = "btn_uitaNieveles";
            this.btn_uitaNieveles.Size = new System.Drawing.Size(43, 27);
            this.btn_uitaNieveles.TabIndex = 12;
            this.btn_uitaNieveles.Text = "<";
            this.btn_uitaNieveles.UseVisualStyleBackColor = true;
            this.btn_uitaNieveles.Click += new System.EventHandler(this.btn_uitaNieveles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Niveles Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Niveles Asignados";
            // 
            // FrmRegistraNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uitaNieveles);
            this.Controls.Add(this.btn_quitaNiveles);
            this.Controls.Add(this.btn_AgregaNiveles);
            this.Controls.Add(this.btn_AgregaNivel);
            this.Controls.Add(this.lst_NIVELES_PERIODOS);
            this.Controls.Add(this.lst_NIVELES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbm_Periodo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Name = "FrmRegistraNivel";
            this.Text = "Registrar   Nivel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cbm_Periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_NIVELES;
        private System.Windows.Forms.ListBox lst_NIVELES_PERIODOS;
        private System.Windows.Forms.Button btn_AgregaNivel;
        private System.Windows.Forms.Button btn_AgregaNiveles;
        private System.Windows.Forms.Button btn_quitaNiveles;
        private System.Windows.Forms.Button btn_uitaNieveles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}