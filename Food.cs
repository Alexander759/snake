using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    public static class Food
    {
        private static int height = Console.WindowHeight;
        private static int width = Console.WindowWidth;
        private static Random randomGenerator = new Random();

        public static Position position = new Position(
                randomGenerator.Next(0, width),
                randomGenerator.Next(0, height),
                '@'
        );

        public static void Show()
        {
            position.WriteSymbol();
        }

        public static void GiveNewFood()
        {
            position = new Position(
                randomGenerator.Next(5, width - 5),
                randomGenerator.Next(5, height - 5),
                '@'
            );

            position.WriteSymbol();
        }

    }
}
