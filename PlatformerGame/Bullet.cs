using PlatformerGame.Properties;
using System.Drawing;

namespace PlatformerGame
{
    public class Bullet
    {
        //Rectangles
        public Rectangle firstBulletDisplayArea;
        public Rectangle secondBulletDisplayArea;
        public Rectangle thirdBulletDisplayArea;
        public Rectangle fourthBulletDisplayArea;


        //Image file
        Image bullet = Resources.bullet;

        //Constructor
        public Bullet(Rectangle rectangle)
        {
            firstBulletDisplayArea = new Rectangle(150, 620, 15, 15);
            secondBulletDisplayArea = new Rectangle(1025, 490, 15, 15);
            thirdBulletDisplayArea = new Rectangle(150, 360, 15, 15);
            fourthBulletDisplayArea = new Rectangle(1025, 230, 15, 15);
        }

        //Move Method
        public void Move()
        {
            firstBulletDisplayArea.X += 5;
            secondBulletDisplayArea.X -= 5;
            thirdBulletDisplayArea.X += 5;
            fourthBulletDisplayArea.X -= 5;
        }

        //Draw
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(bullet, firstBulletDisplayArea);
            graphics.DrawImage(bullet, secondBulletDisplayArea);
            graphics.DrawImage(bullet, thirdBulletDisplayArea);
            graphics.DrawImage(bullet, fourthBulletDisplayArea);
        }
    }
}

