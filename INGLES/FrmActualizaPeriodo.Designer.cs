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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.noPeriodos = new System.Windows.Forms.ToolStripStatusLabel();
            this.grb_DatosNuevos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PERIODOS)).BeginInit();
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
            this.dtg_PERIODOS.Size = new System.Drawing.Size(629, 198);
            this.dtg_PERIODOS.TabIndex = 0;
            this.dtg_PERIODOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SELECCIONAPERIODO);
            // 
            // btn_ACTUALIZAR
            // 
            this.btn_ACTUALIZAR.Location = new System.Drawing.Point(405, 528);
            this.btn_ACTUALIZAR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ACTUALIZAR.Name = "btn_ACTUALIZAR";
            this.btn_ACTUALIZAR.Size = new System.Drawing.Size(114, 24);
            this.btn_ACTUALIZAR.TabIndex = 1;
            this.btn_ACTUALIZAR.Text = "ACTUALIZAR";
            this.btn_ACTUALIZAR.UseVisualStyleBackColor = true;
            this.btn_ACTUALIZAR.Click += new System.EventHandler(this.ACTUALIZAR);
            // 
            // btn_CANCELAR
            // 
            this.btn_CANCELAR.Location = new System.Drawing.Point(526, 528);
            this.btn_CANCELAR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_CANCELAR.Name = "btn_CANCELAR";
            this.btn_CANCELAR.Size = new System.Drawing.Size(114, 24);
            this.btn_CANCELAR.TabIndex = 2;
            this.btn_CANCELAR.Text = "CANCELAR";
            this.btn_CANCELAR.UseVisualStyleBackColor = true;
            this.btn_CANCELAR.Click += new System.EventHandler(this.CANCELAR);
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Descripcion.Location = new System.Drawing.Point(218, 71);
            this.rtb_Descripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(396, 199);
            this.rtb_Descripcion.TabIndex = 25;
            this.rtb_Descripcion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "AÑO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "MES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "FECHA FIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "FECHA INICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "AÑO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "MES";
            // 
            // cbm_year_end
            // 
            this.cbm_year_end.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_year_end.FormattingEnabled = true;
            this.cbm_year_end.Location = new System.Drawing.Point(59, 170);
            this.cbm_year_end.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_year_end.Name = "cbm_year_end";
            this.cbm_year_end.Size = new System.Drawing.Size(72, 24);
            this.cbm_year_end.TabIndex = 17;
            // 
            // cbm_mount_end
            // 
            this.cbm_mount_end.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_mount_end.FormattingEnabled = true;
            this.cbm_mount_end.Location = new System.Drawing.Point(59, 209);
            this.cbm_mount_end.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_mount_end.Name = "cbm_mount_end";
            this.cbm_mount_end.Size = new System.Drawing.Size(107, 24);
            this.cbm_mount_end.TabIndex = 16;
            // 
            // cbm_year_start
            // 
            this.cbm_year_start.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_year_start.FormattingEnabled = true;
            this.cbm_year_start.Location = new System.Drawing.Point(58, 55);
            this.cbm_year_start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_year_start.Name = "cbm_year_start";
            this.cbm_year_start.Size = new System.Drawing.Size(72, 24);
            this.cbm_year_start.TabIndex = 15;
            // 
            // cbm_mount_start
            // 
            this.cbm_mount_start.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_mount_start.FormattingEnabled = true;
            this.cbm_mount_start.Location = new System.Drawing.Point(58, 94);
            this.cbm_mount_start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbm_mount_start.Name = "cbm_mount_start";
            this.cbm_mount_start.Size = new System.Drawing.Size(107, 24);
            this.cbm_mount_start.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(595, -18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "DESCRIPCION";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noPeriodos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
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
            this.grb_DatosNuevos.Controls.Add(this.label7);
            this.grb_DatosNuevos.Controls.Add(this.rtb_Descripcion);
            this.grb_DatosNuevos.Controls.Add(this.cbm_mount_start);
            this.grb_DatosNuevos.Controls.Add(this.cbm_year_start);
            this.grb_DatosNuevos.Controls.Add(this.label10);
            this.grb_DatosNuevos.Controls.Add(this.cbm_mount_end);
            this.grb_DatosNuevos.Controls.Add(this.cbm_year_end);
            this.grb_DatosNuevos.Controls.Add(this.label1);
            this.grb_DatosNuevos.Controls.Add(this.label5);
            this.grb_DatosNuevos.Controls.Add(this.label2);
            this.grb_DatosNuevos.Controls.Add(this.label6);
            this.grb_DatosNuevos.Controls.Add(this.label3);
            this.grb_DatosNuevos.Controls.Add(this.label4);
            this.grb_DatosNuevos.Location = new System.Drawing.Point(11, 230);
            this.grb_DatosNuevos.Name = "grb_DatosNuevos";
            this.grb_DatosNuevos.Size = new System.Drawing.Size(629, 276);
            this.grb_DatosNuevos.TabIndex = 37;
            this.grb_DatosNuevos.TabStop = false;
            this.grb_DatosNuevos.Text = "Datos Nuevos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "DESCRIPCION DEL PERIODO";
            // 
            // FrmActualizaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 577);
            this.Controls.Add(this.grb_DatosNuevos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_CANCELAR);
            this.Controls.Add(this.btn_ACTUALIZAR);
            this.Controls.Add(this.dtg_PERIODOS);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FrmActualizaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar     Periodo";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PERIODOS)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel noPeriodos;
        private System.Windows.Forms.GroupBox grb_DatosNuevos;
        private System.Windows.Forms.Label label7;
    }
}