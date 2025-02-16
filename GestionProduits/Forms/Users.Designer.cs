namespace GestionProduits.Forms
{
    partial class Users
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
            lbName = new System.Windows.Forms.Label();
            lbPass = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(164, 68);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(63, 25);
            lbName.TabIndex = 0;
            lbName.Text = "Email :";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new System.Drawing.Point(174, 124);
            lbPass.Name = "lbPass";
            lbPass.Size = new System.Drawing.Size(134, 25);
            lbPass.TabIndex = 1;
            lbPass.Text = "Mot de passe : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(325, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(336, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(325, 131);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(336, 31);
            txtPass.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(243, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(212, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Sauvegarder";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(174, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 25);
            label1.TabIndex = 5;
            label1.Text = "Nom :";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(325, 28);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(336, 31);
            txtName.TabIndex = 6;
            // 
            // Users
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 299);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(lbPass);
            Controls.Add(lbName);
            Name = "Users";
            Text = "Add user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}