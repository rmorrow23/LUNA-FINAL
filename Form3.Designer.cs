namespace Moonbase
{
    partial class NumberGuessing
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnRestart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberGuessing));
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(463, 433);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(144, 92);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Location = new System.Drawing.Point(571, 551);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(220, 65);
            this.btnSubmitGuess.TabIndex = 1;
            this.btnSubmitGuess.Text = "Submit Guess";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(440, 379);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(212, 51);
            this.lblFeedback.TabIndex = 2;
            this.lblFeedback.Text = "Feedback";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(349, 546);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(151, 70);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblBestScore.Location = new System.Drawing.Point(36, 26);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(899, 55);
            this.lblBestScore.TabIndex = 4;
            this.lblBestScore.Text = "Best # of Attempts: (lowest # of attempts)";
            // 
            // NumberGuessing
            // 
            this.BackgroundImage = global::Moonbase.Properties.Resources.entertainment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 682);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmitGuess);
            this.Controls.Add(this.txtGuess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumberGuessing";
            this.Text = "Guess The Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBestScore;
    }
}
