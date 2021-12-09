using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeGame
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        new Rectangle player = new Rectangle(40, 300, 20, 20);
        int playerSpeed = 10;

        List<Rectangle> leftEnemies = new List<Rectangle>(); //(60, 0, 15, 60);
        List<Rectangle> rightEnemies = new List<Rectangle>(); //(0,0,30,90); // (360, this.height - obstacleHeight, 15, 60);
        int obstacleHeight = 60;

        int leftSpeed = 8;
        int rightSpeed = 8;
        int leftCounter;
        int rightCounter;

        bool leftDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool downDown = false;

        SolidBrush goldBrush = new SolidBrush(Color.Gold);
        SolidBrush whiteBrush = new SolidBrush(Color.White);





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
            }
        }

            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //move player
            if (rightDown == true)
            {
                player.X += playerSpeed;
            }

            if (leftDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }
            if (upDown == true && player.Y > 0)
            {
                player.Y -= playerSpeed;
            }
            if (downDown == true)
            {
                player.Y += playerSpeed;
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, player);
        }
    }
}
