using PlatformerGame.Properties;
using System.Drawing;

namespace PlatformerGame
{
    public class Ladder
    {
        //Rectangles
        public Rectangle ladderFirstDisplayArea;
        public Rectangle ladderSecondDisplayArea;
        public Rectangle ladderThirdDisplayArea;
        public Rectangle ladderFourthDisplayArea;

        //Image File
        Image ladder = Resources.ladder;

        //Constructor
        public Ladder(Rectangle rectangle)
        {
            ladderFirstDisplayArea = new Rectangle(175, 635, 40, 115); ;
            ladderSecondDisplayArea = new Rectangle(965, 245, 40, 115); ;
            ladderThirdDisplayArea = new Rectangle(175, 375, 40, 115); ;
            ladderFourthDisplayArea = new Rectangle(965, 505, 40, 115); ;
        }

        //Draw
        public void Draw(Graphics graphics)
        {
            

            graphics.DrawImage(ladder, ladderFirstDisplayArea);
            graphics.DrawImage(ladder, ladderSecondDisplayArea);
            graphics.DrawImage(ladder, ladderThirdDisplayArea);
            graphics.DrawImage(ladder, ladderFourthDisplayArea);
        }
    }
}
