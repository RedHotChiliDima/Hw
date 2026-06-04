using System.Drawing;

namespace SnakeGame.Game
{
    internal class Snake
    {
        public SnakeNode Head { get; private set; }
        public SnakeNode Tail { get; private set; }
        public int Count { get; private set; }

        public void AddNode(Point newPosition)
        {
            SnakeNode snakeNode = new SnakeNode(newPosition);
            if (Head == null)
            {
                Head = snakeNode;
                Tail = snakeNode;
            }
            else
            {
                snakeNode.Next = Head;
                Head.Previous = snakeNode;
                Head = snakeNode;
            }
            Count++;
        }

        public void RemoveLast()
        {
            if (Tail == null) return;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;

            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            Count--;
        }


    }
    internal class SnakeNode
    {
        public Point Position { get; set; }

        public SnakeNode Next { get; set; }
        public SnakeNode Previous { get; set; }

        public SnakeNode(Point Position)
        {this.Position = Position;}
    }
}
