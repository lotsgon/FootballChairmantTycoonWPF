using System.Windows.Input;

namespace FootballChairmanTycoonWPF
{
    public class TaskCommands
    {
        public static RoutedCommand ViewClubList = new RoutedCommand();
        public static RoutedCommand ViewPlayerList = new RoutedCommand();
        public static RoutedCommand ViewResults = new RoutedCommand();
        public static RoutedCommand ViewLeagueTable = new RoutedCommand();
        public static RoutedCommand ViewPlayerProfile = new RoutedCommand();
        public static RoutedCommand Continue = new RoutedCommand();
        public static RoutedCommand DeleteTask = new RoutedCommand();
        public static RoutedCommand ExitApplication = new RoutedCommand();
        public static RoutedCommand ClearList = new RoutedCommand();
        public static RoutedCommand CheckCompleted = new RoutedCommand();
        public static RoutedCommand EditTask = new RoutedCommand();
        public static RoutedCommand ConfirmTask = new RoutedCommand();
        public static RoutedCommand ConfirmRemoveTag = new RoutedCommand();
        public static RoutedCommand ConfirmAddTag = new RoutedCommand();
        public static RoutedCommand ConfirmCancel = new RoutedCommand();
        public static RoutedCommand MoveTaskUp = new RoutedCommand();
        public static RoutedCommand MoveTaskDown = new RoutedCommand();
        public static RoutedCommand ClearFilter = new RoutedCommand();
    }
}
