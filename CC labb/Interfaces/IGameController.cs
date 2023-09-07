namespace CC_labb;

interface IGameController
{
    IUI UI { get; set; }
    FileHandler FileHandle { get; set; }
    ScoreBoard Scores { get; set; }
    public List<IGame> Games { get; set; }
    void StartGame();
    IGame PickGame();
}