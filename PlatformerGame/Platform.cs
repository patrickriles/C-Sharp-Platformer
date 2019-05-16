using PlatformerGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerGame
{
    public class Platform
    {
        //Rectangles
        public Rectangle firstFloorDisplayArea;
        public Rectangle secondFloorDisplayArea;
        public Rectangle thirdFloorDisplayArea;
        public Rectangle fourthFloorDisplayArea;
        public Rectangle fifthFloorDisplayArea;
        public Rectangle sixthFloorDisplayArea;

        //Image File
        Image floor = Resources.floor;

        //Constructor
        public Platform(Rectangle rectangle)
        {
            firstFloorDisplayArea = new Rectangle(146, 767, 900, 31);
            secondFloorDisplayArea = new Rectangle(215, 637, 856, 31);
            thirdFloorDisplayArea = new Rectangle(149, 507, 819, 31);
            fourthFloorDisplayArea = new Rectangle(215, 377, 856, 31);
            fifthFloorDisplayArea = new Rectangle(149, 247, 819, 31);
            sixthFloorDisplayArea = new Rectangle(146, 120, 900, 31);
        }

        //Draw
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(floor, firstFloorDisplayArea);
            graphics.DrawImage(floor, secondFloorDisplayArea);
            graphics.DrawImage(floor, thirdFloorDisplayArea);
            graphics.DrawImage(floor, fourthFloorDisplayArea);
            graphics.DrawImage(floor, fifthFloorDisplayArea);
            graphics.DrawImage(floor, sixthFloorDisplayArea);


        }

    }
}
