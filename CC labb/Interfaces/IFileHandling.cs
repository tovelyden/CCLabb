namespace CC_labb.Interfaces;

internal interface IFileHandling
{
    void WriteUserToFile(Player player, string gameName);
    List<Player> GetSortedPlayerResults(string gameName);
    List<Player> SortPlayerResults(List<Player> playerResults);
}