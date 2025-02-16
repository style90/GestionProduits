namespace GestionProduits.Forms
{
    partial class MainForm
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connexionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { connexionToolStripMenuItem, produitsToolStripMenuItem, gestionDesUtilisateursToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(794, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            
            // 
            // connexionToolStripMenuItem
            // 
            connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { connexionToolStripMenuItem1, quitterToolStripMenuItem });
            connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            connexionToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            connexionToolStripMenuItem.Text = "Connexion";
            // 
            // connexionToolStripMenuItem1
            // 
            connexionToolStripMenuItem1.Name = "connexionToolStripMenuItem1";
            connexionToolStripMenuItem1.Size = new System.Drawing.Size(198, 34);
            connexionToolStripMenuItem1.Text = "Connexion";
            connexionToolStripMenuItem1.Click += connexionToolStripMenuItem1_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // produitsToolStripMenuItem
            // 
            produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { listeDesProduitsToolStripMenuItem });
            produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            produitsToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            produitsToolStripMenuItem.Text = "Produits";
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            listeDesProduitsToolStripMenuItem.Text = "Liste des produits";
            listeDesProduitsToolStripMenuItem.Click += listeDesProduitsToolStripMenuItem_Click_1;
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            gestionDesUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ajouterToolStripMenuItem });
            gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(210, 29);
            gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Gestion des produits";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
    }
}