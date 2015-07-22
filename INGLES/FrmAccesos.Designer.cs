namespace Ingles
{
    partial class FrmAccesos
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo8");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nodo7", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nodo5", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nodo6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nodo4", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.lbt_usuarios = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbt_usuarios
            // 
            this.lbt_usuarios.FormattingEnabled = true;
            this.lbt_usuarios.ItemHeight = 16;
            this.lbt_usuarios.Location = new System.Drawing.Point(13, 56);
            this.lbt_usuarios.Name = "lbt_usuarios";
            this.lbt_usuarios.Size = new System.Drawing.Size(187, 324);
            this.lbt_usuarios.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(222, 56);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Nodo2";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Nodo1";
            treeNode3.Name = "Principal";
            treeNode3.Text = "Principal";
            treeNode4.Name = "Nodo3";
            treeNode4.Text = "Nodo3";
            treeNode5.Name = "Nodo8";
            treeNode5.Text = "Nodo8";
            treeNode6.Name = "Nodo7";
            treeNode6.Text = "Nodo7";
            treeNode7.Name = "Nodo5";
            treeNode7.Text = "Nodo5";
            treeNode8.Name = "Nodo6";
            treeNode8.Text = "Nodo6";
            treeNode9.Name = "Nodo4";
            treeNode9.Text = "Nodo4";
            
            
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode3,treeNode4,treeNode9});




            this.treeView1.Size = new System.Drawing.Size(443, 319);
            this.treeView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ACCESOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lbt_usuarios);
            this.Name = "FrmAccesos";
            this.Text = "                                        Accesos";
            this.ResumeLayout(false);
           // this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbt_usuarios;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}