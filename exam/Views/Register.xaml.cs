


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace exam.Views
{

    /// <summary>
    /// Logique d'interaction pour Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register() => InitializeComponent();

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=quizzt;Integrated Security=True");

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtAddres.Text != "" && cmbCountry.Text != "" && txtEmail.Text != "")
                {
                    if (txtPassword.Text == txtConpassword.Text)
                    {
                        int v = check(txtEmail.Text);
                        if (v != 1)
                        {


                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into RegistrationTbl values(@txtName, @txtUsername" + "@txtEmail, @txtAddres, @txtPassword, @cmbCountry", connection);
                            command.Parameters.AddWithValue("@txtname", txtName.Text);
                            command.Parameters.AddWithValue("@txtUsername", txtUsername.Text);
                            command.Parameters.AddWithValue("@txtAddres", txtAddres.Text);
                            command.Parameters.AddWithValue("@txtEmail", txtEmail.Text);
                            command.Parameters.AddWithValue("@cmbCountry", cmbCountry.Text);
                            command.Parameters.AddWithValue("@txtPassword", txtPassword.Text);
                            command.Parameters.AddWithValue("@txtConpassword", txtConpassword.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Register Succesfully!");

                            txtName.Text = "";
                            txtUsername.Text = "";

                            txtEmail.Text = "";
                            txtAddres.Text = "";
                            cmbCountry.Text = "";
                            txtPassword.Text = "";
                            txtConpassword.Text = "";
                            MessageBox.Show("You are already registered!");

                        }
                        else
                        {
                            MessageBox.Show("You are already registered!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does  not match!");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blinks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private int check(string text)
        {
            throw new NotImplementedException();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

