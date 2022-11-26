using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    public class Snake
    {
        Queue<Position> positions = new Queue<Position>();

        public Queue<Position> GetPositions
        {
            get { return positions; }
        }

        public int Length 
        { 
            get { return positions.Count; } 
        }

        public Snake()
        {
            for (int i = 3; i <= 8; i++)
            {
                positions.Enqueue(new Position(i, 2, '*'));
            }
        }

        public void PrintSnake()
        {
            foreach(Position pos in positions)
            {
                pos.WriteSymbol();
            }
        }

        public void MoveSnake(Vector vector)
        {
            Position head = new Position (
                positions.Last().X + vector.X,
                positions.Last().Y + vector.Y,
                '*');

            ControllsApp.CheckForEnd(this, head);

            positions.Enqueue(head);
            head.WriteSymbol();

            if (!ControllsApp.CheckForCollisionWithFood(head))
            {
                positions.Dequeue().UnwriteSymbol();                
            }
        }
    }
}
