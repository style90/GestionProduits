using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduits.Model
{
    public class Produit
    {
        [Key]
        int id;

        public Produit(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        [Required]  
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }

        public void CreateProduct(string nom, decimal prix)
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();
            string query = "INSERT INTO produits (nom, prix) VALUES (@nom, @prix)";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.ExecuteNonQuery();
        }

    }
}
