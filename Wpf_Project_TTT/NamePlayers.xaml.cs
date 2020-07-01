using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Project_TTT
{
    /// <summary>
    /// Interaction logic for NamePlayers.xaml
    /// </summary>
    public partial class NamePlayers : Page
    {
        public NamePlayers()
        {
            InitializeComponent();
            
        
            
        }
            
        
        public static string Player2;
        public static string Player1;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            NavigationService.Navigate(new Game_GUI());
        }

        private void Player1name_TextChanged(object sender, TextChangedEventArgs e)
        {
            Player1 = Player1name.Text;
        }

        private void Player2name_TextChanged(object sender, TextChangedEventArgs e)
        {
            Player2 = Player2name.Text;
        }
    }
}
