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
            this.Wall1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lose = new System.Windows.Forms.Label();
            this.Walll5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall8 = new System.Windows.Forms.FlowLayoutPanel();
            this.Walll7 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall9 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall10 = new System.Windows.Forms.FlowLayoutPanel();
            this.Wall11 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy7 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy8 = new System.Windows.Forms.FlowLayoutPanel();
            this.Enemy9 = new System.Windows.Forms.FlowLayoutPanel();
            this.Boss = new System.Windows.Forms.FlowLayoutPanel();
            this.Timer = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.Label();
            this.Wall4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.DarkRed;
            this.Wall1.Location = new System.Drawing.Point(92, 2);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(48, 335);
            this.Wall1.TabIndex = 0;
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.DarkRed;
            this.Wall2.Location = new System.Drawing.Point(196, 280);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(50, 178);
            this.Wall2.TabIndex = 1;
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.Color.DarkRed;
            this.Wall3.Location = new System.Drawing.Point(196, 53);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(50, 164);
            this.Wall3.TabIndex = 2;
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.DarkRed;
            this.Wall4.Controls.Add(this.label1);
            this.Wall4.Location = new System.Drawing.Point(294, 2);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(29, 278);
            this.Wall4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Lose
            // 
            this.Lose.BackColor = System.Drawing.Color.Yellow;
            this.Lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lose.ForeColor = System.Drawing.Color.Maroon;
            this.Lose.Location = new System.Drawing.Point(190, 153);
            this.Lose.Name = "Lose";
            this.Lose.Size = new System.Drawing.Size(403, 89);
            this.Lose.TabIndex = 1;
            this.Lose.Text = "You LOSE!";
            this.Lose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lose.Visible = false;
            // 
            // Walll5
            // 
            this.Walll5.BackColor = System.Drawing.Color.DarkRed;
            this.Walll5.Location = new System.Drawing.Point(372, 303);
            this.Walll5.Name = "Walll5";
            this.Walll5.Size = new System.Drawing.Size(57, 145);
            this.Walll5.TabIndex = 4;
            // 
            // Wall6
            // 
            this.Wall6.BackColor = System.Drawing.Color.DarkRed;
            this.Wall6.Location = new System.Drawing.Point(376, 53);
            this.Wall6.Name = "Wall6";
            this.Wall6.Size = new System.Drawing.Size(52, 189);
            this.Wall6.TabIndex = 5;
            // 
            // Wall8
            // 
            this.Wall8.BackColor = System.Drawing.Color.DarkRed;
            this.Wall8.Location = new System.Drawing.Point(481, 0);
            this.Wall8.Name = "Wall8";
            this.Wall8.Size = new System.Drawing.Size(53, 140);
            this.Wall8.TabIndex = 6;
            // 
            // Walll7
            // 
            this.Walll7.BackColor = System.Drawing.Color.DarkRed;
            this.Walll7.Location = new System.Drawing.Point(481, 223);
            this.Walll7.Name = "Walll7";
            this.Walll7.Size = new System.Drawing.Size(52, 224);
            this.Walll7.TabIndex = 7;
            // 
            // Wall9
            // 
            this.Wall9.BackColor = System.Drawing.Color.DarkRed;
            this.Wall9.Location = new System.Drawing.Point(587, 241);
            this.Wall9.Name = "Wall9";
            this.Wall9.Size = new System.Drawing.Size(58, 207);
            this.Wall9.TabIndex = 8;
            // 
            // Wall10
            // 
            this.Wall10.BackColor = System.Drawing.Color.DarkRed;
            this.Wall10.Location = new System.Drawing.Point(585, 116);
            this.Wall10.Name = "Wall10";
            this.Wall10.Size = new System.Drawing.Size(59, 61);
            this.Wall10.TabIndex = 9;
            // 
            // Wall11
            // 
            this.Wall11.BackColor = System.Drawing.Color.DarkRed;
            this.Wall11.Location = new System.Drawing.Point(583, 0);
            this.Wall11.Name = "Wall11";
            this.Wall11.Size = new System.Drawing.Size(60, 69);
            this.Wall11.TabIndex = 10;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Red;
            this.Enemy1.Location = new System.Drawing.Point(254, 257);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(15, 23);
            this.Enemy1.TabIndex = 11;
            this.Enemy1.Visible = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Red;
            this.Enemy2.Location = new System.Drawing.Point(253, 2);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(16, 25);
            this.Enemy2.TabIndex = 12;
            this.Enemy2.Visible = false;
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Red;
            this.Enemy3.Location = new System.Drawing.Point(316, 420);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(35, 16);
            this.Enemy3.TabIndex = 13;
            this.Enemy3.Visible = false;
            // 
            // Enemy4
            // 
            this.Enemy4.BackColor = System.Drawing.Color.Red;
            this.Enemy4.Location = new System.Drawing.Point(440, 195);
            this.Enemy4.Name = "Enemy4";
            this.Enemy4.Size = new System.Drawing.Size(19, 33);
            this.Enemy4.TabIndex = 14;
            this.Enemy4.Visible = false;
            // 
            // Enemy6
            // 
            this.Enemy6.BackColor = System.Drawing.Color.Red;
            this.Enemy6.Location = new System.Drawing.Point(440, 10);
            this.Enemy6.Name = "Enemy6";
            this.Enemy6.Size = new System.Drawing.Size(19, 17);
            this.Enemy6.TabIndex = 15;
            this.Enemy6.Visible = false;
            // 
            // Enemy5
            // 
            this.Enemy5.BackColor = System.Drawing.Color.Red;
            this.Enemy5.Location = new System.Drawing.Point(439, 51);
            this.Enemy5.Name = "Enemy5";
            this.Enemy5.Size = new System.Drawing.Size(19, 17);
            this.Enemy5.TabIndex = 16;
            this.Enemy5.Visible = false;
            // 
            // Enemy7
            // 
            this.Enemy7.BackColor = System.Drawing.Color.Red;
            this.Enemy7.Location = new System.Drawing.Point(552, 115);
            this.Enemy7.Name = "Enemy7";
            this.Enemy7.Size = new System.Drawing.Size(22, 50);
            this.Enemy7.TabIndex = 17;
            this.Enemy7.Visible = false;
            // 
            // Enemy8
            // 
            this.Enemy8.BackColor = System.Drawing.Color.Red;
            this.Enemy8.Location = new System.Drawing.Point(680, 243);
            this.Enemy8.Name = "Enemy8";
            this.Enemy8.Size = new System.Drawing.Size(23, 37);
            this.Enemy8.TabIndex = 18;
            this.Enemy8.Visible = false;
            // 
            // Enemy9
            // 
            this.Enemy9.BackColor = System.Drawing.Color.Red;
            this.Enemy9.Location = new System.Drawing.Point(675, 33);
            this.Enemy9.Name = "Enemy9";
            this.Enemy9.Size = new System.Drawing.Size(17, 34);
            this.Enemy9.TabIndex = 19;
            this.Enemy9.Visible = false;
            // 
            // Boss
            // 
            this.Boss.BackColor = System.Drawing.Color.Red;
            this.Boss.Location = new System.Drawing.Point(738, 93);
            this.Boss.Name = "Boss";
            this.Boss.Size = new System.Drawing.Size(43, 46);
            this.Boss.TabIndex = 20;
            this.Boss.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(12, 415);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(40, 21);
            this.Timer.TabIndex = 22;
            this.Timer.Text = "Start";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.MediumBlue;
            this.Character.Location = new System.Drawing.Point(17, 195);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(17, 34);
            this.Character.TabIndex = 23;
            this.Character.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Lose);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Boss);
            this.Controls.Add(this.Enemy9);
            this.Controls.Add(this.Enemy8);
            this.Controls.Add(this.Enemy7);
            this.Controls.Add(this.Enemy5);
            this.Controls.Add(this.Enemy6);
            this.Controls.Add(this.Enemy4);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Wall11);
            this.Controls.Add(this.Wall10);
            this.Controls.Add(this.Wall9);
            this.Controls.Add(this.Walll7);
            this.Controls.Add(this.Wall8);
            this.Controls.Add(this.Wall6);
            this.Controls.Add(this.Walll5);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall1);
            this.Name = "Form1";
            this.Text = "Taci_Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Wall4.ResumeLayout(false);
            this.Wall4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel Wall1;
        private System.Windows.Forms.FlowLayoutPanel Wall2;
        private System.Windows.Forms.FlowLayoutPanel Wall3;
        private System.Windows.Forms.FlowLayoutPanel Wall4;
        private System.Windows.Forms.FlowLayoutPanel Walll5;
        private System.Windows.Forms.FlowLayoutPanel Wall6;
        private System.Windows.Forms.FlowLayoutPanel Wall8;
        private System.Windows.Forms.FlowLayoutPanel Walll7;
        private System.Windows.Forms.FlowLayoutPanel Wall9;
        private System.Windows.Forms.FlowLayoutPanel Wall10;
        private System.Windows.Forms.FlowLayoutPanel Wall11;
        private System.Windows.Forms.FlowLayoutPanel Enemy1;
        private System.Windows.Forms.FlowLayoutPanel Enemy2;
        private System.Windows.Forms.FlowLayoutPanel Enemy3;
        private System.Windows.Forms.FlowLayoutPanel Enemy4;
        private System.Windows.Forms.FlowLayoutPanel Enemy6;
        private System.Windows.Forms.FlowLayoutPanel Enemy5;
        private System.Windows.Forms.FlowLayoutPanel Enemy7;
        private System.Windows.Forms.FlowLayoutPanel Enemy8;
        private System.Windows.Forms.FlowLayoutPanel Enemy9;
        private System.Windows.Forms.FlowLayoutPanel Boss;
        private System.Windows.Forms.Label Timer;
        private Label Character;
        private Label label1;
        private Label Lose;
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