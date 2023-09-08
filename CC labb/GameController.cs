namespace CC_labb;

class GameController : IGameController
{
    public IUI UI { get; set; }
    public List<IGame> Games { get; set; }
    public IScoreBoard Scores { get; set; }
 
    public GameController(IUI ui)
    {
        this.UI = ui;
        Games = new List<IGame>();
        Scores = new ScoreBoard();
    }
    public void StartGame()
    {
        UI.WriteLine("Choose what game to play or press 0 to see score boards:");

        IGame pickedGame = PickGame();

        string userName = GetUserName();

        pickedGame.PlayGame();

        Scores.SendNewPlayerScoreToFile(new Player(userName, pickedGame.Score), pickedGame.GameName);
        Scores.ShowTopList(pickedGame.GameName);

        ContinueOrExit();
    }
    public IGame PickGame()
    {
        int listNumber = 1;

        for (int i = 0; i < Games.Count; i++)
        {
            UI.WriteLine($"{listNumber}. {Games[i].GameName}");
            listNumber++;
        }

        int menuChoice = int.Parse(UI.Read());

        if (menuChoice == 0)
        {
            Scores.ShowAllTopLists(Games);
            ContinueOrExit();
        }

        return Games[menuChoice - 1];
    }
    private string GetUserName()
    {
        UI.WriteLine("Enter your username:\n");

        string userName = UI.Read();
        return userName;
    }
    private void ContinueOrExit()
    {
        UI.WriteLine("Continue? y/n");
        string answer = UI.Read();

        if (answer.Substring(0, 1).ToLower() == "n")
        {
            UI.ExitProgram();
        }
        else
        {
            StartGame();
        }
    }
}
