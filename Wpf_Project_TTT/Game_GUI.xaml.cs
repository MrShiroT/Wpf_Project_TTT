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
           
        public enum fieldstate
        {
            /// <summary>
            /// The cell hasn't been clicked yet
            /// </summary>
            Free,
            /// <summary>
            /// The cell is a O
            /// </summary>
            Nought,
            /// <summary>
            /// The cell is an X
            /// </summary>
            Cross
        }
        #region Private Members

        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private fieldstate[] fResults;

        /// <summary>
        /// True if it is player 1's turn (X) or player 2's turn (O)
        /// </summary>
        private bool Player1Turn;

        /// <summary>
        /// True if the game has ended
        /// </summary>
        private bool GameEnded;

        #endregion
        public Game_GUI()
        {   
            
            
            InitializeComponent();
            NewGame();
            Playerone.Text = NamePlayers.Player1;
            Playertwo.Text = NamePlayers.Player2;
        }
        
        private void NewGame()
        {
            // Create a new blank array of free cells
            fResults = new fieldstate[9];

            for (var i = 0; i < fResults.Length; i++)
                fResults[i] = fieldstate.Free;

            // Make sure Player 1 starts the game
            Player1Turn = true;

            

            // Interate every button on the grid...
            Container.Children.Cast<Button>().ToList().ForEach(Button =>
            {
                // Change background, foreground and content to default values
                Button.Content = string.Empty;
                Button.Background = Brushes.White;
                Button.Foreground = Brushes.Blue;
            });  

            // Make sure the game hasn't finished
            GameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Start a new game on the click after it finished
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
            if (fResults[index] != fieldstate.Free)
                return;

            // Set the cell value based on which players turn it is
            fResults[index] = Player1Turn ? fieldstate.Cross : fieldstate.Nought;

            // Set button text to the result
            button.Content = Player1Turn ? "X" : "O";

            // Change noughts to green
            if (!Player1Turn)
                button.Foreground = Brushes.Red;

            // Toggle the players turns
            Player1Turn ^= true; //Player1Turn = ! Player1Turn;

            // Check for a winner
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            #region Horizontal Wins

            // Check for horizontal wins
            //
            //  - Row 0
            //
            if (fResults[0] != fieldstate.Free && (fResults[0] & fResults[1] & fResults[2]) == fResults[0])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton1.Background = FieldButton2.Background = FieldButton3.Background = Brushes.Green;
            }
            //
            //  - Row 1
            //
            if (fResults[3] != fieldstate.Free && (fResults[3] & fResults[4] & fResults[5]) == fResults[3])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton4.Background = FieldButton5.Background = FieldButton6.Background = Brushes.Green;
            }
            //
            //  - Row 2
            //
            if (fResults[6] != fieldstate.Free && (fResults[6] & fResults[7] & fResults[8]) == fResults[6])
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
            if (fResults[0] != fieldstate.Free && (fResults[0] & fResults[3] & fResults[6]) == fResults[0])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton1.Background = FieldButton4.Background = FieldButton7.Background = Brushes.Green;
            }
            //
            //  - Column 1
            //
            if (fResults[1] != fieldstate.Free && (fResults[1] & fResults[4] & fResults[7]) == fResults[1])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton2.Background = FieldButton5.Background = FieldButton8.Background = Brushes.Green;
            }
            //
            //  - Column 2
            //
            if (fResults[2] != fieldstate.Free && (fResults[2] & fResults[5] & fResults[8]) == fResults[2])
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
            if (fResults[0] != fieldstate.Free && (fResults[0] & fResults[4] & fResults[8]) == fResults[0])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton1.Background = FieldButton5.Background = FieldButton9.Background = Brushes.Green;
            }
            //
            //  - Top Right Bottom Left
            //
            if (fResults[2] != fieldstate.Free && (fResults[2] & fResults[4] & fResults[6]) == fResults[2])
            {
                // Game ends
                GameEnded = true;

                // Highlight winning cells in green
                FieldButton3.Background = FieldButton5.Background = FieldButton7.Background = Brushes.Green;
            }

            #endregion

            #region No Winners

            // Check for no winner and full board
            if (!fResults.Any(f => f == fieldstate.Free))
            {
                // Game ended
                GameEnded = true;

                // Turn all cells orange
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });
            }

            #endregion


        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            
            Ingamemenu next = new Ingamemenu();
            MainWindow.SzenenListe.AddLast(next);
            NavigationService.Navigate(next);
        }
    }
}
