using GestionProduits.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionProduits
{
    public partial class Form1 : Form
    {
        private readonly Database _db = new Database();

        public Form1()
        {
            InitializeComponent();
            ChargerProduits();
        }

        private void ChargerProduits()
        {
            dataGridViewProduits.DataSource = _db.GetProduits();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            ChargerProduits();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrix.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }

                decimal prix;
                if (!decimal.TryParse(txtPrix.Text, out prix))
                {
                    MessageBox.Show("Le prix doit être un nombre valide.");
                    return;
                }

                Produit p = new(txtNom.Text, prix);

                p.CreateProduct();

                //_db.AjouterProduit(txtNom.Text, prix);
                ChargerProduits();
                MessageBox.Show("Produit ajouté avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProduits.SelectedRows[0].Cells["id"].Value);
                _db.ModifierProduit(id, txtNom.Text, decimal.Parse(txtPrix.Text));
                ChargerProduits();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProduits.SelectedRows[0].Cells["id"].Value);
                _db.SupprimerProduit(id);
                ChargerProduits();
            }
        }

        private void dataGridViewProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNom.Text = dataGridViewProduits.Rows[e.RowIndex].Cells["nom"].Value.ToString();
                txtPrix.Text = dataGridViewProduits.Rows[e.RowIndex].Cells["prix"].Value.ToString();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
