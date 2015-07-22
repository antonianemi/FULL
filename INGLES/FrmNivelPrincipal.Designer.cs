namespace Ingles
{
    partial class FrmNivelPrincipal
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
            this.rdb_Nivel_Baja = new System.Windows.Forms.RadioButton();
            this.rdb_Nivel_Actualizar = new System.Windows.Forms.RadioButton();
            this.rdb_Nivel_Registrar = new System.Windows.Forms.RadioButton();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Nivel_Baja
            // 
            this.rdb_Nivel_Baja.AutoSize = true;
            this.rdb_Nivel_Baja.Location = new System.Drawing.Point(74, 94);
            this.rdb_Nivel_Baja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Nivel_Baja.Name = "rdb_Nivel_Baja";
            this.rdb_Nivel_Baja.Size = new System.Drawing.Size(113, 26);
            this.rdb_Nivel_Baja.TabIndex = 9;
            this.rdb_Nivel_Baja.TabStop = true;
            this.rdb_Nivel_Baja.Text = "Cerrar Nivel";
            this.rdb_Nivel_Baja.UseVisualStyleBackColor = true;
            // 
            // rdb_Nivel_Actualizar
            // 
            this.rdb_Nivel_Actualizar.AutoSize = true;
            this.rdb_Nivel_Actualizar.Location = new System.Drawing.Point(74, 57);
            this.rdb_Nivel_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Nivel_Actualizar.Name = "rdb_Nivel_Actualizar";
            this.rdb_Nivel_Actualizar.Size = new System.Drawing.Size(138, 26);
            this.rdb_Nivel_Actualizar.TabIndex = 8;
            this.rdb_Nivel_Actualizar.TabStop = true;
            this.rdb_Nivel_Actualizar.Text = "Actualizar Nivel";
            this.rdb_Nivel_Actualizar.UseVisualStyleBackColor = true;
            // 
            // rdb_Nivel_Registrar
            // 
            this.rdb_Nivel_Registrar.AutoSize = true;
            this.rdb_Nivel_Registrar.Location = new System.Drawing.Point(74, 19);
            this.rdb_Nivel_Registrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Nivel_Registrar.Name = "rdb_Nivel_Registrar";
            this.rdb_Nivel_Registrar.Size = new System.Drawing.Size(113, 26);
            this.rdb_Nivel_Registrar.TabIndex = 7;
            this.rdb_Nivel_Registrar.TabStop = true;
            this.rdb_Nivel_Registrar.Text = "Nuevo Nivel";
            this.rdb_Nivel_Registrar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(180, 130);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(116, 31);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(29, 130);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(127, 31);
            this.btn_siguiente.TabIndex = 5;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // FrmNivelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 170);
            this.Controls.Add(this.rdb_Nivel_Baja);
            this.Controls.Add(this.rdb_Nivel_Actualizar);
            this.Controls.Add(this.rdb_Nivel_Registrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_siguiente);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNivelPrincipal";
            this.Text = "        NIVEL PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Nivel_Baja;
        private System.Windows.Forms.RadioButton rdb_Nivel_Actualizar;
        private System.Windows.Forms.RadioButton rdb_Nivel_Registrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_siguiente;
    }
}