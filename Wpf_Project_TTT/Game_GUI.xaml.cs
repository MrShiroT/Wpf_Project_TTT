using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        /* public class BoardDisplay
         {
             public string DisplayBoard(string[,] stringArray)
             {
                 string arrayString = " 1 2 3\n";
                 int rowCounter = 1;
                 int rowLength = stringArray.GetLength(0);
                 int columnLength = stringArray.GetLength(1);

                 for (int i= 0; i < rowLength; i++)
                 {
                     arrayString += rowCounter.ToString();
                     arrayString += " ";
                     for (int j = 0; j < columnLength; j++)
                     {
                         arrayString += stringArray[i, j];
                         arrayString += " ";
                     }
                     arrayString += "\n";
                     rowCounter++;
                 }
                 return arrayString.TrimEnd('\n');
             }
         } */


        private bool Player1Turn;
        private bool GameEnded;

        public Game_GUI()
        {

            InitializeComponent();

            Playerone.Text = NamePlayers.Player1;
            Playertwo.Text = NamePlayers.Player2;
            NewGame();

        }

        private void NewGame()
        {
            fieldstate[]  field = new fieldstate[9];


            for (var i = 0; i < field.Length; i++)
            {
                field[i] = fieldstate.Free;
            }

            Player1Turn = true;
            GameEnded = false;

        }

        public fieldstate[] field;
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Ingamemenu());
        }

       
        private void FieldButton1_Click(object sender, RoutedEventArgs e)
        {
            if (GameEnded)
            {
                NewGame();
                return;
            }

            // Cast the sender to a button
            var button = (Button)sender;

            // Find the buttons position in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            // Don't do anything if the cell already has a value in it
            if (field[index] != fieldstate.Free)
            
                return;
            
            // Set the cell value based on which players turn it is
            field[index] = Player1Turn ? fieldstate.cross : fieldstate.Circle;

            // Set button text to the result
            button.Content = Player1Turn ? "X" : "O";

            // Change noughts to green
            if (!Player1Turn)
                button.Foreground = Brushes.Red;

            // Toggle the players turns
            Player1Turn ^= true;

            // Check for a winner
            CheckForWinner();

        }

        private void FieldButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FieldButton9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckForWinner()
        {
            #region Horizontal Wins

            // Check for horizontal wins
            //
            //  - Row 0
            //
            if (field[0] != fieldstate.Free && (field[0] & field[1] & field[2]) == field[0])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton1.Background = FieldButton2.Background = FieldButton3.Background = Brushes.Green;
            }
            //
            //  - Row 1
            //
            if (field[3] != fieldstate.Free && (field[3] & field[4] & field[5]) == field[3])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton4.Background = FieldButton5.Background = FieldButton6.Background = Brushes.Green;
            }
            //
            //  - Row 2
            //
            if (field[6] != fieldstate.Free && (field[6] & field[7] & field[8]) == field[6])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton7.Background = FieldButton8.Background = FieldButton9.Background = Brushes.Green;
            }

            #endregion

            #region Vertical Wins

            // Check for vertical wins
            //
            //  - Column 0
            //
            if (field[0] != fieldstate.Free && (field[0] & field[3] & field[6]) == field[0])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton1.Background = FieldButton4.Background = FieldButton7.Background = Brushes.Green;
            }
            //
            //  - Column 1
            //
            if (field[1] != fieldstate.Free && (field[1] & field[4] & field[7]) == field[1])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton2.Background = FieldButton5.Background = FieldButton8.Background = Brushes.Green;
            }
            //
            //  - Column 2
            //
            if (field[2] != fieldstate.Free && (field[2] & field[5] & field[8]) == field[2])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton3.Background = FieldButton6.Background = FieldButton9.Background = Brushes.Green;
            }

            #endregion

            #region Diagonal Wins

            // Check for diagonal wins
            //
            //  - Top Left Bottom Right
            //
            if (field[0] != fieldstate.Free && (field[0] & field[4] & field[8]) == field[0])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton1.Background = FieldButton5.Background = FieldButton9.Background = Brushes.Green;
            }
            //
            //  - Top Right Bottom Left
            //
            if (field[2] != fieldstate.Free && (field[2] & field[4] & field[6]) == field[2])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton3.Background = FieldButton5.Background = FieldButton7.Background = Brushes.Green;
            }

            #endregion

            #region No Winners

            // Check for no winner and full board
            if (!field.Any(f => f == fieldstate.Free))
            {
                // Game ended
                GameEnded = true;

                // Turn all cells orange
               
            }

            #endregion
        }

        
    }
}
