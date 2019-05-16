using PlatformerGame.Properties;
using System.Drawing;


namespace PlatformerGame
{
    public class Player
    {
        //Rectangles
        public Rectangle displayArea;

        //variables
        private readonly int xVelocity = 5;
        private readonly int yVelocity = 42;
        private readonly int climbSpeed = 20;
        public enum Direction { Left, Right, Jump, Up, Down }

        //Image File
        Image player = Resources.bob_right;

        //Constructor
        public Player(Rectangle rectangle)
        {
            this.displayArea.Width = 31;
            this.displayArea.Height = 55;
            // Set the player at start of level
            this.displayArea.Y = 700;
            this.displayArea.X = 965;
        }

        //Gravity Method
        public void Gravity(int fallSpeed)
        {
            displayArea.Y += fallSpeed; 
        }

        // Move switch
        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Left:
                    {
                        displayArea.X -= xVelocity;
                        break;
                    }
                case Direction.Right:
                    {
                        displayArea.X += xVelocity;
                        break;
                    }
                case Direction.Up:
                    {
                        displayArea.Y -= climbSpeed;
                        break;
                    }
                case Direction.Down:
                    {
                        displayArea.Y += climbSpeed;
                        break;
                    }
                case Direction.Jump:
                    {
                        displayArea.Y -= yVelocity;
                        break;
                    }
            }
        }

        //Draw
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(player, displayArea);
        }
    }
}
