using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Npgsql;
using GestionProduits.Data;

namespace GestionProduits.Reports
{
    public class ProductReports
    {
        public ProductReports() { }

        public void GenererPDFProduits(string cheminFichier)
        {
            var db = new Database();

            using var conn = db.GetConnection();
            conn.Open();

            string query = "SELECT id, nom, prix FROM produits";
            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            // Création du document PDF
            using FileStream fs = new FileStream(cheminFichier, FileMode.Create);
            using PdfWriter writer = new PdfWriter(fs);
            using PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            document.Add(new Paragraph("Liste des Produits").SetFontSize(18)); //SetBold()

            // Création du tableau
            Table table = new Table(3).UseAllAvailableWidth();
            table.AddHeaderCell("ID");
            table.AddHeaderCell("Nom");
            table.AddHeaderCell("Prix");

            while (reader.Read())
            {
                table.AddCell(reader["id"].ToString());
                table.AddCell(reader["nom"].ToString());
                table.AddCell(reader["prix"].ToString() + " €");
            }

            document.Add(table);
            document.Close();
        }

    }
}
