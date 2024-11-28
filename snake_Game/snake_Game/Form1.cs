using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_Game
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public Form1()
        {
            InitializeComponent();

            new settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && settings.directions != "right")
            {
                goLeft = true;

            }

            if (e.KeyCode == Keys.Right && settings.directions !="left" )
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && settings.directions !="down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && settings.directions !="up")
            {
                goDown = true;
            }
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void startGame(object sender, EventArgs e)
        {

        }

        private void TakeaSnap(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                settings.directions = "left";

            }
            if (goRight)
            {
                settings.directions = "right";
            }
            if (goDown)
            {
                settings.directions = "down";

            }
            if (goUp)
            {
                settings.directions = "up";
            }
            for (int i = Snake.Count - 1 ; i>= 0 ; i--)
            {
                if (i == 0)
                {
                    switch (settings.directions)
                    {
                        case "left":
                            Snake[i].Y--;
                            break;
                        case "right":
                            Snake[i].Y++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;

                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                        
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            camSnake.Invalidate();
            {

            }
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i ==0)
                {
                    snakeColour = Brushes.Black;

                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * settings.Width,
                    Snake[i].Y * settings.Height,
                    settings.Width, settings.Height


                    ));
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                   (
                   food.X * settings.Width,
                   food.Y * settings.Height,
                   settings.Width, settings.Height


                   ));




        }
        private void RestartGame()
        {

            maxWidth = camSnake.Width / settings.Width - 1;
            maxHeight = camSnake.Height / settings.Height - 1;

            Snake.Clear();

            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            currentScore.Text = "Score : " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();
        }

        private void EatFood()
        {

        }
        private void GameOver()
        {

        }
    }
}
