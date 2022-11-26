using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    public static class VectorController
    {
        static Vector up = new Vector(0, -1);
        static Vector down = new Vector(0, 1);
        static Vector left = new Vector(-1, 0);
        static Vector right = new Vector(1, 0);

        public static Vector movement = right;

        public static void CheckForKey()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();

                if (ConsoleKey.UpArrow == key.Key)
                {
                    if (movement != down && movement != up)
                    {
                        movement = up;
                        ControllsApp.Speed = ControllsApp.Speed * ControllsApp.Ratio;
                    }
                }
                else if (ConsoleKey.DownArrow == key.Key)
                {
                    if (movement != up && movement != down )
                    {
                        movement = down;
                        ControllsApp.Speed = ControllsApp.Speed * ControllsApp.Ratio;
                    }
                }
                else if (ConsoleKey.LeftArrow == key.Key)
                {
                    if (movement != right && movement != left)
                    {
                        movement = left;
                        ControllsApp.Speed = ControllsApp.Speed / ControllsApp.Ratio;
                    }
                }
                else if (ConsoleKey.RightArrow == key.Key)
                {
                    if (movement != left && movement != right)
                    {
                        movement = right;
                        ControllsApp.Speed = ControllsApp.Speed / ControllsApp.Ratio;
                    }
                }
            }
        }
    }
}
