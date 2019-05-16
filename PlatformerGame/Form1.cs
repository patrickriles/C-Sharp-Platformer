using System;
using System.Windows.Forms;

namespace PlatformerGame
{
    public partial class Form1 : Form
    {

        //Objects
        private Player player;
        private Platform platforms;
        private Wall walls;
        private Coin coins;
        private Ladder ladder;
        private Bullet bullet;
        private Door door;

        //Music & Sounds
        private MciPlayer music = new MciPlayer("music.wav", "1");
        private MciPlayer jump = new MciPlayer("jump.wav", "2");
        private MciPlayer coin = new MciPlayer("coin.wav", "3");
        private MciPlayer dead = new MciPlayer("death.wav", "4");
        private MciPlayer winner = new MciPlayer("winner.wav", "5");

        //Variables
        int fallSpeed = 2;
        int score = 0;
        bool isClimbing = false;
        bool isFalling = true;
        bool isJumping = false;

        public Form1()
        {
            this.DoubleBuffered = true; // Enable Double Buffering to reduce flickering
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set Scorebox to 0
            scoreBox.Text = (score).ToString();

            //Play Music
            music.PlayFromStart();

            //Initialize objects
            this.player = new Player(this.DisplayRectangle);
            this.platforms = new Platform(this.DisplayRectangle);
            this.walls = new Wall(this.DisplayRectangle);
            this.coins = new Coin(this.DisplayRectangle);
            this.ladder = new Ladder(this.DisplayRectangle);
            this.bullet = new Bullet(this.DisplayRectangle);
            this.door = new Door(this.DisplayRectangle);
        }

        //Timer
        private void playTimer(object sender, EventArgs e)
        {

            bullet.Move(); //shoots bullets
            Invalidate(); //Keeps sprites updated
            isClimbing = false;

            //Gravity

            if(isFalling)
            {
                player.Gravity(fallSpeed);
            }

            //End gravity


            //Collision

            //Wall Collision

            if (player.displayArea.IntersectsWith(walls.wallLeftDisplayArea))
            {
                player.Move(Player.Direction.Right);

            }

            if(player.displayArea.IntersectsWith(walls.wallRightDisplayArea))
            {
                player.Move(Player.Direction.Left);

            }
            
            //End Wall Collision
            
            //Platform Collision

            if (player.displayArea.IntersectsWith(platforms.firstFloorDisplayArea) || player.displayArea.IntersectsWith(platforms.secondFloorDisplayArea) 
            || player.displayArea.IntersectsWith(platforms.thirdFloorDisplayArea) || player.displayArea.IntersectsWith(platforms.fourthFloorDisplayArea)
            || player.displayArea.IntersectsWith(platforms.fifthFloorDisplayArea) || player.displayArea.IntersectsWith(platforms.sixthFloorDisplayArea))
            {

                isFalling = false;
                isJumping = false;
                isClimbing = false;

            } else { isFalling = true; }

            //End Platform Collision

            
            if (player.displayArea.IntersectsWith(ladder.ladderFirstDisplayArea))
            {
                isClimbing = true;
                isFalling = false;
            }

            if (player.displayArea.IntersectsWith(ladder.ladderSecondDisplayArea))
            {
                isClimbing = true;
                isFalling = false;
            }

            if (player.displayArea.IntersectsWith(ladder.ladderThirdDisplayArea))
            {
                isClimbing = true;
                isFalling = false;
            }

            if (player.displayArea.IntersectsWith(ladder.ladderFourthDisplayArea))
            {
                isClimbing = true;
                isFalling = false;
            }


            //Player Killed

            if (player.displayArea.IntersectsWith(bullet.firstBulletDisplayArea))
            {
                Reset();
            }

            if (player.displayArea.IntersectsWith(bullet.secondBulletDisplayArea))
            {
                Reset();
            }

            if (player.displayArea.IntersectsWith(bullet.thirdBulletDisplayArea))
            {
                Reset();
            }

            if (player.displayArea.IntersectsWith(bullet.fourthBulletDisplayArea))
            {
                Reset();
            }

            //End Player killed
            

            //Bullet Reset

            if(bullet.firstBulletDisplayArea.IntersectsWith(walls.wallRightDisplayArea))
            {
                bullet.firstBulletDisplayArea.X = 150;
            }

            if (bullet.secondBulletDisplayArea.IntersectsWith(walls.wallLeftDisplayArea))
            {
                bullet.secondBulletDisplayArea.X = 1025;
            }

            if (bullet.thirdBulletDisplayArea.IntersectsWith(walls.wallRightDisplayArea))
            {
                bullet.thirdBulletDisplayArea.X = 150;
            }

            if (bullet.fourthBulletDisplayArea.IntersectsWith(walls.wallLeftDisplayArea))
            {
                bullet.fourthBulletDisplayArea.X = 1025;
            }

            //End Bullet Reset
            
            //End Collision


            //Score System

            if (player.displayArea.IntersectsWith(coins.firstCoinDisplayArea))
            {

                coins.firstCoinDisplayArea.Y -= 1000;
                score += 1;
                coin.PlayFromStart();
                scoreBox.Text = (score).ToString();
            }

            if (player.displayArea.IntersectsWith(coins.secondCoinDisplayArea))
            {
                coins.secondCoinDisplayArea.Y -= 1000;
                score += 1;
                coin.PlayFromStart();
                scoreBox.Text = (score).ToString();
            }

            if (player.displayArea.IntersectsWith(coins.thirdCoinDisplayArea))
            {
                coins.thirdCoinDisplayArea.Y -= 1000;
                score += 1;
                coin.PlayFromStart();
                scoreBox.Text = (score).ToString();
            }

            if (player.displayArea.IntersectsWith(coins.fourthCoinDisplayArea))
            {
                coins.fourthCoinDisplayArea.Y -= 1000;
                score += 1;
                coin.PlayFromStart();
                scoreBox.Text = (score).ToString();
            }

            if (player.displayArea.IntersectsWith(coins.fifthCoinDisplayArea))
            {
                coins.fifthCoinDisplayArea.Y -= 1000;
                score += 1;
                coin.PlayFromStart();
                scoreBox.Text = (score).ToString();
            }

            if (score == 5)
            {

                music.PlayFromStart();
                door.doorDisplayArea.X = 800;
                door.doorDisplayArea.Y = 678;
            }

            //End Score System


            //Win

            if(player.displayArea.IntersectsWith(door.doorDisplayArea))
            {
                music.StopPlaying();
                winner.PlayFromStart();
                player.displayArea.X = 1500;
                door.winnerDisplayArea.Y = 350;
                door.winnerDisplayArea.X = 250;

            }


            //End Win
        }

