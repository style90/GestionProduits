using GestionProduits.Data;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduits.Model
{
    public class Produit
    {
       
        public Produit(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Produit()
        {
        }

        [Required]  
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }

        public void CreateProduct()
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();
            string query = "INSERT INTO produits (nom, prix) VALUES (@nom, @prix)";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", this.Name);
            cmd.Parameters.AddWithValue("@prix", this.Price);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetProduits()
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();
            string query = "SELECT * FROM produits";
            using var cmd = new NpgsqlCommand(query, conn);
            using var adapter = new NpgsqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void AjouterProduit(string nom, decimal prix)
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

        public void ModifierProduit(int id, string nom, decimal prix)
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();
            string query = "UPDATE produits SET nom=@nom, prix=@prix WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.ExecuteNonQuery();
        }

        public void SupprimerProduit(int id)
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();
            string query = "DELETE FROM produits WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

    }
}
