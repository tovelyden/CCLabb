
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC_labb.Interfaces;

namespace CC_labb;

class Player : IPlayer
{
    public string UserName { get; set; }
    public int PlayedGames { get; set; }
    public int Score { get; set; }

    public Player(string userName, int score)
    {
        UserName = userName;
        PlayedGames = 1;
        Score = score;
    }
    public double Average()
    {
        return (double)Score / PlayedGames;
    }
    public void Update(int score)
    {
        Score += score;
        PlayedGames++;
    }
    public override bool Equals(Object p)
    {
        return UserName.Equals(((Player)p).UserName);
    }
    public override int GetHashCode()
    {
        return UserName.GetHashCode();
    }
}
