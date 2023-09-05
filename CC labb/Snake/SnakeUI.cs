using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace CC_labb.Snake
{
    class SnakeUI : UI
    {
        public void DrawSnake(List<Position> snake)
        {
            foreach (Position snakePosition in snake)
            {
                Console.SetCursorPosition(snakePosition.x, snakePosition.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Write("#");
                Console.ResetColor();
            }
        }
        public void SeeCurrentScore(int score)
        {
            Console.SetCursorPosition(59, 0);
            WriteLine($"Current score: {score}");
        }
        public void ClearConsole()
        {
            Console.Clear();
        }
        public override string ShowResultForRound(int score)
        {
            return ($"You ate {score} pieces of food. Good job!");
        }
    }
}
