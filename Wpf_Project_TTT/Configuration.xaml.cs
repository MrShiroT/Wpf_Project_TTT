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
    /// Interaktionslogik für Configuration.xaml
    /// </summary>
    public partial class Configuration : Page
    {
        StringBuilder buildstring = new StringBuilder();

        

        

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Mainmenu());
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            
        }

        private void FlipButton_Click(object sender, RoutedEventArgs e)
        {
            if ((string) FlipButton.Content != "On")
            {
                FlipButton.Content = "On";
            } 
            else
            {
                FlipButton.Content = "Off";
            }
            
        }
    }
}
