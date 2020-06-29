using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für Game_GUI.xaml
    /// </summary>
    public partial class Game_GUI : Page
    {
        public Game_GUI()
        {
            InitializeComponent();
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Ingamemenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
