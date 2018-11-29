using System.Windows;
using System.Windows.Input;

namespace FootballChairmanTycoonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mViewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = mViewModel;

            this.CommandBindings.Add(new CommandBinding(TaskCommands.ViewClubList, mViewModel.ViewClubList_Executed));
            this.CommandBindings.Add(new CommandBinding(TaskCommands.ViewPlayerList, mViewModel.ViewPlayerList_Executed));
            this.CommandBindings.Add(new CommandBinding(TaskCommands.Continue, mViewModel.Continue_Executed));
            this.CommandBindings.Add(new CommandBinding(TaskCommands.ViewResults, mViewModel.ViewResults_Executed));
            this.CommandBindings.Add(new CommandBinding(TaskCommands.ViewLeagueTable, mViewModel.ViewLeagueTable_Executed));
            this.CommandBindings.Add(new CommandBinding(TaskCommands.ViewPlayerProfile, mViewModel.ViewPlayerProfile_Executed));

        }

    }
}
