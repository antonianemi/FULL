namespace Ingles
{
    partial class FrmActualizaPeriodo
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
            this.dtg_PERIODOS = new System.Windows.Forms.DataGridView();
            this.btn_ACTUALIZAR = new System.Windows.Forms.Button();
            this.btn_CANCELAR = new System.Windows.Forms.Button();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbm_year_end = new System.Windows.Forms.ComboBox();
            this.cbm_mount_end = new System.Windows.Forms.ComboBox();
            this.cbm_year_start = new System.Windows.Forms.ComboBox();
            this.cbm_mount_start = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_periodo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.noPeriodos = new System.Windows.Forms.ToolStripStatusLabel();
            this.grb_DatosNuevos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PERIODOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grb_DatosNuevos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_PERIODOS
            // 
            this.dtg_PERIODOS.AllowUserToAddRows = false;
            this.dtg_PERIODOS.AllowUserToDeleteRows = false;
            this.dtg_PERIODOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PERIODOS.Location = new System.Drawing.Point(11, 26);
            this.dtg_PERIODOS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtg_PERIODOS.Name = "dtg_PERIODOS";
            this.dtg_PERIODOS.ReadOnly = true;
            this.dtg_PERIODOS.RowTemplate.Height = 24;
            this.dtg_PERIODOS.Size = new System.Drawing.Size(922, 357);
            this.dtg_PERIODOS.TabIndex = 0;
            this.dtg_PERIODOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_PERIODOS_CellDoubleClick);
            // 
            // btn_ACTUALIZAR
            // 
            this.btn_ACTUALIZAR.Location = new System.Drawing.Point(937, 26);
            this.btn_ACTUALIZAR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ACTUALIZAR.Name = "btn_ACTUALIZAR";
            this.btn_ACTUALIZAR.Size = new System.Drawing.Size(114, 24);
            this.btn_ACTUALIZAR.TabIndex = 1;
            this.btn_ACTUALIZAR.Text = "ACTUALIZAR";
            this.btn_ACTUALIZAR.UseVisualStyleBackColor = true;
            this.btn_ACTUALIZAR.Click += new System.EventHandler(this.btn_ACTUALIZAR_Click);
            // 
            // btn_CANCELAR
            // 
            this.btn_CANCELAR.Location = new System.Drawing.Point(937, 75);
            this.btn_CANCELAR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_CANCELAR.Name = "btn_CANCELAR";
            this.btn_CANCELAR.Size = new System.Drawing.Size(114, 24);
            this.btn_CANCELAR.TabIndex = 2;
            this.btn_CANCELAR.Text = "CANCELAR";
            this.btn_CANCELAR.UseVisualStyleBackColor = true;
            this.btn_CANCELAR.Click += new System.EventHandler(this.btn_CANCELAR_Click);
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Descripcion.Location = new System.Drawing.Point(448, 21);
            this.rtb_Descripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(308, 96);
            this.rtb_Descripcion.TabIndex = 25;
            this.rtb_Descripcion.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "AÑO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "MES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "FIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "AÑO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "MES";
            // 
            // cbm_year_end
            // 
            this.cbm_year_end.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_year_end.FormattingEnabled = true;
            this.cbm_year_end.Location = new System.Drawing.Point(352, 70);
            this.cbm_year_end.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_year_end.Name = "cbm_year_end";
            this.cbm_year_end.Size = new System.Drawing.Size(72, 29);
            this.cbm_year_end.TabIndex = 17;
            // 
            // cbm_mount_end
            // 
            this.cbm_mount_end.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_mount_end.FormattingEnabled = true;
            this.cbm_mount_end.Location = new System.Drawing.Point(242, 70);
            this.cbm_mount_end.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_mount_end.Name = "cbm_mount_end";
            this.cbm_mount_end.Size = new System.Drawing.Size(107, 29);
            this.cbm_mount_end.TabIndex = 16;
            // 
            // cbm_year_start
            // 
            this.cbm_year_start.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_year_start.FormattingEnabled = true;
            this.cbm_year_start.Location = new System.Drawing.Point(112, 70);
            this.cbm_year_start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_year_start.Name = "cbm_year_start";
            this.cbm_year_start.Size = new System.Drawing.Size(72, 29);
            this.cbm_year_start.TabIndex = 15;
            // 
            // cbm_mount_start
            // 
            this.cbm_mount_start.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_mount_start.FormattingEnabled = true;
            this.cbm_mount_start.Location = new System.Drawing.Point(1, 70);
            this.cbm_mount_start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_mount_start.Name = "cbm_mount_start";
            this.cbm_mount_start.Size = new System.Drawing.Size(107, 29);
            this.cbm_mount_start.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(595, -18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "DESCRIPCION";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(123, 71);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(0, 22);
            this.lbl_Descripcion.TabIndex = 34;
            // 
            // lbl_periodo
            // 
            this.lbl_periodo.AutoSize = true;
            this.lbl_periodo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_periodo.Location = new System.Drawing.Point(123, 29);
            this.lbl_periodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_periodo.Name = "lbl_periodo";
            this.lbl_periodo.Size = new System.Drawing.Size(0, 22);
            this.lbl_periodo.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "DESCRIPCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "PERIODO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_periodo);
            this.groupBox1.Location = new System.Drawing.Point(13, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 94);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del periodo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noPeriodos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1315, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // noPeriodos
            // 
            this.noPeriodos.Name = "noPeriodos";
            this.noPeriodos.Size = new System.Drawing.Size(0, 17);
            // 
            // grb_DatosNuevos
            // 
            this.grb_DatosNuevos.Controls.Add(this.rtb_Descripcion);
            this.grb_DatosNuevos.Controls.Add(this.cbm_mount_start);
            this.grb_DatosNuevos.Controls.Add(this.cbm_year_start);
            this.grb_DatosNuevos.Controls.Add(this.label7);
            this.grb_DatosNuevos.Controls.Add(this.label10);
            this.grb_DatosNuevos.Controls.Add(this.cbm_mount_end);
            this.grb_DatosNuevos.Controls.Add(this.cbm_year_end);
            this.grb_DatosNuevos.Controls.Add(this.label1);
            this.grb_DatosNuevos.Controls.Add(this.label5);
            this.grb_DatosNuevos.Controls.Add(this.label2);
            this.grb_DatosNuevos.Controls.Add(this.label6);
            this.grb_DatosNuevos.Controls.Add(this.label3);
            this.grb_DatosNuevos.Controls.Add(this.label4);
            this.grb_DatosNuevos.Location = new System.Drawing.Point(12, 489);
            this.grb_DatosNuevos.Name = "grb_DatosNuevos";
            this.grb_DatosNuevos.Size = new System.Drawing.Size(922, 153);
            this.grb_DatosNuevos.TabIndex = 37;
            this.grb_DatosNuevos.TabStop = false;
            this.grb_DatosNuevos.Text = "Datos Nuevos";
            // 
            // FrmActualizaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 667);
            this.Controls.Add(this.grb_DatosNuevos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CANCELAR);
            this.Controls.Add(this.btn_ACTUALIZAR);
            this.Controls.Add(this.dtg_PERIODOS);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FrmActualizaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar     Periodo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PERIODOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grb_DatosNuevos.ResumeLayout(false);
            this.grb_DatosNuevos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_PERIODOS;
        private System.Windows.Forms.Button btn_ACTUALIZAR;
        private System.Windows.Forms.Button btn_CANCELAR;
        private System.Windows.Forms.RichTextBox rtb_Descripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbm_year_end;
        private System.Windows.Forms.ComboBox cbm_mount_end;
        private System.Windows.Forms.ComboBox cbm_year_start;
        private System.Windows.Forms.ComboBox cbm_mount_start;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_periodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel noPeriodos;
        private System.Windows.Forms.GroupBox grb_DatosNuevos;
    }
}