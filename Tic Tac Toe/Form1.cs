using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        String[] inboxes = { "X", "O" };

        int i = 0;
        int mousehover = 0;
        String turn = "X";

        int xnumberwins = 0;
        int onumberwins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        bool win()
        {
           if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
           {
                return true; 
           }
           return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (win())
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    MessageBox.Show("X Won!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button1.Text = inboxes[0];
                button1.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button1.Text = inboxes[1];
                button1.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button2.Text = inboxes[0];
                button2.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button2.Text = inboxes[1];
                button2.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button3.Text = inboxes[0];
                button3.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button3.Text = inboxes[1];
                button3.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button4.Text = inboxes[0];
                button4.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button4.Text = inboxes[1];
                button4.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button5.Text = inboxes[0];
                button5.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button5.Text = inboxes[1];
                button5.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button6.Text = inboxes[0];
                button6.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button6.Text = inboxes[1];
                button6.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button7.Text = inboxes[0];
                button7.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button7.Text = inboxes[1];
                button7.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button8.Text = inboxes[0];
                button8.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button8.Text = inboxes[1];
                button8.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 0;
                button9.Text = inboxes[0];
                button9.Enabled = false;
                turn = "O";
                labelturn.Text = "Turn: O";
            }
            else
            {
                mousehover = 0;
                button9.Text = inboxes[1];
                button9.Enabled = false;
                turn = "X";
                labelturn.Text = "Turn: X";
            }
        }

        private void button10_Click(object sender, EventArgs e) //Resetbutton s
        {
            turn = "X";
            labelturn.Text = "Turn: X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
            button9.BackColor = SystemColors.Control;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button1.Enabled = true;
                button1.Text = "";
                mousehover = 0;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button2.Enabled = true;
                button2.Text = "";
                mousehover = 0;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button3.Enabled = true;
                button3.Text = "";
                mousehover = 0;
            }
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button4.Enabled = true;
                button4.Text = "";
                mousehover = 0;
            }
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button5.Enabled = true;
                button5.Text = "";
                mousehover = 0;
            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button6.Enabled = true;
                button6.Text = "";
                mousehover = 0;
            }
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button7.Enabled = true;
                button7.Text = "";
                mousehover = 0;
            }
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button8.Enabled = true;
                button8.Text = "";
                mousehover = 0;
            }
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            if (mousehover == 1)
            {
                button9.Enabled = true;
                button9.Text = "";
                mousehover = 0;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button1.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button1.Text = inboxes[1];
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button2.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button2.Text = inboxes[1];
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button3.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button3.Text = inboxes[1];
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button4.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button4.Text = inboxes[1];
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button5.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button5.Text = inboxes[1];
            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button6.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button6.Text = inboxes[1];
            }
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button7.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button7.Text = inboxes[1];
            }
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button8.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button8.Text = inboxes[1];
            }
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            if (turn == "X")
            {
                mousehover = 1;
                button9.Text = inboxes[0];
            }
            else if (turn == "O")
            {
                mousehover = 1;
                button9.Text = inboxes[1];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
