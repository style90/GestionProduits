using MaterialSkin.Controls;
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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connexionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
        }

        private void listeDesProduitsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }
    }
}
