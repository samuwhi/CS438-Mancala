namespace CS438_Mancala
{
    partial class GameEndForm
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
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.GameOverText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Location = new System.Drawing.Point(162, 32);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(79, 16);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over!";
            // 
            // GameOverText
            // 
            this.GameOverText.AutoSize = true;
            this.GameOverText.Location = new System.Drawing.Point(105, 77);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(208, 16);
            this.GameOverText.TabIndex = 1;
            this.GameOverText.Text = "Player One won with a score of 60!";
            this.GameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 204);
            this.Controls.Add(this.GameOverText);
            this.Controls.Add(this.GameOverLabel);
            this.Name = "GameEndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label GameOverText;
    }
}