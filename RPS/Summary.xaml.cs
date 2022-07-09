using RPS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPS
{
    /// <summary>
    /// Interaction logic for Summary.xaml
    /// </summary>
    public partial class Summary : Window
    {
        public Summary()
        {
            InitializeComponent();
        }

        public Summary(TextBlock number_of_wins_textblock, TextBlock number_of_Ties_textblock, TextBlock number_of_Losses_textblock, TextBlock number_of_wins_CPU_textblock, TextBlock number_of_Ties_CPU_textblock, TextBlock number_of_Losses_CPU_textblock)
        {
            InitializeComponent();

            Number_of_wins_textblock.Text = "WIN : " + number_of_wins_textblock.Text;
            Number_of_Ties_textblock.Text = "DRAW : " + number_of_Ties_textblock.Text;
            Number_of_Losses_textblock.Text = "LOSE : " + number_of_Losses_textblock.Text;
            Number_of_wins_CPU_textblock.Text = "WIN : " + number_of_wins_CPU_textblock.Text;
            Number_of_Ties_CPU_textblock.Text = "DRAW : " + number_of_Ties_CPU_textblock.Text;
            Number_of_Losses_CPU_textblock.Text = "LOSE : " + number_of_Losses_CPU_textblock.Text;
            Game_Count_Textblock.Text = "Game : 100";
            Game_Summary_Textblock.Text = "Summary";
       }
    }
}
