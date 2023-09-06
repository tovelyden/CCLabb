namespace CC_labb;

interface IGameController
{
    void StartGame();
    IGame PickGame();
    void ShowAllTopLists();
    void ShowTopList(string gameName);
}