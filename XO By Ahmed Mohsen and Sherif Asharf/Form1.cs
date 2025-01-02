using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_By_Ahmed_Mohsen_and_Sherif_Asharf
{
    public partial class Form1 : Form
    {
        public enum player
        {
            X, O
        }
        player CurrentPlayer;
        Random random = new Random();
        int PlayerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
            RandomStart();
        }
        private void RandomStart()
        {
            int start = random.Next(2);
            if (start == 0)
            {
                CurrentPlayer = player.X;
                label3.Text = "Player's Turn";
            }
            else
            {
                CurrentPlayer = player.O;
                label3.Text = "CPU's Turn";
                CPUTimer.Start();
            }
        }
        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (CurrentPlayer == player.X)
            {
                button.Text = CurrentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Cyan;
                buttons.Remove(button);
                CheckGame();
                CurrentPlayer = player.O;
                label3.Text = "CPU's Turn";
                CPUTimer.Start();
            }
        }
        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && CurrentPlayer == player.O)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                buttons[index].Text = CurrentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                CheckGame();
                CurrentPlayer = player.X;
                label3.Text = "Player's Turn";
                CPUTimer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            PlayerWinCount = 0;
            CPUWinCount = 0;
            label1.Text = "Player Wins: 0";
            label2.Text = "CPU Wins: 0";
            RandomStart();
            RestartGame();
        }
        private void CheckGame()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWinCount++;
                label1.Text = "Player Wins: " + PlayerWinCount;
                RestartGame();

            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();

            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
            else if (!buttons.Any(b => b.Enabled))
            {
                CPUTimer.Stop();
                MessageBox.Show("Draw");
                RestartGame();
            }
        }
        private void RestartGame()
        {
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
