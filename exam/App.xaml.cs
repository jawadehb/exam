using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace exam
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Define your MySQL connection string
            string connectionString = "Server=localhost;Port=3306;Database=quizzt;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Database connection is open; you can perform database operations here

                connection.Close();
            }
            catch (MySqlException ex)
            {
                // Handle any connection or database-related exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
