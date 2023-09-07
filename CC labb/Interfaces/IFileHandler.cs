namespace CC_labb
{
    interface IFileHandler
    {
        List<Player> GetSortedPlayerResultsFromFile(string gameName);
        List<Player> SortPlayerResults(List<Player> playerResults);
        void WriteUserToFile(Player player, string gameName);
    }
}