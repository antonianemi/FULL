namespace Ingles
{
    partial class FrmRegistraPeriodo
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
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cbm_mount_start = new System.Windows.Forms.ComboBox();
            this.cbm_year_start = new System.Windows.Forms.ComboBox();
            this.cbm_year_end = new System.Windows.Forms.ComboBox();
            this.cbm_mount_end = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Abrir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir.Location = new System.Drawing.Point(256, 170);
            this.btn_Abrir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(81, 28);
            this.btn_Abrir.TabIndex = 0;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.Abrir);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(349, 170);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(81, 28);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // cbm_mount_start
            // 
            this.cbm_mount_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbm_mount_start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_mount_start.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_mount_start.FormattingEnabled = true;
            this.cbm_mount_start.Location = new System.Drawing.Point(17, 33);
            this.cbm_mount_start.Margin = new System.Windows.Forms.Padding(2);
            this.cbm_mount_start.Name = "cbm_mount_start";
            this.cbm_mount_start.Size = new System.Drawing.Size(106, 24);
            this.cbm_mount_start.TabIndex = 2;
            // 
            // cbm_year_start
            // 
            this.cbm_year_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbm_year_start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_year_start.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_year_start.FormattingEnabled = true;
            this.cbm_year_start.Location = new System.Drawing.Point(126, 33);
            this.cbm_year_start.Margin = new System.Windows.Forms.Padding(2);
            this.cbm_year_start.Name = "cbm_year_start";
            this.cbm_year_start.Size = new System.Drawing.Size(62, 24);
            this.cbm_year_start.TabIndex = 3;
            // 
            // cbm_year_end
            // 
            this.cbm_year_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbm_year_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_year_end.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_year_end.FormattingEnabled = true;
            this.cbm_year_end.Location = new System.Drawing.Point(368, 33);
            this.cbm_year_end.Margin = new System.Windows.Forms.Padding(2);
            this.cbm_year_end.Name = "cbm_year_end";
            this.cbm_year_end.Size = new System.Drawing.Size(62, 24);
            this.cbm_year_end.TabIndex = 5;
            // 
            // cbm_mount_end
            // 
            this.cbm_mount_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbm_mount_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_mount_end.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_mount_end.FormattingEnabled = true;
            this.cbm_mount_end.Location = new System.Drawing.Point(241, 33);
            this.cbm_mount_end.Margin = new System.Windows.Forms.Padding(2);
            this.cbm_mount_end.Name = "cbm_mount_end";
            this.cbm_mount_end.Size = new System.Drawing.Size(123, 24);
            this.cbm_mount_end.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "MES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "AÑO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "INICIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "FIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "AÑO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "MES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "----";
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Descripcion.Location = new System.Drawing.Point(24, 87);
            this.rtb_Descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(406, 79);
            this.rtb_Descripcion.TabIndex = 13;
            this.rtb_Descripcion.Text = "";
            // 
            // FrmRegistraPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 206);
            this.Controls.Add(this.rtb_Descripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbm_year_end);
            this.Controls.Add(this.cbm_mount_end);
            this.Controls.Add(this.cbm_year_start);
            this.Controls.Add(this.cbm_mount_start);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Abrir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistraPeriodo";
            this.Text = "                         Registra             Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cbm_mount_start;
        private System.Windows.Forms.ComboBox cbm_year_start;
        private System.Windows.Forms.ComboBox cbm_year_end;
        private System.Windows.Forms.ComboBox cbm_mount_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
    }
}