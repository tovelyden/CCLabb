namespace CC_labb.Interfaces
{
    internal interface IFileHandling
    {
        List<Player> GetSortedPlayerResults(string gameName);
        List<Player> SortPlayerResults(List<Player> playerResults);
        void WriteUserToFile(Player player, string gameName);
    }
}