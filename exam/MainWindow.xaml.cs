using exam.Views;
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

namespace exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Home();
        }

        private void BtnAccount_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Account();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Play(); 
        }

        private void BtnLeaderboard_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Leaderboard();
        }

        private void BtnFriends_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Friends();
        }
    }
}
