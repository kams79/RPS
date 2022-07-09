using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Model
{
    internal class Player : INotifyPropertyChanged
    {
        private int win;
        private int lose;
        private int draw;
        private string playerChoice;

        public string PlayerName { get; set; }
        public string PlayerChoice { get => playerChoice; set { playerChoice = value; OnPropertyChange(); } }
        public int Win { get => win; set { win = value; OnPropertyChange(); } }
        public int Lose { get => lose; set { lose = value; OnPropertyChange(); } }
        public int Draw { get => draw; set { draw = value; OnPropertyChange(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
