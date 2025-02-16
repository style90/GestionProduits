using GestionProduits.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProduits.Forms
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User(txtName.Text,txtPass.Text,txtName.Text);
            user.EnregistrerUtilisateur();
            MessageBox.Show("Utilisateur enregistré avec succès !!!");
            this.Close();
        }
    }
}
