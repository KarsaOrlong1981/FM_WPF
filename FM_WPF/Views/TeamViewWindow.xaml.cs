using FM_WPF.ViewModels;
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

namespace FM_WPF.Views
{
    /// <summary>
    /// Interaktionslogik für TeamViewWindow.xaml
    /// </summary>
    public partial class TeamViewWindow : Window
    {
        public TeamViewWindow()
        {
            InitializeComponent();
            TeamViewModel vm = new TeamViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }
    }
}
