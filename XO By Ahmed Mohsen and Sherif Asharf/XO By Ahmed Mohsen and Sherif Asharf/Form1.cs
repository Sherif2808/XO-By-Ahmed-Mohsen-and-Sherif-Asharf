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
            X, O  // 'player' is an enumeration that defines two possible states: X and O. 
                  // It is used to manage and switch between the two players during the game. 
        }
        player CurrentPlayer;  // Variable to track the current player (X or O)
        Random random = new Random();  // Random object to generate random numbers (for CPU moves or starting player)(0 or 1)
        int PlayerWinCount = 0;  
        int Draw = 0;  
        int CPUWinCount = 0;  
        List<Button> buttons;  // List to store all the buttons used in the game grid
        public Form1()
        {
            InitializeComponent();
            RestartGame();
            RandomStart();
        }
        private void RandomStart()
        {
            int start = random.Next(2);  // Generates a random number (0 or 1).
            if (start == 0)
            {
                CurrentPlayer = player.X;   // If the random number is 0, the player starts.
                label3.Text = "Player's Turn";
            }
            else
            {
                CurrentPlayer = player.O;   // If the random number is 1, the CPU starts.
                label3.Text = "CPU's Turn";  
                CPUTimer.Start();            // Starts the CPU timer to make a move automatically.
            }
        }
        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;  // 'var' automatically infers the type of 'button' as Button based on the right-hand side.
                                         // Casts the sender object to a Button.
            if (CurrentPlayer == player.X)  
            {
                button.Text = CurrentPlayer.ToString();  // Sets the button text to "X".
                button.Enabled = false;  // Disables the button to prevent further clicks.
                button.BackColor = Color.Cyan;  
                buttons.Remove(button);  // Removes the button from the list of available moves.
                CheckGame();  // Checks if the game has been won or if it's a draw.
                CurrentPlayer = player.O;  // Switches turn to CPU (O).
                label3.Text = "CPU's Turn";  
                CPUTimer.Start();  
            }
        }
        private Button FindWinningMove(string mark)
        {
            foreach (var button in buttons)
            {
                button.Text = mark; //mark is a string that holds the current player's symbol
                if (CheckPotentialWin(mark))
                {
                    button.Text = "?";  // If a winning move is found, reset the button's text back to "?" as this is just a temporary simulation.
                    return button;  // Return this button as the one that can complete a winning move.
                }
                button.Text = "?";  // Reset the button's text back to "?" because we are testing different possible moves, not actually playing.
            }
            return null;
        }
        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && CurrentPlayer == player.O)
            {
                Button move = FindWinningMove("O"); //move is a Button object that represents the button where the current player (or CPU) places their mark.
                if (move == null)
                {
                    move = FindWinningMove("X"); // If no winning move is found, try to find a winning move for the player ('X') to block them.
                }
                if (move == null)
                {
                    int index = random.Next(buttons.Count);
                    move = buttons[index];
                }
                move.Enabled = false;
                move.Text = CurrentPlayer.ToString();
                move.BackColor = Color.DarkSalmon;
                buttons.Remove(move);
                CheckGame();
                CurrentPlayer = player.X;
                label3.Text = "Player's Turn";
                CPUTimer.Stop();
            }
        }
        private bool CheckPotentialWin(string mark)
        {
            return (btn1.Text == mark && btn2.Text == mark && btn3.Text == mark) ||
                   (btn4.Text == mark && btn5.Text == mark && btn6.Text == mark) ||
                   (btn7.Text == mark && btn8.Text == mark && btn9.Text == mark) ||
                   (btn1.Text == mark && btn4.Text == mark && btn7.Text == mark) ||
                   (btn2.Text == mark && btn5.Text == mark && btn8.Text == mark) ||
                   (btn3.Text == mark && btn6.Text == mark && btn9.Text == mark) ||
                   (btn1.Text == mark && btn5.Text == mark && btn9.Text == mark) ||
                   (btn3.Text == mark && btn5.Text == mark && btn7.Text == mark);
            //The reason we use this method(not if or if - else if) is that more Efficient,shorter and cleaner and more Readable
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
            Draw = 0;
            label1.Text = "Player Wins: 0";
            label2.Text = "CPU Wins: 0";
            label4.Text = "Draw: 0";
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
                Draw++;
                label4.Text = "Draw: " + Draw;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

