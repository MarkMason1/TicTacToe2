using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int turn = 1;
        public Form1()
        {
            InitializeComponent();
            
        }
       
        public void Turn()
        {
            if (turn% 2 == 0)
            {
                Text = $"Turn: player: 1(X)";
                
            }
            else
            {
                Text = $"Turn: player: 2(O)";
                

            }
        }
        public void check()
        {
            Turn();
            if ((B1.Text == B2.Text && B2.Text == B3.Text) 
                || (B1.Text == B5.Text && B5.Text == B9.Text) 
                || (B1.Text == B4.Text && B7.Text == B4.Text))
            {
                if (turn % 2 == 0)
                {
                    MessageBox.Show("Player 2 WINS!!!!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Player 1 WINS!!!!");
                    Application.Restart();
                }
                

            }
            
        }
        private void B1_Click(object sender, EventArgs e)
        {
            if(turn % 2 != 0)
            {
                B1.Text = "X";
                B1.Enabled = false;

                check();
            }
            else
            {
                B1.Text = "O";
                B1.Enabled = false;
                check();

            }
            turn++;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B2.Text = "X";
                B2.Enabled = false;
                check();

            }
            else
            {
                B2.Text = "O";
                B2.Enabled = false;
                check();
            }
            turn++;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B3.Text = "X";
                B3.Enabled = false;
                check();
            }
            else
            {
                B3.Text = "O";
                B3.Enabled = false;
                check();
            }
            turn++;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B4.Text = "X";
                B4.Enabled = false;
                check();
            }
            else
            {
                B4.Text = "O";
                B4.Enabled = false;
                check();
            }
            turn++;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B5.Text = "X";
                B5.Enabled = false;
                check();
            }
            else
            {
                B5.Text = "O";
                B5.Enabled = false;
                check();
            }
            turn++;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B6.Text = "X";
                B6.Enabled = false;
                check();
            }
            else
            {
                B6.Text = "O";
                B6.Enabled = false;
                check();
            }
            turn++;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B7.Text = "X";
                B7.Enabled = false;
                check();
            }
            else
            {
                B7.Text = "O";
                B7.Enabled = false;
                check();
            }
            turn++;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B8.Text = "X";
                B8.Enabled = false;
                check();
            }
            else
            {
                B8.Text = "O";
                B8.Enabled = false;
                check();
            }
            turn++;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0)
            {
                B9.Text = "X";
                B9.Enabled = false;
                check();
            }
            else
            {
                B9.Text = "O";
                B9.Enabled = false;
                check();
            }
            turn++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
