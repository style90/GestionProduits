using System;
using System.Security.Cryptography;
using System.Text;
using Npgsql;
using GestionProduits.Data;

namespace GestionProduits.Auth
{
    public class User
    {
        private string text1;
        private string text2;

        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public User()
        {
                
        }

        public User(string Name, string Password, string Email)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
        }

        private string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }
        public void EnregistrerUtilisateur()
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();

            // Hacher le mot de passe avant stockage
            string hash = HashPassword(this.Password);

            string query = "INSERT INTO utilisateurs (nom, email, mot_de_passe) VALUES (@nom, @email, @motDePasse)";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nom", this.Name);
            cmd.Parameters.AddWithValue("@email", this.Email);
            cmd.Parameters.AddWithValue("@motDePasse", hash);
            cmd.ExecuteNonQuery();
        }

        public bool AuthentifierUtilisateur(string email, string motDePasse)
        {
            var db = new Database();
            using var conn = db.GetConnection();
            conn.Open();

            string query = "SELECT mot_de_passe FROM utilisateurs WHERE email = @Email";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string motDePasseStocke = reader.GetString(0);
                return motDePasseStocke == HashPassword(motDePasse);
            }
            return false;
        }

    }


}
