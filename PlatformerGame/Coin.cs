using PlatformerGame.Properties;
using System.Drawing;

namespace PlatformerGame
{
    public class Coin
    {
        //Rectangles
        public Rectangle firstCoinDisplayArea;
        public Rectangle secondCoinDisplayArea;
        public Rectangle thirdCoinDisplayArea;
        public Rectangle fourthCoinDisplayArea;
        public Rectangle fifthCoinDisplayArea;

        //Image Controls
        Image coin = Resources.coin;

        //Constructor
        public Coin(Rectangle rectangle)
        {
            firstCoinDisplayArea = new Rectangle(520, 555, 20, 20);
            secondCoinDisplayArea = new Rectangle(745, 555, 20, 20);
            thirdCoinDisplayArea = new Rectangle(675, 295, 20, 20);
            fourthCoinDisplayArea = new Rectangle(855, 295, 20, 20);
            fifthCoinDisplayArea = new Rectangle(160, 170, 20, 20);
        }

        //Resets Coin Position
        public void Reset()
        {
            firstCoinDisplayArea.X = 520;

            firstCoinDisplayArea.Y = 555;

            secondCoinDisplayArea.X = 745;

            secondCoinDisplayArea.Y = 555;

            thirdCoinDisplayArea.X = 675;

            thirdCoinDisplayArea.Y = 295;

            fourthCoinDisplayArea.X = 855;

            fourthCoinDisplayArea.Y = 295;
        }

        // Draw
        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(coin, firstCoinDisplayArea);
            graphics.DrawImage(coin, secondCoinDisplayArea);
            graphics.DrawImage(coin, thirdCoinDisplayArea);
            graphics.DrawImage(coin, fourthCoinDisplayArea);
            graphics.DrawImage(coin, fifthCoinDisplayArea);
        }
    }
}
