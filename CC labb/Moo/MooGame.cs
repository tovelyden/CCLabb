namespace CC_labb;

class MooGame : IGame
{
    public IUI UI { get; set; }

    private MooGameLogic Logic;
    public string GameName { get; set; }
    public int Score { get; set; }

    public MooGame()
    {
        UI = new UI();
        Logic = new MooGameLogic();
        GameName = "Moo";
        Score = 0;
    }
    public void PlayGame()
    {
        string numbers = Logic.GetRandomNumbers();

        //comment out or remove next line to play real games!
        UI.WriteLine("For practice, number is: " + numbers + "\n");

        bool guessAgain = true;

        while (guessAgain)
        {
            Score++;
            string guessingNumbers = UI.Read();
            string matches = Logic.CheckMatchingNumbers(numbers, guessingNumbers);
            UI.WriteLine(matches + "\n");

            if (matches == "BBBB")
                guessAgain = false;
        }
        UI.WriteLine(UI.ShowResultForRound(Score));
    }
}
