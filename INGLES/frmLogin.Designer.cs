namespace Ingles
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_NameUser = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_MensajeLogin = new System.Windows.Forms.Label();
            this.ErrP_Login = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrP_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(231, 77);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 29);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(4, 22);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(68, 13);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "USERNAME";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(4, 52);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "PASSWORD";
            // 
            // txt_NameUser
            // 
            this.txt_NameUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameUser.Location = new System.Drawing.Point(78, 12);
            this.txt_NameUser.Name = "txt_NameUser";
            this.txt_NameUser.Size = new System.Drawing.Size(227, 29);
            this.txt_NameUser.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(78, 42);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(228, 29);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_MensajeLogin
            // 
            this.lbl_MensajeLogin.AutoSize = true;
            this.lbl_MensajeLogin.Location = new System.Drawing.Point(45, 69);
            this.lbl_MensajeLogin.Name = "lbl_MensajeLogin";
            this.lbl_MensajeLogin.Size = new System.Drawing.Size(0, 13);
            this.lbl_MensajeLogin.TabIndex = 5;
            // 
            // ErrP_Login
            // 
            this.ErrP_Login.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(335, 126);
            this.Controls.Add(this.lbl_MensajeLogin);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_NameUser);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ErrP_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_NameUser;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_MensajeLogin;
        private System.Windows.Forms.ErrorProvider ErrP_Login;
    }
}