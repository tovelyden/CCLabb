namespace CC_labb;

public class SnakeGame : IGame
{
    public IUI UI { get; set; }
    public SnakeUI UISnake { get; set; }
    public SnakeGameLogic Logic { get; set; }

    public string GameName { get; set; }
    public int Score { get; set; }
    public SnakeGame()
    {
        Console.WindowHeight = 25;
        Console.WindowWidth = 75;
        Console.BufferHeight = 25;
        Console.BufferWidth = 75;
        Console.CursorVisible = false;

        UI = new UI();
        UISnake = new SnakeUI();
        Logic = new SnakeGameLogic();

        GameName = "Snake";
        Score = 0;
    }
    public void PlayGame()
    {
        Logic.ResetSnake();
        bool play = true;
        while (play)
        {
            try
            {
                Score = Logic.GetScore();
                UISnake.SeeCurrentScore(Score);
                Logic.food.DrawFood();
                Logic.Input();
                UISnake.DrawSnake(Logic.snake);
                Logic.MoveSnake();
                Logic.GrowSnake();
                UISnake.ClearConsole();
                Logic.HitSelf(UISnake);
                Logic.HitWall(UISnake);
            }
            catch (SnakeException e)
            {
                UISnake.ClearConsole();
                UI.WriteLine(e.Message);
                play = false;
            }
        }
    }
}
