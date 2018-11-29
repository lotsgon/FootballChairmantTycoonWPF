using System.Collections.Generic;

namespace FootballChairmanTycoonWPF.ViewModels
{
    public class DesignTimeViewModel
    {
        public static readonly DesignTimeViewModel sInstance = new DesignTimeViewModel();

        private DesignTimeViewModel()
        {
            this.ClubList = new List<FootballSimulationGameLibrary.FootballClub> { new FootballSimulationGameLibrary.FootballClub(1, "Tom Utd", "Tom United And Albion Villa FC", "T", "Birmingham", 4, "England", 1945, "ofjdo", "fjiomriem", 49540, new List<FootballSimulationGameLibrary.FootballPlayer>(), new FootballSimulationGameLibrary.FootballManager(1, "bill", "gates", 34, new FootballSimulationGameLibrary.ManagerFormation("", 1, 1, 1, 1), 34, 34, 34), new FootballSimulationGameLibrary.FootballChairman(1, "FI", "jfdij", 34, 5435, 45, 45, 452544252)),
                                                                                   new FootballSimulationGameLibrary.FootballClub(2, "Buckingham Utd", "Buckingham United FC", "T", "Birmingham", 4, "England", 1945, "ofjdo", "fjiomriem", 49540, new List<FootballSimulationGameLibrary.FootballPlayer>(), new FootballSimulationGameLibrary.FootballManager(1, "bill", "gates", 34, new FootballSimulationGameLibrary.ManagerFormation("", 1, 1, 1, 1), 34, 34, 34), new FootballSimulationGameLibrary.FootballChairman(1, "FI", "jfdij", 34, 5435, 45, 45, 452544252))};
        }

        public List<FootballSimulationGameLibrary.FootballClub> ClubList { get; }
        public FootballSimulationGameLibrary.FootballClub Club { get { return ClubList[0]; } }

        public string ListName { get; } = "Tom's Design time data";
    }
}