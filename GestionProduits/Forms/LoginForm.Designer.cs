namespace GestionProduits.Forms
{
    partial class LoginForm
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
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassWord = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtMotDePasse = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(275, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(374, 31);
            txtEmail.TabIndex = 0;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new System.Drawing.Point(264, 215);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new System.Drawing.Size(385, 31);
            txtPassWord.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(125, 98);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 25);
            label1.TabIndex = 4;
            label1.Text = "Email :";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.AutoSize = true;
            txtMotDePasse.Location = new System.Drawing.Point(131, 211);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new System.Drawing.Size(129, 25);
            txtMotDePasse.TabIndex = 5;
            txtMotDePasse.Text = "Mot de passe :";
            // 
            // button1
            // 
            button1.CausesValidation = false;
            button1.Location = new System.Drawing.Point(263, 328);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(386, 34);
            button1.TabIndex = 6;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnConnexion_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(713, 373);
            Controls.Add(button1);
            Controls.Add(txtMotDePasse);
            Controls.Add(label1);
            Controls.Add(txtPassWord);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMotDePasse;
        private System.Windows.Forms.Button button1;
    }
}