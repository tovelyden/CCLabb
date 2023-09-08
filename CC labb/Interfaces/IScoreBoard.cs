namespace CC_labb
{
    interface IScoreBoard
    {
        void ShowAllTopLists(List<IGame> Games);
        void ShowTopList(string gameName);
    }
}