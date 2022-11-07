
namespace Hangman_Game
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graphicsPanel = new System.Windows.Forms.Panel();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.currentScore = new System.Windows.Forms.Label();
            this.scoreboard = new System.Windows.Forms.ListBox();
            this.missedLabel = new System.Windows.Forms.Label();
            this.wordLengthLabel = new System.Windows.Forms.Label();
            this.interfaceBox = new System.Windows.Forms.GroupBox();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.btnSubmitWord = new System.Windows.Forms.Button();
            this.btnSubmitLetter = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.highScoresBox = new System.Windows.Forms.ListBox();
            this.currentHighScores = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.displayBox.SuspendLayout();
            this.interfaceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.graphicsPanel);
            this.groupBox1.Location = new System.Drawing.Point(541, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.Color.LightBlue;
            this.graphicsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphicsPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.graphicsPanel.Location = new System.Drawing.Point(3, 0);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(194, 331);
            this.graphicsPanel.TabIndex = 0;
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.LightBlue;
            this.displayBox.Controls.Add(this.currentScore);
            this.displayBox.Controls.Add(this.scoreboard);
            this.displayBox.Controls.Add(this.missedLabel);
            this.displayBox.Controls.Add(this.wordLengthLabel);
            this.displayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayBox.Location = new System.Drawing.Point(12, 2);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(526, 271);
            this.displayBox.TabIndex = 3;
            this.displayBox.TabStop = false;
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.BackColor = System.Drawing.Color.Transparent;
            this.currentScore.Location = new System.Drawing.Point(384, 225);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(61, 13);
            this.currentScore.TabIndex = 3;
            this.currentScore.Text = "Your score:";
            this.currentScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoreboard
            // 
            this.scoreboard.FormattingEnabled = true;
            this.scoreboard.Location = new System.Drawing.Point(445, 225);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(78, 17);
            this.scoreboard.TabIndex = 2;
            // 
            // missedLabel
            // 
            this.missedLabel.AutoSize = true;
            this.missedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedLabel.Location = new System.Drawing.Point(24, 249);
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(43, 13);
            this.missedLabel.TabIndex = 1;
            this.missedLabel.Text = "Missed:";
            // 
            // wordLengthLabel
            // 
            this.wordLengthLabel.AutoSize = true;
            this.wordLengthLabel.Location = new System.Drawing.Point(410, 249);
            this.wordLengthLabel.Name = "wordLengthLabel";
            this.wordLengthLabel.Size = new System.Drawing.Size(72, 13);
            this.wordLengthLabel.TabIndex = 0;
            this.wordLengthLabel.Text = "Word Length:";
            // 
            // interfaceBox
            // 
            this.interfaceBox.Controls.Add(this.btnExitGame);
            this.interfaceBox.Controls.Add(this.btnNewGame);
            this.interfaceBox.Controls.Add(this.wordTextBox);
            this.interfaceBox.Controls.Add(this.letterTextBox);
            this.interfaceBox.Controls.Add(this.btnSubmitWord);
            this.interfaceBox.Controls.Add(this.btnSubmitLetter);
            this.interfaceBox.Location = new System.Drawing.Point(12, 279);
            this.interfaceBox.Name = "interfaceBox";
            this.interfaceBox.Size = new System.Drawing.Size(523, 96);
            this.interfaceBox.TabIndex = 4;
            this.interfaceBox.TabStop = false;
            // 
            // btnExitGame
            // 
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitGame.Location = new System.Drawing.Point(442, 47);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(75, 23);
            this.btnExitGame.TabIndex = 5;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Location = new System.Drawing.Point(442, 18);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(133, 47);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(148, 20);
            this.wordTextBox.TabIndex = 3;
            // 
            // letterTextBox
            // 
            this.letterTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.letterTextBox.Location = new System.Drawing.Point(133, 21);
            this.letterTextBox.MaxLength = 1;
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(22, 20);
            this.letterTextBox.TabIndex = 2;
            // 
            // btnSubmitWord
            // 
            this.btnSubmitWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitWord.Location = new System.Drawing.Point(6, 47);
            this.btnSubmitWord.Name = "btnSubmitWord";
            this.btnSubmitWord.Size = new System.Drawing.Size(121, 20);
            this.btnSubmitWord.TabIndex = 1;
            this.btnSubmitWord.Text = "Submit Word";
            this.btnSubmitWord.UseVisualStyleBackColor = true;
            this.btnSubmitWord.Click += new System.EventHandler(this.SubmitWord_Click);
            // 
            // btnSubmitLetter
            // 
            this.btnSubmitLetter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitLetter.Location = new System.Drawing.Point(6, 21);
            this.btnSubmitLetter.Name = "btnSubmitLetter";
            this.btnSubmitLetter.Size = new System.Drawing.Size(121, 20);
            this.btnSubmitLetter.TabIndex = 0;
            this.btnSubmitLetter.Text = "Submit Letter";
            this.btnSubmitLetter.UseVisualStyleBackColor = true;
            this.btnSubmitLetter.Click += new System.EventHandler(this.SubmitLetter_Click);
            // 
            // highScoresBox
            // 
            this.highScoresBox.FormattingEnabled = true;
            this.highScoresBox.Location = new System.Drawing.Point(744, 2);
            this.highScoresBox.Name = "highScoresBox";
            this.highScoresBox.Size = new System.Drawing.Size(201, 381);
            this.highScoresBox.TabIndex = 3;
            // 
            // currentHighScores
            // 
            this.currentHighScores.AutoSize = true;
            this.currentHighScores.BackColor = System.Drawing.Color.Transparent;
            this.currentHighScores.Location = new System.Drawing.Point(783, 362);
            this.currentHighScores.Name = "currentHighScores";
            this.currentHighScores.Size = new System.Drawing.Size(105, 13);
            this.currentHighScores.TabIndex = 5;
            this.currentHighScores.Text = "Current High Scores:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(949, 387);
            this.Controls.Add(this.currentHighScores);
            this.Controls.Add(this.highScoresBox);
            this.Controls.Add(this.interfaceBox);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hangman - Stefan Reesberg";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.displayBox.ResumeLayout(false);
            this.displayBox.PerformLayout();
            this.interfaceBox.ResumeLayout(false);
            this.interfaceBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel graphicsPanel;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.GroupBox interfaceBox;
        private System.Windows.Forms.Label wordLengthLabel;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button btnSubmitWord;
        private System.Windows.Forms.Button btnSubmitLetter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label missedLabel;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ListBox scoreboard;
        private System.Windows.Forms.ListBox highScoresBox;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Label currentHighScores;
    }
}

