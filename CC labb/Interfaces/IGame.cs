namespace CC_labb;

interface IGame
{
    IUI UI { set; }
    string GameName { get; set; }
    int Score { get; set; }

    void PlayGame();
}
