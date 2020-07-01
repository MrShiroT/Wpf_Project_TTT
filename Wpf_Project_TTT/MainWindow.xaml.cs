using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Wpf_Project_TTT
{
    public enum fieldstate
    {
        Free,
        Circle,
        cross
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Path);
        
        public MainWindow()
        {
            InitializeComponent();
            mainframe.NavigationService.Navigate(new Mainmenu());

            player.PlayLooping();
            


            




        }
        
    }
}
