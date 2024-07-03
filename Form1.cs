using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.Properties;

namespace TicTacToeGame
{
    public partial class frmMain : Form
    {
        // Constructor to initialize the form components
        public frmMain()
        {
            InitializeComponent();
        }

        // Resets all the images on the buttons to a question mark
        void ResetAllImg()
        {
            btn11.Image = Resources.question_mark;
            btn12.Image = Resources.question_mark;
            btn13.Image = Resources.question_mark;
            btn21.Image = Resources.question_mark;
            btn22.Image = Resources.question_mark;
            btn23.Image = Resources.question_mark;
            btn31.Image = Resources.question_mark;
            btn32.Image = Resources.question_mark;
            btn33.Image = Resources.question_mark;

            btn11.BackColor = Color.Transparent;
            btn12.BackColor = Color.Transparent;
            btn13.BackColor = Color.Transparent;
            btn21.BackColor = Color.Transparent;
            btn22.BackColor = Color.Transparent;
            btn23.BackColor = Color.Transparent;
            btn31.BackColor = Color.Transparent;
            btn32.BackColor = Color.Transparent;
            btn33.BackColor = Color.Transparent;
        }

        // Gets the current player from the label tag
        string GetCurrentPlayer()
        {
            return lblPlayerTurn.Tag.ToString();
        }

        // Gets the next player based on the current player
        string GetNextPlayer()
        {
            return (lblPlayerTurn.Tag.ToString() == "Player 1" ? "Player 2" : "Player 1");
        }

        // Updates the label to show the next player's turn
        void UpdateLabelPlayerTurn(string next_player)
        {
            lblPlayerTurn.Tag = next_player;
            lblPlayerTurn.Text = next_player;
        }

        // Updates the current player for the button and the label
        void UpdateCurrentPlayer(Button pb)
        {
            pb.Tag = GetCurrentPlayer();
            UpdateLabelPlayerTurn(GetNextPlayer());
        }

        // Updates the button image based on the current player
        void UpdatePBImg(Button pb)
        {
            pb.Image = (pb.Tag.ToString() == "Player 1" ? Resources.X : Resources.O);
        }

        // Counts the number of buttons that have been marked
        short HowManyXO()
        {
            short how_many_xo = 0;

            if (btn11.Tag != null)
                how_many_xo += 1;
            if (btn12.Tag != null)
                how_many_xo += 1;
            if (btn13.Tag != null)
                how_many_xo += 1;

            if (btn21.Tag != null)
                how_many_xo += 1;
            if (btn22.Tag != null)
                how_many_xo += 1;
            if (btn23.Tag != null)
                how_many_xo += 1;

            if (btn31.Tag != null)
                how_many_xo += 1;
            if (btn32.Tag != null)
                how_many_xo += 1;
            if (btn33.Tag != null)
                how_many_xo += 1;

            return how_many_xo;
        }

        // Disables all the buttons to prevent further moves
        void DisableAllPicBoxs()
        {
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;

            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;

            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
        }

        // Sets the background color of the winning buttons to green
        void SetGreen(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.GreenYellow;
            btn2.BackColor = Color.GreenYellow;
            btn3.BackColor = Color.GreenYellow;
        }

        // Ends the game and declares the winner
        void GameOverWithWinner(Button btn1, Button btn2, Button btn3)
        {
            SetGreen(btn1, btn2, btn3);

            string winner_name = btn1.Tag.ToString();
            lblWinnerPlayer.Text = winner_name;
            MessageBox.Show("Winner: " + winner_name, "Game Over", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DisableAllPicBoxs();
        }

        // Resets all the tags (player information) on the buttons
        void ResetAllImgTags()
        {
            btn11.Tag = null;
            btn12.Tag = null;
            btn13.Tag = null;

            btn21.Tag = null;
            btn22.Tag = null;
            btn23.Tag = null;

            btn31.Tag = null;
            btn32.Tag = null;
            btn33.Tag = null;
        }

        // Ends the game with no winner
        void GameOverWithoutWinner()
        {
            lblWinnerPlayer.Text = "Deal";
            MessageBox.Show("No Winner", "Game Over", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            DisableAllPicBoxs();
            ResetAllImgTags();
        }

        // Checks if the three buttons have the same player's mark
        void CheckMatching(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag == null || btn2.Tag == null || btn3.Tag == null)
                return;

            if (btn1.Tag.ToString() == btn2.Tag.ToString() &&
                btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                GameOverWithWinner(btn1, btn2, btn3);
                return;
            }
        }

        // Checks if there is a winner or if the game is a draw
        void CheckWinner()
        {
            if (HowManyXO() == 9)
            {
                GameOverWithoutWinner();
                return;
            }
            else if (HowManyXO() < 5)
                return;

            CheckMatching(btn11, btn12, btn13);
            CheckMatching(btn21, btn22, btn23);
            CheckMatching(btn31, btn32, btn33);

            CheckMatching(btn11, btn21, btn31);
            CheckMatching(btn12, btn22, btn32);
            CheckMatching(btn13, btn23, btn33);

            CheckMatching(btn11, btn22, btn33);
            CheckMatching(btn13, btn22, btn31);
        }

        // Enables all the buttons for a new game
        void EnableAllImg()
        {
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;

            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;

            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
        }

        // Event handler for the restart button click
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetAllImg();
            ResetAllImgTags();
            lblPlayerTurn.Text = "Player 1";
            lblWinnerPlayer.Text = "In Progress";
            EnableAllImg();
        }

        // Event handler for painting the lines separating the grid
        private void pntImgLinesSep(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 580, 100, 580, 450);
            e.Graphics.DrawLine(pen, 715, 100, 715, 450);

            e.Graphics.DrawLine(pen, 460, 215, 845, 215);
            e.Graphics.DrawLine(pen, 460, 335, 845, 335);
        }

        // Event handler for all button click
        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag != null)
            {
                MessageBox.Show("Already Checked", "Wrong Action!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            UpdateCurrentPlayer((Button)sender);
            UpdatePBImg((Button)sender);
            CheckWinner();
        }
    }
}
