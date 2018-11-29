using FootballChairmanTycoonWPF.Views;
using FootballSimulationGameLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace FootballChairmanTycoonWPF
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Season mSeason;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<FootballClub> ClubList { get { return mSeason.ClubList; } }
        public List<FootballPlayer> PlayerList { get { return mSeason.PlayerList; } }
        public List<FootballManager> ManagerList { get { return mSeason.ManagerList; } }
        public FootballLeague League { get { return mSeason.League; } }
        public List<LeagueFixture> ResultsList { get { return League.GetMatchWeekFixtures(Week-1).LeagueRoundFixtures; } }
        public List<FootballClub> LeagueTeams { get { return League.GetLeagueStandings(); } }
        public int Week { get { return mSeason.Week; } }
        public FootballPlayer SelectedPlayer { get; set; }

        public object CurrentView { get; set; }
        public string CurrentTitle { get; set; }

        public MainViewModel()
        {
            mSeason = new Season();
        }

        public void ViewClubList_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentView = new ClubListView();
            CurrentTitle = "Search Clubs";
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentView"));
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTitle"));
        }

        public void ViewResults_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentView = new ResultsView();

            if (ResultsList.Count > 0)
            {
                CurrentTitle = League.Name + " - " + "Match Round " + (Week - 7);
            }
            else
            {
                CurrentTitle = "No Results";
            }

            PropertyChanged(this, new PropertyChangedEventArgs("CurrentView"));
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTitle"));
            PropertyChanged(this, new PropertyChangedEventArgs("ResultsList"));
        }

        public void ViewLeagueTable_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentView = new LeagueTableView();
            CurrentTitle = League.Name;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentView"));
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTitle"));
            PropertyChanged(this, new PropertyChangedEventArgs("ResultsList"));
        }

        public void ViewPlayerList_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentView = new PlayerListView();
            CurrentTitle = "Search Players";
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentView"));
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTitle"));
        }

        public void ViewPlayerProfile_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SelectedPlayer = (FootballPlayer)e.Parameter;
            CurrentView = new PlayerProfileView();
            CurrentTitle = SelectedPlayer.FullName;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentView"));
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTitle"));
        }

        public void Continue_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mSeason.ProgressToNextWeek();
            CurrentView = null;
            CurrentTitle = null;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentView"));
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTitle"));
            PropertyChanged(this, new PropertyChangedEventArgs("Week"));
            PropertyChanged(this, new PropertyChangedEventArgs("League"));
            PropertyChanged(this, new PropertyChangedEventArgs("ResultsList"));
        }


        public void ExitApplication_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

    }
}
