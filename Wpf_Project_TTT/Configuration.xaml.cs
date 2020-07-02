using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaktionslogik für Configuration.xaml
    /// </summary>
    public partial class Configuration : Page
    {
        
        public Configuration()
        {
            
            InitializeComponent();
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            
            
            
            NavigationService.Navigate(new Mainmenu());
        }

        private void FlipButton_Click(object sender, RoutedEventArgs e)
        {
            if((string) FlipButton.Content != "On")
            {
                FlipButton.Content = "On";

            }
            else
            {
                FlipButton.Content = "Off";
            }
        }

        private void FlipButton1_Click(object sender, RoutedEventArgs e)
        {
            if ((string)FlipButton1.Content != "On")
            {
                MainWindow.player.Play();
                FlipButton1.Content = "On";

            }
            else
            {
                MainWindow.player.Stop();
                FlipButton1.Content = "Off";
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            
        }
    }
}
