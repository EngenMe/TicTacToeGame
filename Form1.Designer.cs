namespace TicTacToeGame
{
    partial class frmMain
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
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinnerPlayer = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartGame.FlatAppearance.BorderSize = 2;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestartGame.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.Location = new System.Drawing.Point(232, 454);
            this.btnRestartGame.Margin = new System.Windows.Forms.Padding(5);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(140, 39);
            this.btnRestartGame.TabIndex = 9;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(232, 111);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(59, 28);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayerTurn.Location = new System.Drawing.Point(232, 158);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(96, 28);
            this.lblPlayerTurn.TabIndex = 11;
            this.lblPlayerTurn.Tag = "Player 1";
            this.lblPlayerTurn.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(232, 252);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(84, 28);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Text = "Winner";
            // 
            // lblWinnerPlayer
            // 
            this.lblWinnerPlayer.AutoSize = true;
            this.lblWinnerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerPlayer.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerPlayer.ForeColor = System.Drawing.Color.Coral;
            this.lblWinnerPlayer.Location = new System.Drawing.Point(232, 300);
            this.lblWinnerPlayer.Name = "lblWinnerPlayer";
            this.lblWinnerPlayer.Size = new System.Drawing.Size(130, 28);
            this.lblWinnerPlayer.TabIndex = 13;
            this.lblWinnerPlayer.Text = "In Progress";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(635, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 44);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.Transparent;
            this.btn11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.ForeColor = System.Drawing.Color.Transparent;
            this.btn11.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn11.Location = new System.Drawing.Point(618, 127);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(134, 128);
            this.btn11.TabIndex = 15;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.Transparent;
            this.btn12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn12.FlatAppearance.BorderSize = 0;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.ForeColor = System.Drawing.Color.Transparent;
            this.btn12.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn12.Location = new System.Drawing.Point(797, 127);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(134, 128);
            this.btn12.TabIndex = 16;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.Transparent;
            this.btn13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn13.FlatAppearance.BorderSize = 0;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.ForeColor = System.Drawing.Color.Transparent;
            this.btn13.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn13.Location = new System.Drawing.Point(985, 127);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(134, 128);
            this.btn13.TabIndex = 17;
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.Transparent;
            this.btn21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn21.FlatAppearance.BorderSize = 0;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.ForeColor = System.Drawing.Color.Transparent;
            this.btn21.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn21.Location = new System.Drawing.Point(618, 273);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(134, 128);
            this.btn21.TabIndex = 18;
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.Transparent;
            this.btn22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn22.FlatAppearance.BorderSize = 0;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.ForeColor = System.Drawing.Color.Transparent;
            this.btn22.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn22.Location = new System.Drawing.Point(797, 273);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(134, 128);
            this.btn22.TabIndex = 19;
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.Transparent;
            this.btn23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn23.FlatAppearance.BorderSize = 0;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.ForeColor = System.Drawing.Color.Transparent;
            this.btn23.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn23.Location = new System.Drawing.Point(985, 271);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(134, 128);
            this.btn23.TabIndex = 20;
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.btn23_Click);
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.Color.Transparent;
            this.btn31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn31.FlatAppearance.BorderSize = 0;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.ForeColor = System.Drawing.Color.Transparent;
            this.btn31.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn31.Location = new System.Drawing.Point(618, 423);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(134, 128);
            this.btn31.TabIndex = 21;
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.btn31_Click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.Transparent;
            this.btn32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn32.FlatAppearance.BorderSize = 0;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.ForeColor = System.Drawing.Color.Transparent;
            this.btn32.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn32.Location = new System.Drawing.Point(797, 423);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(134, 128);
            this.btn32.TabIndex = 22;
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.btn32_Click);
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.Color.Transparent;
            this.btn33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn33.FlatAppearance.BorderSize = 0;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.ForeColor = System.Drawing.Color.Transparent;
            this.btn33.Image = global::TicTacToeGame.Properties.Resources.question_mark;
            this.btn33.Location = new System.Drawing.Point(985, 423);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(134, 128);
            this.btn33.TabIndex = 23;
            this.btn33.UseVisualStyleBackColor = false;
            this.btn33.Click += new System.EventHandler(this.btn33_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.backgroundMain;
            this.ClientSize = new System.Drawing.Size(1315, 649);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWinnerPlayer);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnRestartGame);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pntImgLinesSep);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblWinnerPlayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
    }
}

