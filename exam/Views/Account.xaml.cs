using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace exam.Views
{
    /// <summary>
    /// Logique d'interaction pour Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=quizzt;Integrated Security=True");

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text != "" && Password.Text != "")
            {
                string query = "select count(*) from Registration where email = '" + Username.Text + "' and " + "password=' " + Password.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or password", "Error!");
                }
                else
                {
                    MessageBox.Show("Welcome to ur profile!");
                    Username.Text = "";
                    Password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill in the blinks");
            }
        }

       


    }
}
