﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CC_labb.Interfaces;

namespace CC_labb
{
    class FileHandling : IFileHandling
    {
        public void WriteUserToFile(Player player, string gameName)
        {
            StreamWriter fileInput = new StreamWriter($"{gameName}Result.txt", append: true);
            fileInput.WriteLine(player.UserName + ": " + player.Score);
            fileInput.Close();
        }
        public List<Player> GetPlayerResults(string gameName)
        {
            StreamReader fileOutput = new StreamReader($"{gameName}Result.txt");
            List<Player> playerResults = new List<Player>();
            string line;
            while ((line = fileOutput.ReadLine()) != null)
            {
                string[] userNameAndScore = line.Split(new string[] { ": " }, StringSplitOptions.None);
                Player player = new Player(userNameAndScore[0], int.Parse(userNameAndScore[1]));
                int playerIndex = playerResults.IndexOf(player);
                if (playerIndex < 0)
                {
                    playerResults.Add(player);
                }
                else
                {
                    playerResults[playerIndex].Update(player.Score);
                }
            }
            fileOutput.Close();

            List<Player> sortedPlayerResults = SortPlayerResults(playerResults);
            return sortedPlayerResults;
        }
        public List<Player> SortPlayerResults(List<Player> playerResults)
        {
            playerResults.Sort((p1, p2) => p1.Average().CompareTo(p2.Average()));
            return playerResults;
        }

    }
}
