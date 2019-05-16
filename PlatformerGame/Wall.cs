using PlatformerGame.Properties;
using System.Drawing;

namespace PlatformerGame
{
    public class Wall
    {
        //Rectangles
        public Rectangle wallLeftDisplayArea;
        public Rectangle wallRightDisplayArea;

        //Image File
        Image floor = Resources.floor;

        //Constructor
        public Wall(Rectangle rectangle)
        {
            wallRightDisplayArea = new Rectangle(1040, 120, 31, 680);
            wallLeftDisplayArea = new Rectangle(118, 120, 31, 680);
        }

        //Draw
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(floor, wallRightDisplayArea);
            graphics.DrawImage(floor, wallLeftDisplayArea);
        }
    }
}
