﻿namespace CC_labb;

interface IPlayer
{
    string UserName { get; }
    int PlayedGames { get; }
    int Score { get; }

    double Average();
    void Update(int guesses);
    bool Equals(object p);
    int GetHashCode();
}