namespace GestionProduits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNom = new System.Windows.Forms.TextBox();
            txtPrix = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            btnCharger = new System.Windows.Forms.Button();
            dataGridViewProduits = new System.Windows.Forms.DataGridView();
            btnAjouter = new System.Windows.Forms.Button();
            btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduits).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new System.Drawing.Point(208, 43);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(150, 31);
            txtNom.TabIndex = 0;
            // 
            // txtPrix
            // 
            txtPrix.Location = new System.Drawing.Point(208, 103);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new System.Drawing.Size(150, 31);
            txtPrix.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 25);
            label1.TabIndex = 2;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(87, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 3;
            label2.Text = "Prix :";
            // 
            // btnModifier
            // 
            btnModifier.Location = new System.Drawing.Point(676, 244);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new System.Drawing.Size(112, 34);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += BtnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new System.Drawing.Point(678, 286);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(112, 34);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnCharger
            // 
            btnCharger.Location = new System.Drawing.Point(679, 330);
            btnCharger.Name = "btnCharger";
            btnCharger.Size = new System.Drawing.Size(112, 34);
            btnCharger.TabIndex = 6;
            btnCharger.Text = "Charger";
            btnCharger.UseVisualStyleBackColor = true;
            btnCharger.Click += btnCharger_Click;
            // 
            // dataGridViewProduits
            // 
            dataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduits.Location = new System.Drawing.Point(73, 204);
            dataGridViewProduits.Name = "dataGridViewProduits";
            dataGridViewProduits.RowHeadersWidth = 62;
            dataGridViewProduits.Size = new System.Drawing.Size(597, 225);
            dataGridViewProduits.TabIndex = 7;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new System.Drawing.Point(676, 204);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(112, 34);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new System.Drawing.Point(676, 395);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new System.Drawing.Size(112, 34);
            btnQuitter.TabIndex = 8;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnQuitter);
            Controls.Add(dataGridViewProduits);
            Controls.Add(btnCharger);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrix);
            Controls.Add(txtNom);
            Name = "Form1";
            Text = "Gestion des produits";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnModifier_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.DataGridView dataGridViewProduits;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnQuitter;
    }
}
