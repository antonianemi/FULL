namespace Ingles
{
    partial class FrmDocentePrincipal
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
            this.rdb_Docente_Registrar = new System.Windows.Forms.RadioButton();
            this.rdb_Docente_Actualizar = new System.Windows.Forms.RadioButton();
            this.rdb_Docente_Baja = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(26, 134);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(116, 31);
            this.btn_siguiente.TabIndex = 0;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(188, 134);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 31);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rdb_Docente_Registrar
            // 
            this.rdb_Docente_Registrar.AutoSize = true;
            this.rdb_Docente_Registrar.Location = new System.Drawing.Point(92, 15);
            this.rdb_Docente_Registrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Docente_Registrar.Name = "rdb_Docente_Registrar";
            this.rdb_Docente_Registrar.Size = new System.Drawing.Size(156, 26);
            this.rdb_Docente_Registrar.TabIndex = 2;
            this.rdb_Docente_Registrar.TabStop = true;
            this.rdb_Docente_Registrar.Text = "Registrar Docente";
            this.rdb_Docente_Registrar.UseVisualStyleBackColor = true;
            // 
            // rdb_Docente_Actualizar
            // 
            this.rdb_Docente_Actualizar.AutoSize = true;
            this.rdb_Docente_Actualizar.Location = new System.Drawing.Point(92, 52);
            this.rdb_Docente_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Docente_Actualizar.Name = "rdb_Docente_Actualizar";
            this.rdb_Docente_Actualizar.Size = new System.Drawing.Size(161, 26);
            this.rdb_Docente_Actualizar.TabIndex = 3;
            this.rdb_Docente_Actualizar.TabStop = true;
            this.rdb_Docente_Actualizar.Text = "Actualizar Docente";
            this.rdb_Docente_Actualizar.UseVisualStyleBackColor = true;
            // 
            // rdb_Docente_Baja
            // 
            this.rdb_Docente_Baja.AutoSize = true;
            this.rdb_Docente_Baja.Location = new System.Drawing.Point(92, 90);
            this.rdb_Docente_Baja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Docente_Baja.Name = "rdb_Docente_Baja";
            this.rdb_Docente_Baja.Size = new System.Drawing.Size(122, 26);
            this.rdb_Docente_Baja.TabIndex = 4;
            this.rdb_Docente_Baja.TabStop = true;
            this.rdb_Docente_Baja.Text = "Baja Docente";
            this.rdb_Docente_Baja.UseVisualStyleBackColor = true;
            // 
            // FrmDocentePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 178);
            this.Controls.Add(this.rdb_Docente_Baja);
            this.Controls.Add(this.rdb_Docente_Actualizar);
            this.Controls.Add(this.rdb_Docente_Registrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_siguiente);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDocentePrincipal";
            this.Text = "             DOCENTE PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton rdb_Docente_Registrar;
        private System.Windows.Forms.RadioButton rdb_Docente_Actualizar;
        private System.Windows.Forms.RadioButton rdb_Docente_Baja;
    }
}