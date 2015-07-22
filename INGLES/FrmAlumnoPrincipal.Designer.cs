namespace Ingles
{
    partial class FrmAlumnoPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rdb_Alumno_Registrar = new System.Windows.Forms.RadioButton();
            this.rdb_Alumno_Actualizar = new System.Windows.Forms.RadioButton();
            this.rdb_Alumno_Baja = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(28, 107);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(141, 27);
            this.btn_siguiente.TabIndex = 0;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(200, 107);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 27);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rdb_Alumno_Registrar
            // 
            this.rdb_Alumno_Registrar.AutoSize = true;
            this.rdb_Alumno_Registrar.Location = new System.Drawing.Point(102, 11);
            this.rdb_Alumno_Registrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Alumno_Registrar.Name = "rdb_Alumno_Registrar";
            this.rdb_Alumno_Registrar.Size = new System.Drawing.Size(166, 23);
            this.rdb_Alumno_Registrar.TabIndex = 2;
            this.rdb_Alumno_Registrar.TabStop = true;
            this.rdb_Alumno_Registrar.Text = "Registrar Alumno";
            this.rdb_Alumno_Registrar.UseVisualStyleBackColor = true;
            // 
            // rdb_Alumno_Actualizar
            // 
            this.rdb_Alumno_Actualizar.AutoSize = true;
            this.rdb_Alumno_Actualizar.Location = new System.Drawing.Point(102, 43);
            this.rdb_Alumno_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Alumno_Actualizar.Name = "rdb_Alumno_Actualizar";
            this.rdb_Alumno_Actualizar.Size = new System.Drawing.Size(171, 23);
            this.rdb_Alumno_Actualizar.TabIndex = 3;
            this.rdb_Alumno_Actualizar.TabStop = true;
            this.rdb_Alumno_Actualizar.Text = "Actualizar Alumno";
            this.rdb_Alumno_Actualizar.UseVisualStyleBackColor = true;
            // 
            // rdb_Alumno_Baja
            // 
            this.rdb_Alumno_Baja.AutoSize = true;
            this.rdb_Alumno_Baja.Location = new System.Drawing.Point(102, 75);
            this.rdb_Alumno_Baja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_Alumno_Baja.Name = "rdb_Alumno_Baja";
            this.rdb_Alumno_Baja.Size = new System.Drawing.Size(127, 23);
            this.rdb_Alumno_Baja.TabIndex = 4;
            this.rdb_Alumno_Baja.TabStop = true;
            this.rdb_Alumno_Baja.Text = "Baja Alumno";
            this.rdb_Alumno_Baja.UseVisualStyleBackColor = true;
            // 
            // FrmAlumnoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 151);
            this.Controls.Add(this.rdb_Alumno_Baja);
            this.Controls.Add(this.rdb_Alumno_Actualizar);
            this.Controls.Add(this.rdb_Alumno_Registrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_siguiente);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAlumnoPrincipal";
            this.Text = "                      ALUMNOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton rdb_Alumno_Registrar;
        private System.Windows.Forms.RadioButton rdb_Alumno_Actualizar;
        private System.Windows.Forms.RadioButton rdb_Alumno_Baja;
    }
}

