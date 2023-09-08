namespace CC_labb;

class ScoreBoard : IScoreBoard
{
    private IUI UI;
    private IFileHandler FileHandle;

    public ScoreBoard()
    {
        this.UI = new UI();
        this.FileHandle = new FileHandler();
    }
    public void SendNewPlayerScoreToFile(Player newPlayer, string gameName)
    {
        FileHandle.WritePlayerToFile(newPlayer, gameName);
    }
    public void ShowTopList(string gameName)
    {
        List<Player> sortedPlayerResults = FileHandle.GetSortedPlayerResultsFromFile(gameName);

        UI.WriteLine($"\n---Score Board for {gameName}---\nPlayer   games  average");

        foreach (Player player in sortedPlayerResults)
        {
            UI.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", player.UserName, player.PlayedGames, player.Average()));
        }
    }
    public void ShowAllTopLists(List<IGame> Games)
    {
        foreach (var game in Games)
        {
            ShowTopList(game.GameName);
        }
    }
}