        //Controls
        private void KeyIsDown(object sender, KeyEventArgs e)
            {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!isFalling)
                    {
                        player.Move(Player.Direction.Left); 
                    }

                    break;

                case Keys.Right:
                    if(!isFalling)
                    {
                        player.Move(Player.Direction.Right);
                    }

                    break;

                case Keys.Space:
                    if (!isFalling && !isClimbing)
                    {
                        jump.PlayFromStart();
                        isJumping = true;
                        isFalling = true;
                        player.Move(Player.Direction.Jump);
                    }
                    break;

                case Keys.Up:
                    if (isClimbing)
                    {
                        isJumping = true;
                        player.Move(Player.Direction.Up);
                    }
                    break;
                case Keys.Down:
                    if (isClimbing && !player.displayArea.IntersectsWith(platforms.firstFloorDisplayArea) && !player.displayArea.IntersectsWith(platforms.secondFloorDisplayArea)
                        && !player.displayArea.IntersectsWith(platforms.thirdFloorDisplayArea) && !player.displayArea.IntersectsWith(platforms.fourthFloorDisplayArea))
                    {
                        isJumping = true;
                        player.Move(Player.Direction.Down);
                    }
                    break;
                case Keys.R:
                    {
                        Reset();
                        break;
                    }
                }
            }

        //Paint method for drawing objects to the screen
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw Floors
            platforms.Draw(e.Graphics);

            //Draw Walls
            walls.Draw(e.Graphics);

            //Draw Coins
            coins.Draw(e.Graphics);

            //Draw Ladders
            ladder.Draw(e.Graphics);

            //Draw Bullets
            bullet.Draw(e.Graphics);

            //Draw Door and Winner
            door.Draw(e.Graphics);

            //Draw Player
            player.Draw(e.Graphics);
        }

        //Reset Method
        private void Reset()
        {
            player.displayArea.X = 965;
            player.displayArea.Y = 700;

            door.doorDisplayArea.X = -100;
            door.doorDisplayArea.Y = 0;

            door.winnerDisplayArea.Y = 1500;
            door.winnerDisplayArea.X = 0;

            coins.Reset();
            music.PlayFromStart();
            score = 0;
            scoreBox.Text = (score).ToString();
        }
    }
}
