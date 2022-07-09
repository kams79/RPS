using RPS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private Player player;

        private string PlayerName;

        private string PlayerChoice;

        private int playerWin;
        private int playerDraw;
        private int playerLose;

        public string MyProperty
        {
            get { return PlayerName; }
            set { PlayerName = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
