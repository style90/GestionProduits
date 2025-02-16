using GestionProduits.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using GestionProduits.Reports;
using GestionProduits.Data;

namespace GestionProduits
{
    public partial class Products : MaterialForm
    {
        private readonly Database _db = new Database();

        public Products()
        {
            InitializeComponent();
            // Appliquer Material Design
            var _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            ChargerProduits();
        }

        private void ChargerProduits()
        {
            Produit product = new();
            dataGridViewProduits.DataSource = product.GetProduits();
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


        private void btnModifier_Click2(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
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

                    //Produit p = new(txtNom.Text, prix);

                    Produit product = new();
                    int id = Convert.ToInt32(dataGridViewProduits.SelectedRows[0].Cells["id"].Value);
                    product.ModifierProduit(id, txtNom.Text, decimal.Parse(txtPrix.Text));


                    ChargerProduits();
                    MessageBox.Show("Produit modifié avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                Produit product = new();
                int id = Convert.ToInt32(dataGridViewProduits.SelectedRows[0].Cells["id"].Value);
                product.SupprimerProduit(id);
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
            dataGridViewProduits.BackgroundColor = System.Drawing.Color.White;
            dataGridViewProduits.BorderStyle = BorderStyle.None;
            dataGridViewProduits.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10);
            dataGridViewProduits.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridViewProduits.DefaultCellStyle.BackColor = System.Drawing.Color.White;
        }

        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            var report = new ProductReports();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Enregistrer le fichier PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                report.GenererPDFProduits(saveFileDialog.FileName);
                MessageBox.Show("PDF généré avec succès !");
            }
        }

        private void dataGridViewProduits_SelectionChanged(object sender, EventArgs e)
        {
            // Vérifier s'il y a au moins une ligne sélectionnée
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow row = dataGridViewProduits.SelectedRows[0];

                // Assigner les valeurs des cellules aux champs texte
                
                txtNom.Text = row.Cells["Nom"].Value?.ToString();
                txtPrix.Text = row.Cells["Prix"].Value?.ToString();
            }
        }
    }
}
