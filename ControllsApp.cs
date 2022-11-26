using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    public static class ControllsApp
    {
        public static bool GameIsOver = false;

        public static double Speed = 24;

        public static double Ratio = 1.75;

        public static bool CheckForCollisionWithFood(Position head)
        {
            bool result = head.X == Food.position.X && head.Y == Food.position.Y;

            if (result)
            {
                Food.GiveNewFood();
            }

            return result;
        }

        public static void CheckForEnd(Snake snake, Position head)
        {
            if(head.X <= 0 || head.Y <= 0 || head.X >= Console.WindowWidth - 1 || head.Y >= Console.WindowHeight)
            {
                OnOtherSide(head);
            }

            foreach(Position pos in snake.GetPositions)
            {
                if(pos.X == head.X && pos.Y == head.Y)
                {
                    GameOver();
                }
            }

        }

        private static void OnOtherSide(Position head)
        {
            if(head.X <= 0)
            {
                head.X = Console.WindowWidth - 2;
            }

            if (head.X >= Console.WindowWidth - 1)
            {
                head.X = 0;
            }

            if (head.Y <= 0)
            {
                head.Y = Console.WindowHeight - 1;
            }

            if (head.Y >= Console.WindowHeight)
            {
                head.Y = 0;
            }
        }

        private static void GameOver()
        {
            GameIsOver = true;
        }
    }
}
