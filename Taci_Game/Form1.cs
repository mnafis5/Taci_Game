using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taci_Game
{
    public partial class Form1 : Form
    {
        //count down : 3 minutes
        int count = 3 * 60;
        
        public Form1()
        {
            InitializeComponent();
            Character.Location = new System.Drawing.Point(26, 152);
        }

        public void Character_Behavior(object sender, EventArgs e)
        {
            
        }

        public void Taci_Start()
        {
            //enable the components
            Character.Visible= true;
            Enemy1.Visible= true;
            Enemy2.Visible= true;
            Enemy3.Visible= true;
            Enemy4.Visible= true;
            Enemy5.Visible= true;
            Enemy6.Visible= true;
            Enemy7.Visible= true;
            Enemy8.Visible= true;
            Enemy9.Visible= true;
            Boss.Visible= true;
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Taci_Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //decrease count everytime the time ticks
            count--;
            //show the the time
            Timer.Text = count.ToString();
            //To check if the time is up
            if(count == 0)
            {
                //if true, stop it
                timer1.Stop();
                Timer.Visible = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             //
            //Moving the main character
           //
            Point currentLocationObject = Character.Location;
            Point currentLocationWall1 = Wall1.Location;
            if(e.KeyCode == Keys.Up)
            {
                currentLocationObject.Y -= 3;
                Character.Location = currentLocationObject;
            }else if(e.KeyCode == Keys.Down)
            {
                currentLocationObject.Y += 3;
                Character.Location = currentLocationObject;
            }else if(e.KeyCode== Keys.Left)
            {
                currentLocationObject.X -= 3;
                Character.Location = currentLocationObject;
            }else if(e.KeyCode == Keys.Right)
            {
                currentLocationObject.X += 3;
                Character.Location = currentLocationObject;
            }
            //ends here
            //
            //
            //check if the character crashes the wall
            //
            if (Character.Bounds.IntersectsWith(Wall1.Bounds))
            {
                Lose.Visible = true;
                timer1.Stop();
                Timer.Visible = false;
                Character.Visible = false;
            }
        }

        
    }
}
