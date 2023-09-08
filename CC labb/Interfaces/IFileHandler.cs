namespace CC_labb
{
    interface IFileHandler
    {
        List<Player> GetSortedPlayerResultsFromFile(string gameName);
        List<Player> SortPlayerResults(List<Player> playerResults);
        void WritePlayerToFile(Player player, string gameName);
    }
}