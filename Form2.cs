using System;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class TicTacToe : Form
    {
        private Button[,] buttons = new Button[3, 3];
        private char currentPlayer = 'X';
        private char[,] board = new char[3, 3];
        private Label lblStatus;

        public TicTacToe()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void TICTACTOE_Load(object sender, EventArgs e)
        { 
        
        }
        private void InitializeGame()
        {
            // Initialize the board and buttons
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Location = new System.Drawing.Point(30 + j * 60, 30 + i * 60),
                        Size = new System.Drawing.Size(50, 50),
                        Font = new System.Drawing.Font("Arial", 24),
                        Tag = new Tuple<int, int>(i, j)
                    };
                    buttons[i, j].Click += Button_Click;
                    this.Controls.Add(buttons[i, j]);
                    board[i, j] = ' ';
                }
            }

            // Initialize the status label
            lblStatus = new Label
            {
                Location = new System.Drawing.Point(30, 210),
                Size = new System.Drawing.Size(200, 30),
                Font = new System.Drawing.Font("Arial", 14),
                Text = "Player X's turn"
            };
            this.Controls.Add(lblStatus);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var position = (Tuple<int, int>)button.Tag;

            if (board[position.Item1, position.Item2] == ' ')
            {
                board[position.Item1, position.Item2] = currentPlayer;
                button.Text = currentPlayer.ToString();
                if (CheckWinner())
                {
                    lblStatus.Text = $"Player {currentPlayer} wins!";
                    DisableButtons();
                }
                else if (IsBoardFull())
                {
                    lblStatus.Text = "It's a draw!";
                }
                else
                {
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    lblStatus.Text = $"Player {currentPlayer}'s turn";
                }
            }
        }

        private bool CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            }
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;
            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        private bool IsBoardFull()
        {
            foreach (var cell in board)
            {
                if (cell == ' ')
                    return false;
            }
            return true;
        }

        private void DisableButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }
    }
}
