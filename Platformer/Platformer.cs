using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Platformer : Form
    {
        bool right, left;
        bool jump;
        int G = 30;
        int Force;
         
        public Platformer()
        {
            InitializeComponent();

            player.Top = screen.Height - player.Height; //sets player start position
        }

        private void Platformer_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. side collision
            if (player.Right > Block.Left && player.Left < Block.Right - player.Width && player.Bottom < Block.Bottom && player.Bottom > Block.Top )
            {
                right = false;
            }

            if (player.Left < Block.Right && player.Right > Block.Left + player.Width && player.Bottom < Block.Bottom && player.Bottom > Block.Top)
            {
                left = false;
            }

            //////
            // 2. 
            if (right == true) 
            {
                player.Left += 3;
            }

            if (left == true)
            {
                player.Left -= 3;
            }

            if (jump == true)
            {
                //falling (if the player has jumped before)
                player.Top -= Force;
                Force -= 1; 
            }

            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; //stop falling at bottom 
                jump = false;
            }
            else
            {
                player.Top += 5; //Falling
            }

            //3. top collision
            if (player.Left + player.Width > Block.Left && player.Left + player.Width < Block.Left + Block.Width+ player.Width && player.Top + player.Height >= Block.Top && player.Top < Block.Top)
            {
                jump = false;
                Force = 0;
                player.Top = Block.Location.Y - player.Height;
            }
            //simple fall for now
            if (!(player.Left + player.Width > Block.Left && player.Left + player.Width < Block.Left + Block.Width + player.Width) && player.Top + player.Height >= Block.Top && player.Top < Block.Top)
            {
                jump = true;
            }


            //head collision
             
            if (player.Left + player.Width > Block.Left && player.Left + player.Width < Block.Left + Block.Width + player.Width && player.Top - Block.Bottom <= 10 && player.Top - Block.Top > -10)
            {
                Force = -1;
            }
            //////
        }

        private void Platformer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true; 
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true; 
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();  //Escape -> Exit
            }


            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }
        }
        private void Platformer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }
    }
}
