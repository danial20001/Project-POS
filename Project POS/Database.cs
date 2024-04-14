using MySql.Data.MySqlClient;
using System;

namespace Project_POS
{
    internal class Database
    {
        private const string ConnectionString = "server=127.0.0.1;port=3307;database=u2280965;user=u2280965;password=DS02jul01ds;";

        public static MySqlConnection Connect()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connection established.");
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                return null;
            }
        }
    }
}
