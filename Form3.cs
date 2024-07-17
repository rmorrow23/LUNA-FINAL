using System;
using System.IO;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class NumberGuessing : Form
    {
        private int targetNumber;
        private int numberOfAttempts;
        private Random random;
        private string logFilePath = "number_guessing_log.txt";

        public NumberGuessing()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            random = new Random();
            targetNumber = random.Next(1, 101); // Random number between 1 and 100
            numberOfAttempts = 0;
            lblFeedback.Text = "Guess a number between 1 and 100";
            lblBestScore.Text = "Least Amount of Tries: " + GetBestScore().ToString();
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            //check to see if the text entered is an integer
            if (int.TryParse(txtGuess.Text, out int guess))
            {   //updates the number of attempts to guess the number
                numberOfAttempts++;
                if (guess < targetNumber)
                {
                    lblFeedback.Text = "Too low! Try again.";
                }
                else if (guess > targetNumber)
                {
                    lblFeedback.Text = "Too high! Try again.";
                }
                else
                {
                    lblFeedback.Text = $"Congratulations! You guessed the number in {numberOfAttempts} attempts.";
                    SaveAttempt(numberOfAttempts);
                    lblBestScore.Text = "Least Amount of Tries: " + GetBestScore().ToString();
                    btnSubmitGuess.Enabled = false; // Disable the button after the game is won
                }
            }
            else
            {
                lblFeedback.Text = "Please enter a valid number.";
            }
        }
        //restarts the game, generating a new number to be guessed
        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
            txtGuess.Clear();
            btnSubmitGuess.Enabled = true;
        }
        //saves the amount of times it took to guess the number
        private void SaveAttempt(int attempts)
        {
            try
            {
                File.AppendAllText(logFilePath, attempts + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving attempt: {ex.Message}");
            }
        }

        private int GetBestScore()
        {
            if (!File.Exists(logFilePath))
                return 0; // No best score available yet

            try
            {
                var scores = File.ReadAllLines(logFilePath);
                int bestScore = int.MaxValue;
                foreach (var score in scores)
                {
                    if (int.TryParse(score, out int attempts))
                    {
                        if (attempts < bestScore)
                        {
                            bestScore = attempts;
                        }
                    }
                }
                return bestScore == int.MaxValue ? 0 : bestScore; // Return 0 if no valid scores
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading best score: {ex.Message}");
                return 0; // Return 0 if there's an error reading the file
            }
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            // Optional: Additional logic for when the text changes
        }
    }
}
