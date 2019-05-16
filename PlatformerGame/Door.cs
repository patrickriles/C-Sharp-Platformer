using PlatformerGame.Properties;
using System.Drawing;

namespace PlatformerGame
{
    public class Door
    {
        //Rectangles
        public Rectangle doorDisplayArea;
        public Rectangle winnerDisplayArea;

        //Image Files
        Image door = Resources.door;
        Image winner = Resources.winner;

        //Constructor
        public Door(Rectangle rectangle)
        {
            doorDisplayArea = new Rectangle(-100, 0, 60, 90);
            winnerDisplayArea = new Rectangle(1500, 0, 700, 200);
        }

        //Draw
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(door, doorDisplayArea);
            graphics.DrawImage(winner, winnerDisplayArea);
        }
    }
}
