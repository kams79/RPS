using RPS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace RPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Player player1 = new Player();
        Player player2 = new Player();
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new {
                Player1 = player1,
                Player2 = player2
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DoRPS();

        }

        public void StartGame()
        {
            DoRPS();
        }

        private async Task DoRPS()
        {
            Run_game.IsEnabled = false;

            int count = 1;

            //init variable for p1
            player1.Win = 0;
            player1.Draw = 0;
            player1.Lose = 0;

            //init variable for p2
            player2.Win = 0;
            player2.Draw = 0;
            player2.Lose = 0;

            while (count <= 100)
            {
                var choices = new List<string> { "rock", "paper", "scissor" };

                Player1_Option_Chosen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/MickeyRockBetterfortheplayer.png"));

                int index = random.Next(choices.Count);
                player2.PlayerChoice = choices[index];

                //we can assume that player1 always bet rock/stone
                //do not need define player1 choice
                if (player2.PlayerChoice.Equals("rock"))
                {
                    Player2_Option_Chosen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/MickeyRockBetter.png"));
                    player1.Draw++;
                    player2.Draw++;

                }
                if (player2.PlayerChoice.Equals("paper"))
                {
                    Player2_Option_Chosen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/paperright.png"));
                    player1.Lose++;
                    player2.Win++;

                }
                if (player2.PlayerChoice.Equals("scissor"))
                {
                    Player2_Option_Chosen.Source = new BitmapImage(new Uri("pack://application:,,,/Images/Scissors for the right sideTransparent.png"));
                    player1.Win++;
                    player2.Lose++;
                }

                Game_Status_Textblock.Text = "Game :" + count;
                Game_Status_Textblock.Foreground = System.Windows.Media.Brushes.Black;
                count++;
                await Task.Delay(1000);
            }

            Run_game.IsEnabled = true;

            Summary summary = new Summary(Number_of_wins_textblock,
            Number_of_Ties_textblock,
            Number_of_Losses_textblock,
            Number_of_wins_CPU_textblock,
            Number_of_Ties_CPU_textblock,
            Number_of_Losses_CPU_textblock);
            summary.Show();

        }
    }
}
