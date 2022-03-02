using FM_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FM_WPF.ViewModels
{
    public class TeamViewModel : INotifyPropertyChanged
    {
        public Action CloseAction { get; set; }//To close window CloseAction();
        #region ICommands

        public ICommand EmployeeViewCommand { get; set; }
        public ICommand AddEmployeeCommand { get; set; }
        public ICommand GetRosterCommand { get; set; }
        public ICommand UpdateEmployeeCommand { get; set; }

        #endregion // ICommands
        #region INotyfyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion //INotifyPropertyChanged
        private ObservableCollection<Player> players;
        #region Propertys
        public ObservableCollection<Player> Players
        {
            get { return players; }
            set
            {
                if (value != players)
                {
                    players = value;
                    NotifyPropertyChanged();
                }

            }
        }
        #endregion // Propertys
        public TeamViewModel()
        {
            Player player = new Player();
            Players = new ObservableCollection<Player>();
            for (int i = 0; i < 5; i++)
            {
                player = PlayerGenerator.CreateNewPlayer("Germany", "Kaiserslautern", "Goalkeeper");
                Players.Add(player);
            }
            for (int i = 0; i < 10; i++)
            {
                player = PlayerGenerator.CreateNewPlayer("Germany", "Kaiserslautern", "Defense");
                Players.Add(player);
            }
            for (int i = 0; i < 10; i++)
            {
                player = PlayerGenerator.CreateNewPlayer("Germany", "Kaiserslautern", "Midfield");
                Players.Add(player);
            }
            for (int i = 0; i < 10; i++)
            {
                player = PlayerGenerator.CreateNewPlayer("Germany", "Kaiserslautern", "Attack");
                Players.Add(player);
            }

        }
    }
}
