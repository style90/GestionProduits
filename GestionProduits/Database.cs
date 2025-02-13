using System;
using System.Data;
using Npgsql;

namespace GestionProduits
{
    public class Database
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Username=odoo10;Password=admin;Database=gestion_produits";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public DataTable GetProduits()
        {
            using var conn = GetConnection();
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
            using var conn = GetConnection();
            conn.Open();
            string query = "INSERT INTO produits (nom, prix) VALUES (@nom, @prix)";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.ExecuteNonQuery();
        }

        public void ModifierProduit(int id, string nom, decimal prix)
        {
            using var conn = GetConnection();
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
            using var conn = GetConnection();
            conn.Open();
            string query = "DELETE FROM produits WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
