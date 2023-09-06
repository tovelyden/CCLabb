using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC_labb.Interfaces;
using static System.Formats.Asn1.AsnWriter;

namespace CC_labb;

class GameController : IGameController
{
    private IUI UI;

    public List<IGame> Games;

    public FileHandling fileHandling;

    public GameController(IUI ui)
    {
        this.UI = ui;
        Games = new List<IGame>();
        fileHandling = new FileHandling();
    }
    public void StartGame()
    {
        UI.WriteLine("Choose what game to play or press 0 to see score boards:");

        IGame pickedGame = PickGame();

        string userName = GetUserName();

        pickedGame.PlayGame();

        fileHandling.WriteUserToFile(new Player(userName, pickedGame.Score), pickedGame.GameName);
        ShowTopList(pickedGame.GameName);

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
            ShowAllTopLists();
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
    public void ShowTopList(string gameName)
    {
        List<Player> sortedPlayerResults = fileHandling.GetSortedPlayerResults(gameName);

        Console.WriteLine($"\n---Score Board for {gameName}---\nPlayer   games  average");

        foreach (Player player in sortedPlayerResults)
        {
            Console.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", player.UserName, player.PlayedGames, player.Average()));
        }
    }
    public void ShowAllTopLists()
    {
        foreach (var game in Games)
        {
            ShowTopList(game.GameName);
        }
    }
}
