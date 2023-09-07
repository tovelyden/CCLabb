namespace CC_labb;

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