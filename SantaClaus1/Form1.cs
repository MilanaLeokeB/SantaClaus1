using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaClaus1
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int Speed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            Moon.Left -= Speed;
            White.Left -= Speed;
            Tree.Left -= Speed;
            House.Left -= Speed;
            Scorel.Text = $"score:{score}";

            if(Moon.Left < -150)
            {
                Moon.Left = 1100;
                score++;
            }

            if (White.Left < -100)
            {
                White.Left = 1400;
                score++;
            }

            if (Tree.Left < -150)
            {
                Tree.Left = 1100;
                score++;
            }

            if (House.Left < -100)
            {
                House.Left = 1400;
                score++;
            }

            if (Santa.Bounds.IntersectsWith(Moon.Bounds) || Santa.Bounds.IntersectsWith(Tree.Bounds) || Santa.Bounds.IntersectsWith(White.Bounds) || Santa.Bounds.IntersectsWith(House.Bounds) || Santa.Bounds.IntersectsWith(Ground.Bounds))

            {
                GameOver();
            }

            if (Santa.Top < -25)
            {
                GameOver();   
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            Scorel.Text = $"Game Over!";
            Button.Visible = true;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false); 
        }
    }
}
