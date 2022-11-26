using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    public class Position
    {
        public Position(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }

        public void WriteSymbol()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void UnwriteSymbol()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }
    }
}
