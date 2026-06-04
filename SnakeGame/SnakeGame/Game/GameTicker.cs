using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame.Game
{
    internal class GameTicker
    {
        private Random random = new Random();
        private int fieldWidth;
        private int fieldHeight;
        private int dirX = 1;
        private int dirY = 0;
        public int score;
        public Snake Snake;
        public Point Food = new Point(10,10);
        private bool canChangeDirection;
        public bool IsGameOver;
        
        public GameTicker(int fieldWidth, int fieldHeight)
        {
            this.fieldWidth = fieldWidth; this.fieldHeight = fieldHeight;
            Snake = new Snake();
            Snake.AddNode(new Point(10, 10));
        }

        public void MakeTick()
        {
            canChangeDirection = true;

            Point newHead = new Point(Snake.Head.Position.X + dirX, Snake.Head.Position.Y + dirY);

            if(CheckCollision(newHead))
            {
                IsGameOver = true;
                return;
            }

            Snake.AddNode(newHead);
            if (newHead == Food)
            {
                GenerateFood();
                score++;
            }
            else 
            {
                Snake.RemoveLast();
            }

        }
        public void GenerateFood()
        {
            int randX;
            int randY;
            Point potentialFood;
            bool isSnakeHere;
            SnakeNode current;
            while (true)
            {

                randX = random.Next(0, fieldWidth);
                randY = random.Next(0, fieldHeight);
                potentialFood = new Point(randX, randY);

                isSnakeHere = false;
                current = Snake.Head;

                while (current != null)
                {
                    if (current.Position == potentialFood)
                    {
                        isSnakeHere = true;
                        break;
                    }
                    current = current.Next;
                }


                if (!isSnakeHere)
                {
                    this.Food = potentialFood;
                    break;
                }
            }
        }

        public bool CheckCollision(Point newHead)
        {
            if (newHead.X < 0 || newHead.X >= fieldWidth ||
                newHead.Y < 0 || newHead.Y >= fieldHeight)
            {
                return true;
            }


            SnakeNode current = Snake.Head;

            while (current != null)
            {
                if (newHead == current.Position && current != Snake.Tail)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void HandleInput(Keys key)
        {
            if (!canChangeDirection) return;

            switch (key)
            {
                case Keys.Left:
                case Keys.A:
                    if (dirX != 1) { dirX = -1; dirY = 0; canChangeDirection = false; }
                    break;

                case Keys.Right:
                case Keys.D:
                    if (dirX != -1) { dirX = 1; dirY = 0; canChangeDirection = false; }
                    break;

                case Keys.Up:
                case Keys.W:
                    if (dirY != 1) { dirX = 0; dirY = -1; canChangeDirection = false; }
                    break;

                case Keys.Down:
                case Keys.S:
                    if (dirY != -1) { dirX = 0; dirY = 1; canChangeDirection = false; }
                    break;
            }
        }
    }
}
