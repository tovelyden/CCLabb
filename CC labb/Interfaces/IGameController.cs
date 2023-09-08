namespace CC_labb;

interface IGameController
{
    IUI UI { get; set; }
    IFileHandler FileHandle { get; set; }
    IScoreBoard Scores { get; set; }
    List<IGame> Games { get; set; }
    void StartGame();
    IGame PickGame();
}