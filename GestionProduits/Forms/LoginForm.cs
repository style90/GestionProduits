using GestionProduits.Auth;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GestionProduits.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnConnexion;
        }
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string motDePasse = txtPassWord.Text;
            var user = new User();

            if (user.AuthentifierUtilisateur(email, motDePasse))
            {
                MessageBox.Show("Connexion réussie !");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
