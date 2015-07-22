namespace Ingles
{
    partial class FrmPeriodoPrincipal
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
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rdb_Periodo_Registrar = new System.Windows.Forms.RadioButton();
            this.rdb_Periodo_Actualizar = new System.Windows.Forms.RadioButton();
            this.rdb_Periodo_Baja = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(22, 93);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(104, 23);
            this.btn_siguiente.TabIndex = 0;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(153, 93);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(96, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rdb_Periodo_Registrar
            // 
            this.rdb_Periodo_Registrar.AutoSize = true;
            this.rdb_Periodo_Registrar.Location = new System.Drawing.Point(82, 12);
            this.rdb_Periodo_Registrar.Name = "rdb_Periodo_Registrar";
            this.rdb_Periodo_Registrar.Size = new System.Drawing.Size(123, 21);
            this.rdb_Periodo_Registrar.TabIndex = 2;
            this.rdb_Periodo_Registrar.TabStop = true;
            this.rdb_Periodo_Registrar.Text = "Nuevo Periodo";
            this.rdb_Periodo_Registrar.UseVisualStyleBackColor = true;
            //this.rdb_Periodo_Registrar.CheckedChanged += new System.EventHandler(this.rdb_Periodo_Registrar_CheckedChanged);
            // 
            // rdb_Periodo_Actualizar
            // 
            this.rdb_Periodo_Actualizar.AutoSize = true;
            this.rdb_Periodo_Actualizar.Location = new System.Drawing.Point(82, 39);
            this.rdb_Periodo_Actualizar.Name = "rdb_Periodo_Actualizar";
            this.rdb_Periodo_Actualizar.Size = new System.Drawing.Size(144, 21);
            this.rdb_Periodo_Actualizar.TabIndex = 3;
            this.rdb_Periodo_Actualizar.TabStop = true;
            this.rdb_Periodo_Actualizar.Text = "Actualizar Periodo";
            this.rdb_Periodo_Actualizar.UseVisualStyleBackColor = true;
            // 
            // rdb_Periodo_Baja
            // 
            this.rdb_Periodo_Baja.AutoSize = true;
            this.rdb_Periodo_Baja.Location = new System.Drawing.Point(82, 66);
            this.rdb_Periodo_Baja.Name = "rdb_Periodo_Baja";
            this.rdb_Periodo_Baja.Size = new System.Drawing.Size(132, 21);
            this.rdb_Periodo_Baja.TabIndex = 4;
            this.rdb_Periodo_Baja.TabStop = true;
            this.rdb_Periodo_Baja.Text = "Eliminar Periodo";
            this.rdb_Periodo_Baja.UseVisualStyleBackColor = true;
            // 
            // FrmPeriodoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 129);
            this.Controls.Add(this.rdb_Periodo_Baja);
            this.Controls.Add(this.rdb_Periodo_Actualizar);
            this.Controls.Add(this.rdb_Periodo_Registrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_siguiente);
            this.Name = "FrmPeriodoPrincipal";
            this.Text = "FrmPeriodoPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton rdb_Periodo_Registrar;
        private System.Windows.Forms.RadioButton rdb_Periodo_Actualizar;
        private System.Windows.Forms.RadioButton rdb_Periodo_Baja;
    }
}