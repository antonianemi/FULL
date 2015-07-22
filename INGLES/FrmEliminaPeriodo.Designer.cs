namespace Ingles
{
    partial class FrmEliminaPeriodo
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
            this.dtg_periodos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_periodo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_periodos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_periodos
            // 
            this.dtg_periodos.AllowUserToAddRows = false;
            this.dtg_periodos.AllowUserToDeleteRows = false;
            this.dtg_periodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_periodos.Location = new System.Drawing.Point(24, 23);
            this.dtg_periodos.Name = "dtg_periodos";
            this.dtg_periodos.ReadOnly = true;
            this.dtg_periodos.RowTemplate.Height = 24;
            this.dtg_periodos.Size = new System.Drawing.Size(774, 162);
            this.dtg_periodos.TabIndex = 0;
            this.dtg_periodos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_periodos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_periodo);
            this.groupBox1.Location = new System.Drawing.Point(24, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 140);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del periodo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "PERIODO";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(123, 82);
            this.lbl_Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(0, 22);
            this.lbl_Descripcion.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "DESCRIPCION";
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
            // FrmEliminaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_periodos);
            this.Name = "FrmEliminaPeriodo";
            this.Text = "Baja     Periodo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtg_periodos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_periodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_periodo;
    }
}