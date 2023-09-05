using System;
using System.IO;
using System.Collections.Generic;
using CC_labb.Snake;
using CC_labb.Moo;
using CC_labb.Interfaces;

namespace CC_labb
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Skriv i dokumentationen om varför ditt IUI SER UT SOM DET GÖÖÖÖÖÖR!!!!!!11111
            IUI ui = new UI();

            GameController gameController = new GameController(ui);

            MooGame mooGame = new MooGame();
            SnakeGame snakeGame = new SnakeGame();

            gameController.Games.Add(mooGame);
            gameController.Games.Add(snakeGame);
            gameController.StartGame();
        }
    }
}