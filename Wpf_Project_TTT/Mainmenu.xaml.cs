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
    /// Interaktionslogik für Mainmenu.xaml
    /// </summary>
    public partial class Mainmenu : Page
    {
        //public static LinkedList<Page> SzenenListe = new LinkedList<Page>();

        public Mainmenu()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NamePlayers next = new NamePlayers();
            MainWindow.SzenenListe.AddLast(next);
           NavigationService.Navigate(next);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Configuration next = new Configuration();
            MainWindow.SzenenListe.AddLast(next);
            NavigationService.Navigate(next);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
