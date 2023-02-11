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
        int gravity = 7;
        int score = 0;
        
        int character_health = 10;
        /*
        int small_enemy_health = 1;
        int medium_enemy_health = 2;
        int large_enemy_health = 5;
        int boss_health = 7; */
        //

        //fields for enemies movement
        private int step = 4, minY = 215, maxY = 272;
        //

        //fields for checking the character movement

        //

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
          //  Character.Location = new System.Drawing.Point(20, 152);         
        }
       

        public void Taci_Start()
        {
            //enable the components
            
            Character.Visible = true;
            Enemy.Visible = true;
          
        }

        public void Taci_Stop()
        {
            button1.Visible = true;
            Lose.Text = "Your score is " + score;
            Lose.Visible = true;
            Timer.Visible = false;
            Character.Visible = false;
            timer1.Stop();
            Score.Visible = false;
        }

        private void Bound()
        {
            if (Character.Bounds.IntersectsWith(Wall1.Bounds))
            {
                Taci_Stop();

            }
            if (Character.Bounds.IntersectsWith(Wall2.Bounds))
            {
                Taci_Stop();

            }
            if (Character.Bounds.IntersectsWith(Wall3.Bounds))
            {
                Taci_Stop();

            }
            if (Character.Bounds.IntersectsWith(Wall4.Bounds))
            {
                Taci_Stop();

            }
            if(Character.Bounds.IntersectsWith(Enemy.Bounds))
            {
                character_health--;
                if(character_health == 0)
                {
                    Taci_Stop();                   
                }
            }
            if (Character.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                character_health--;
                if (character_health == 0)
                {
                    Taci_Stop();
                }
            }

        }

        private void Replace()
        {
            if (Wall1.Left < -115)
            {
                Wall1.Left = 365;
            }
            if (Wall2.Left < -115)
            {

                Wall2.Left = 380;
            }
            if (Wall3.Left < -115)
            {

                Wall3.Left = 400;
            }
            if (Wall4.Left < -115)
            {

                Wall4.Left = 425;
            }
            if (Enemy.Left < -100)
            {
                Enemy.Left = random.Next(362, 385);
                Enemy.Top = random.Next(187, 203);
            }

            if (Enemy1.Left < -100)
            {
                Enemy1.Left = random.Next(362, 385);
                Enemy1.Top = random.Next(187, 203);
            }
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Taci_Start();
            Timer.Visible = false;
            Score.Visible = true; 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            //To count the score
            score++;

            //show the score
            Score.Text = score.ToString();

            //default object movement          

            Character.Top += gravity;         
            Wall1.Left -= 3;
            Wall2.Left -= 3;
            Wall3.Left -= 3;
            Wall4.Left -= 3;
            Enemy.Left -= 8;
            Enemy1.Left -= 5;
          

            //if the character hit the walls and enemy
            Bound();

            //if the walls and enemy have been passed, It loops again.
            Replace();

            if(Character.Top < 0)
            {
                button1.Visible = true;
                Lose.Text = "Game over";
                Lose.Visible = true;
                timer1.Stop();
            }
            
            if(Character.Top > 492)
            {
                button1.Visible = true;
                Lose.Text = "Game over";
                Lose.Visible = true;
                timer1.Stop();
            }
            


        }

        private void Shoot_Press(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Start_Enter(object sender, KeyEventArgs e)
        {
            timer1.Start();
            Taci_Start();
            Timer.Visible = false;
            Score.Visible = true;
        }

        //To check whether the key is pressed
        private void Char_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                gravity = -3;
            }

            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
                Taci_Start();
                Timer.Visible = false;
                Score.Visible = true;
            }



        }

        private void Char_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                gravity = 3;
            }
        }          
            //ends here
        
    }
}
