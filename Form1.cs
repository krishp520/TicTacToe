using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        public Form1()
        {  
            InitializeComponent();
            InitializeGameButtons();
        }

        // Declare game variables
        string player1Name, player2Name, currentPlayer;
        string player1Symbol, player2Symbol;
        int player1Wins = 0, player2Wins = 0, draws = 0;
        Button[,] gameButtons = new Button[3, 3]; // 3x3 grid buttons

        private void InitializeGameButtons()
        {
            gameButtons[0, 0] = btn1;
            gameButtons[0, 1] = btn2;
            gameButtons[0, 2] = btn3;
            gameButtons[1, 0] = btn4;
            gameButtons[1, 1] = btn5;
            gameButtons[1, 2] = btn6;
            gameButtons[2, 0] = btn7;
            gameButtons[2, 1] = btn8;
            gameButtons[2, 2] = btn9;

            foreach (Button btn in gameButtons)
            {
                btn.Click += new EventHandler(GameButton_Click);
            }
        }

        // Handle Game button click
        private void GameButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Place the current player's symbol on the clicked button
            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                clickedButton.Text = currentPlayer == player1Name ? player1Symbol : player2Symbol;
                clickedButton.Enabled = false;

                // Check the state of the game
                string winner = GetWinner(GetButtonSymbols());

                if (winner == player1Symbol || winner == player2Symbol)
                {
                    MessageBox.Show($"{currentPlayer} wins!");
                    UpdateGameStats(currentPlayer);
                    return;
                }
                else if (winner == "Draw")
                {
                    MessageBox.Show("It's a draw!");
                    UpdateGameStats("Draw");
                    return;
                }

                // Switch turns
                currentPlayer = currentPlayer == player1Name ? player2Name : player1Name;
                UpdateNextTurnLabel();
            }
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            // Get player details and validate inputs
            player1Name = txtb1_player1Name.Text;
            player2Name = txtb2_player2Name.Text;
            player1Symbol = txtb3_player1Symbol.Text.ToUpper();
            player2Symbol = txtb4_player2Symbol.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(player1Name) || string.IsNullOrWhiteSpace(player2Name) ||
                string.IsNullOrWhiteSpace(player1Symbol) || string.IsNullOrWhiteSpace(player2Symbol))
            {
                MessageBox.Show("Please enter valid names and symbols for both players.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtb1_player1Name.Enabled = true;
                txtb2_player2Name.Enabled = true;
                txtb3_player1Symbol.Enabled = true;
                txtb4_player2Symbol.Enabled = true;
                return;
            }

            if (player1Symbol == player2Symbol)
            {
                MessageBox.Show("Players must choose different symbols.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtb3_player1Symbol.Enabled = true;
                txtb4_player2Symbol.Enabled = true;
                return;
            }

            if (player1Symbol.Length != 1 || player2Symbol.Length != 1 || !char.IsLetter(player1Symbol[0]) || !char.IsLetter(player2Symbol[0]))
            {
                MessageBox.Show("Players must choose a single letter as their symbol.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtb3_player1Symbol.Enabled = true;
                txtb4_player2Symbol.Enabled = true;
                return;
            }

            // disabling all the buttons once the game starts
            txtb1_player1Name.Enabled = false;
            txtb2_player2Name.Enabled = false;
            txtb3_player1Symbol.Enabled = false;
            txtb4_player2Symbol.Enabled = false;
            EnableGameButtons(true);
            Btn_start.Enabled = false;
            currentPlayer = player1Name;
            UpdateNextTurnLabel();
        }

        private void Btn1_reset_Click(object sender, EventArgs e)
        {
            // Reset all game stats
            txtb1_player1Name.Text = "";
            txtb2_player2Name.Text = "";
            txtb3_player1Symbol.Text = "";
            txtb4_player2Symbol.Text = "";
            player1Wins = 0;
            player2Wins = 0;
            draws = 0;
            listBox1.Items.Clear();
            EnableGameButtons(false);
            currentPlayer = null;
            Btn_start.Enabled = true;
            btn_continue.Enabled = false;
            ClearBoard();

        }

        // Function to gather button symbols into a 2D array
        private string[,] GetButtonSymbols()
        {
            string[,] btnSymbols = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btnSymbols[i, j] = gameButtons[i, j].Text;
                }
            }

            return btnSymbols;
        }

        // Clear the game board
        private void ClearBoard()
        {
            foreach (Button btn in gameButtons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            ClearBoard(); 
            EnableGameButtons(true); 
            btn_continue.Enabled = false; 
            currentPlayer = player1Name; 
            UpdateNextTurnLabel();
            txtb7.Text = "";
        }

        // Enable or disable game buttons
        private void EnableGameButtons(bool isEnabled)
        {
            foreach (Button btn in gameButtons)
            {
                btn.Enabled = isEnabled;
            }
        }

        // Update game stats when a game is completed
        private void UpdateGameStats(string result)
        {
            string gameResult = result == "Draw" ? "Draw" : $"{result} Wins!";
            listBox1.Items.Add($"Round {listBox1.Items.Count + 1}: {gameResult}");

            // Update overall wins
            if (result == player1Name)
                player1Wins++;
            else if (result == player2Name)
                player2Wins++;
            else
                draws++;

            UpdateWinnerLabel();
            EnableGameButtons(false); // Disable the game buttons until the next game
            btn_continue.Enabled = true;
        }

        private void UpdateNextTurnLabel()
        {
            txtb5.Text = $"{currentPlayer}";
        }

        // Update the winner label based on the overall game results
        private void UpdateWinnerLabel()
        {
            if (player1Wins > player2Wins)
                txtb7.Text = $"{player1Name}";
            else if (player2Wins > player1Wins)
                txtb7.Text = $"{player2Name}";
            else
                txtb7.Text = "Draw!";
        }

        private string GetWinner(string[,] btnSymbols)
        {
            // First row
            if ((btnSymbols[0, 0] != "") && (btnSymbols[0, 0] == btnSymbols[0, 1]) && (btnSymbols[0, 1] == btnSymbols[0, 2]))
            {
                return btnSymbols[0, 0]; // return winning symbol
            }

            // Second row
            if ((btnSymbols[1, 0] != "") && (btnSymbols[1, 0] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[1, 2]))
            {
                return btnSymbols[1, 0]; // return winning symbol
            }

            // Third row
            if ((btnSymbols[2, 0] != "") && (btnSymbols[2, 0] == btnSymbols[2, 1]) && (btnSymbols[2, 1] == btnSymbols[2, 2]))
            {
                return btnSymbols[2, 0]; // return winning symbol
            }

            // First column
            if ((btnSymbols[0, 0] != "") && (btnSymbols[0, 0] == btnSymbols[1, 0]) && (btnSymbols[1, 0] == btnSymbols[2, 0]))
            {
                return btnSymbols[0, 0]; // return winning symbol
            }

            // Second column
            if ((btnSymbols[0, 1] != "") && (btnSymbols[0, 1] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[2, 1]))
            {
                return btnSymbols[0, 1]; // return winning symbol
            }

            // Third column
            if ((btnSymbols[0, 2] != "") && (btnSymbols[0, 2] == btnSymbols[1, 2]) && (btnSymbols[1, 2] == btnSymbols[2, 2]))
            {
                return btnSymbols[0, 2]; // return winning symbol
            }

            // First diagonal
            if ((btnSymbols[0, 0] != "") && (btnSymbols[0, 0] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[2, 2]))
            {
                return btnSymbols[0, 0]; // return winning symbol
            }

            // Second diagonal
            if ((btnSymbols[0, 2] != "") && (btnSymbols[0, 2] == btnSymbols[1, 1]) && (btnSymbols[1, 1] == btnSymbols[2, 0]))
            {
                return btnSymbols[0, 2]; // return winning symbol
            }

            // Check if all buttons are clicked, otherwise return empty for continuing the game
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (btnSymbols[i, j] == "")
                        return ""; // There are still buttons to be clicked, continue game
                }
            }

            return "Draw"; // All buttons are clicked, it's a draw
        }
    }
}