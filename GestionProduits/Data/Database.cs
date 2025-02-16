using System;
using System.Data;
using Npgsql;

namespace GestionProduits.Data
{
    public class Database
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Username=odoo10;Password=admin;Database=gestion_produits";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

       
    }
}
