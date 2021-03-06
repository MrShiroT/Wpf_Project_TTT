﻿using System;
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
    /// Interaktionslogik für Ingamemenu.xaml
    /// </summary>
    public partial class Ingamemenu : Page
    {
        public Ingamemenu()
        {
            
            InitializeComponent();
        }

        

        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SzenenListe.RemoveLast();
            NavigationService.Navigate(MainWindow.SzenenListe.Last);
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Game_GUI());
        }

        private void Backtomainmenu_Click(object sender, RoutedEventArgs e)
        {
            Configuration next = new Configuration();
            MainWindow.SzenenListe.AddLast(next);
            NavigationService.Navigate(next);
        }

        private void Backtomainmenu_Click_1(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Mainmenu());
        }
    }
}
