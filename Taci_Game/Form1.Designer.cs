using System.Windows.Forms;

namespace Taci_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lose = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Wall3 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lose
            // 
            this.Lose.BackColor = System.Drawing.Color.Yellow;
            this.Lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lose.ForeColor = System.Drawing.Color.Maroon;
            this.Lose.Location = new System.Drawing.Point(33, 210);
            this.Lose.Name = "Lose";
            this.Lose.Size = new System.Drawing.Size(448, 92);
            this.Lose.TabIndex = 1;
            this.Lose.Text = "You  LOSE!";
            this.Lose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lose.Visible = false;
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.Honeydew;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(12, 494);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(49, 23);
            this.Timer.TabIndex = 22;
            this.Timer.Text = "Start";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // Character
            // 
            this.Character.Image = ((System.Drawing.Image)(resources.GetObject("Character.Image")));
            this.Character.Location = new System.Drawing.Point(6, 163);
            this.Character.Margin = new System.Windows.Forms.Padding(0);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(46, 36);
            this.Character.TabIndex = 23;
            this.Character.TabStop = false;
            // 
            // Wall1
            // 
            this.Wall1.Image = ((System.Drawing.Image)(resources.GetObject("Wall1.Image")));
            this.Wall1.Location = new System.Drawing.Point(92, -1);
            this.Wall1.Margin = new System.Windows.Forms.Padding(0);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(123, 175);
            this.Wall1.TabIndex = 24;
            this.Wall1.TabStop = false;
            // 
            // Wall2
            // 
            this.Wall2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Wall2.ErrorImage")));
            this.Wall2.Image = ((System.Drawing.Image)(resources.GetObject("Wall2.Image")));
            this.Wall2.Location = new System.Drawing.Point(154, 350);
            this.Wall2.Margin = new System.Windows.Forms.Padding(0);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(120, 178);
            this.Wall2.TabIndex = 25;
            this.Wall2.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Image = ((System.Drawing.Image)(resources.GetObject("Enemy.Image")));
            this.Enemy.Location = new System.Drawing.Point(239, 187);
            this.Enemy.Margin = new System.Windows.Forms.Padding(0);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(45, 45);
            this.Enemy.TabIndex = 26;
            this.Enemy.TabStop = false;
            // 
            // Wall3
            // 
            this.Wall3.Image = ((System.Drawing.Image)(resources.GetObject("Wall3.Image")));
            this.Wall3.Location = new System.Drawing.Point(340, -1);
            this.Wall3.Margin = new System.Windows.Forms.Padding(0);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(120, 200);
            this.Wall3.TabIndex = 27;
            this.Wall3.TabStop = false;
            // 
            // Wall4
            // 
            this.Wall4.Image = ((System.Drawing.Image)(resources.GetObject("Wall4.Image")));
            this.Wall4.Location = new System.Drawing.Point(379, 326);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(116, 211);
            this.Wall4.TabIndex = 28;
            this.Wall4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(200, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "Try Again?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_Enter);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(2, 494);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(51, 19);
            this.Score.TabIndex = 30;
            this.Score.Text = "Score:";
            this.Score.Visible = false;
            // 
            // Enemy1
            // 
            this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
            this.Enemy1.Location = new System.Drawing.Point(634, 265);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(47, 42);
            this.Enemy1.TabIndex = 31;
            this.Enemy1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(493, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lose);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall1);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Timer);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Taci_Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Char_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Shoot_Press);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Char_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer;
        private Label Lose;
        private PictureBox Character;
        private PictureBox Wall1;
        private PictureBox Wall2;
        private PictureBox Enemy;
        private PictureBox Wall3;
        private PictureBox Wall4;
        private Button button1;
        private Label Score;
        private PictureBox Enemy1;
    }
}

namespace System
{
    class KeyEventHandler
    {
        private Action<object, KeyEventArgs> form1_KeyDown;

        public KeyEventHandler(Action<object, KeyEventArgs> form1_KeyDown)
        {
            this.form1_KeyDown = form1_KeyDown;
        }
    }
}