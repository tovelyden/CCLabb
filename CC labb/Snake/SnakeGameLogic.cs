using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace CC_labb.Snake
{
    class SnakeGameLogic
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char direction = 'u';

        public Food food;

        public int x { get; set; }
        public int y { get; set; }
        public int Score { get; set; }

        public List<Position> snake;
        public Position foodPosition;

        public SnakeGameLogic()
        {
            food = new Food();

            x = (Console.WindowWidth / 2);
            y = (Console.WindowHeight / 2);
            Score = 0;

            snake = new List<Position>
            {
                new Position(x, y)
            };

            foodPosition = food.FoodLocation();
        }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }
        public void Direction()
        {
            if (key == 'w' && direction != 'd')
            {
                direction = 'u';
            }
            else if (key == 's' && direction != 'u')
            {
                direction = 'd';
            }
            else if (key == 'd' && direction != 'l')
            {
                direction = 'r';
            }
            else if (key == 'a' && direction != 'r')
            {
                direction = 'l';
            }
        }
        public void MoveSnake()
        {
            Direction();
            if (direction == 'u')
            {
                y--;
            }
            else if (direction == 'd')
            {
                y++;
            }
            else if (direction == 'r')
            {
                x++;
            }
            else if (direction == 'l')
            {
                x--;
            }
            snake.Add(new Position(x, y));
            snake.RemoveAt(0);
            Thread.Sleep(100);
        }
        public void GrowSnake()
        {
            Position snakeHead = snake[snake.Count - 1];

            if (snakeHead.x == foodPosition.x && snakeHead.y == foodPosition.y)
            {
                snake.Add(new Position(x, y));
                food.FoodLocationNew();
                Score++;
            }
        }
        public void HitSelf(SnakeUI uiSnake)
        {
            Position head = snake[snake.Count - 1];

            for (int i = 0; i < snake.Count - 2; i++)
            {
                Position snakeBody = snake[i];

                if (head.x == snakeBody.x && head.y == snakeBody.y)
                {
                    throw new SnakeException("You lost\n" + uiSnake.ShowResultForRound(Score));
                }
            }
        }
        public void HitWall(SnakeUI uiSnake)
        {
            Position head = snake[snake.Count - 1];

            if (head.x == Console.WindowWidth || head.x == 0 || head.y == Console.WindowHeight || head.y == 0)
            {
                throw new SnakeException("You lost\n" + uiSnake.ShowResultForRound(Score));
            }
        }
        public void ResetSnake()
        {
            Score = 0;

            x = (Console.WindowWidth / 2);
            y = (Console.WindowHeight / 2);

            snake = new List<Position>
            {
                new Position(x, y)
            };
        }

        public int GetScore()
        {
            return Score;
        }
    }
}
