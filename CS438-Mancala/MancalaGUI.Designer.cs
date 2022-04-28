namespace CS438_Mancala
{
    partial class MancalaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MancalaGUI));
            this.Player1Box = new System.Windows.Forms.GroupBox();
            this.HumanComputerLabel1 = new System.Windows.Forms.Label();
            this.Player1ConsoleWindowCheck = new System.Windows.Forms.CheckBox();
            this.Score1Text = new System.Windows.Forms.Label();
            this.Score1Label = new System.Windows.Forms.Label();
            this.Computer1Button = new System.Windows.Forms.Button();
            this.Human1Button = new System.Windows.Forms.Button();
            this.Player2Box = new System.Windows.Forms.GroupBox();
            this.HumanComputerLabel2 = new System.Windows.Forms.Label();
            this.Player2ConsoleWindowCheck = new System.Windows.Forms.CheckBox();
            this.Score2Text = new System.Windows.Forms.Label();
            this.Score2Label = new System.Windows.Forms.Label();
            this.Computer2Button = new System.Windows.Forms.Button();
            this.Human2Button = new System.Windows.Forms.Button();
            this.ControlBox = new System.Windows.Forms.GroupBox();
            this.TimeToWaitLabel = new System.Windows.Forms.Label();
            this.TimeToWaitDropdown = new System.Windows.Forms.ComboBox();
            this.StepBackButton = new System.Windows.Forms.Button();
            this.StepForwardButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.CurrentPlayersTurnLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerTurnButton = new System.Windows.Forms.Button();
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.Pocket7 = new CS438_Mancala.RoundButton();
            this.Pocket6 = new CS438_Mancala.RoundButton();
            this.Pocket5 = new CS438_Mancala.RoundButton();
            this.Pocket4 = new CS438_Mancala.RoundButton();
            this.Pocket3 = new CS438_Mancala.RoundButton();
            this.Pocket2 = new CS438_Mancala.RoundButton();
            this.Pocket1 = new CS438_Mancala.RoundButton();
            this.Pocket8 = new CS438_Mancala.RoundButton();
            this.Pocket9 = new CS438_Mancala.RoundButton();
            this.Pocket10 = new CS438_Mancala.RoundButton();
            this.Pocket11 = new CS438_Mancala.RoundButton();
            this.Pocket12 = new CS438_Mancala.RoundButton();
            this.Pocket13 = new CS438_Mancala.RoundButton();
            this.Pocket14 = new CS438_Mancala.RoundButton();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1Box.SuspendLayout();
            this.Player2Box.SuspendLayout();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Box
            // 
            this.Player1Box.Controls.Add(this.HumanComputerLabel1);
            this.Player1Box.Controls.Add(this.Player1ConsoleWindowCheck);
            this.Player1Box.Controls.Add(this.Score1Text);
            this.Player1Box.Controls.Add(this.Score1Label);
            this.Player1Box.Controls.Add(this.Computer1Button);
            this.Player1Box.Controls.Add(this.Human1Button);
            this.Player1Box.Location = new System.Drawing.Point(9, 24);
            this.Player1Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player1Box.Name = "Player1Box";
            this.Player1Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player1Box.Size = new System.Drawing.Size(235, 150);
            this.Player1Box.TabIndex = 15;
            this.Player1Box.TabStop = false;
            this.Player1Box.Text = "Player 1";
            // 
            // HumanComputerLabel1
            // 
            this.HumanComputerLabel1.AutoSize = true;
            this.HumanComputerLabel1.Location = new System.Drawing.Point(4, 43);
            this.HumanComputerLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HumanComputerLabel1.Name = "HumanComputerLabel1";
            this.HumanComputerLabel1.Size = new System.Drawing.Size(41, 13);
            this.HumanComputerLabel1.TabIndex = 6;
            this.HumanComputerLabel1.Text = "Human";
            // 
            // Player1ConsoleWindowCheck
            // 
            this.Player1ConsoleWindowCheck.AutoSize = true;
            this.Player1ConsoleWindowCheck.Location = new System.Drawing.Point(4, 100);
            this.Player1ConsoleWindowCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player1ConsoleWindowCheck.Name = "Player1ConsoleWindowCheck";
            this.Player1ConsoleWindowCheck.Size = new System.Drawing.Size(181, 17);
            this.Player1ConsoleWindowCheck.TabIndex = 4;
            this.Player1ConsoleWindowCheck.Text = "Show Player1\'s Console Window";
            this.Player1ConsoleWindowCheck.UseVisualStyleBackColor = true;
            this.Player1ConsoleWindowCheck.CheckedChanged += new System.EventHandler(this.Player1ConsoleWindowCheck_CheckedChanged);
            // 
            // Score1Text
            // 
            this.Score1Text.AutoSize = true;
            this.Score1Text.Location = new System.Drawing.Point(42, 56);
            this.Score1Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score1Text.Name = "Score1Text";
            this.Score1Text.Size = new System.Drawing.Size(13, 13);
            this.Score1Text.TabIndex = 3;
            this.Score1Text.Text = "0";
            this.Score1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Score1Label
            // 
            this.Score1Label.AutoSize = true;
            this.Score1Label.Location = new System.Drawing.Point(6, 57);
            this.Score1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score1Label.Name = "Score1Label";
            this.Score1Label.Size = new System.Drawing.Size(38, 13);
            this.Score1Label.TabIndex = 2;
            this.Score1Label.Text = "Score:";
            // 
            // Computer1Button
            // 
            this.Computer1Button.Location = new System.Drawing.Point(133, 17);
            this.Computer1Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Computer1Button.Name = "Computer1Button";
            this.Computer1Button.Size = new System.Drawing.Size(98, 24);
            this.Computer1Button.TabIndex = 1;
            this.Computer1Button.Text = "Computer";
            this.Computer1Button.UseVisualStyleBackColor = true;
            this.Computer1Button.Click += new System.EventHandler(this.Computer1Button_Click);
            // 
            // Human1Button
            // 
            this.Human1Button.Location = new System.Drawing.Point(4, 17);
            this.Human1Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Human1Button.Name = "Human1Button";
            this.Human1Button.Size = new System.Drawing.Size(98, 24);
            this.Human1Button.TabIndex = 0;
            this.Human1Button.Text = "Human";
            this.Human1Button.UseVisualStyleBackColor = true;
            this.Human1Button.Click += new System.EventHandler(this.Human1Button_Click);
            // 
            // Player2Box
            // 
            this.Player2Box.Controls.Add(this.HumanComputerLabel2);
            this.Player2Box.Controls.Add(this.Player2ConsoleWindowCheck);
            this.Player2Box.Controls.Add(this.Score2Text);
            this.Player2Box.Controls.Add(this.Score2Label);
            this.Player2Box.Controls.Add(this.Computer2Button);
            this.Player2Box.Controls.Add(this.Human2Button);
            this.Player2Box.Location = new System.Drawing.Point(9, 192);
            this.Player2Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player2Box.Name = "Player2Box";
            this.Player2Box.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player2Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Player2Box.Size = new System.Drawing.Size(235, 150);
            this.Player2Box.TabIndex = 16;
            this.Player2Box.TabStop = false;
            this.Player2Box.Text = "Player 2";
            // 
            // HumanComputerLabel2
            // 
            this.HumanComputerLabel2.AutoSize = true;
            this.HumanComputerLabel2.Location = new System.Drawing.Point(6, 42);
            this.HumanComputerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HumanComputerLabel2.Name = "HumanComputerLabel2";
            this.HumanComputerLabel2.Size = new System.Drawing.Size(41, 13);
            this.HumanComputerLabel2.TabIndex = 5;
            this.HumanComputerLabel2.Text = "Human";
            // 
            // Player2ConsoleWindowCheck
            // 
            this.Player2ConsoleWindowCheck.AutoSize = true;
            this.Player2ConsoleWindowCheck.Location = new System.Drawing.Point(4, 100);
            this.Player2ConsoleWindowCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player2ConsoleWindowCheck.Name = "Player2ConsoleWindowCheck";
            this.Player2ConsoleWindowCheck.Size = new System.Drawing.Size(181, 17);
            this.Player2ConsoleWindowCheck.TabIndex = 4;
            this.Player2ConsoleWindowCheck.Text = "Show Player2\'s Console Window";
            this.Player2ConsoleWindowCheck.UseVisualStyleBackColor = true;
            this.Player2ConsoleWindowCheck.CheckedChanged += new System.EventHandler(this.Player2ConsoleWindowCheck_CheckedChanged);
            // 
            // Score2Text
            // 
            this.Score2Text.AutoSize = true;
            this.Score2Text.Location = new System.Drawing.Point(45, 55);
            this.Score2Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score2Text.Name = "Score2Text";
            this.Score2Text.Size = new System.Drawing.Size(13, 13);
            this.Score2Text.TabIndex = 3;
            this.Score2Text.Text = "0";
            this.Score2Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Score2Label
            // 
            this.Score2Label.AutoSize = true;
            this.Score2Label.Location = new System.Drawing.Point(6, 55);
            this.Score2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score2Label.Name = "Score2Label";
            this.Score2Label.Size = new System.Drawing.Size(38, 13);
            this.Score2Label.TabIndex = 2;
            this.Score2Label.Text = "Score:";
            // 
            // Computer2Button
            // 
            this.Computer2Button.Location = new System.Drawing.Point(133, 17);
            this.Computer2Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Computer2Button.Name = "Computer2Button";
            this.Computer2Button.Size = new System.Drawing.Size(98, 23);
            this.Computer2Button.TabIndex = 1;
            this.Computer2Button.Text = "Computer";
            this.Computer2Button.UseVisualStyleBackColor = true;
            this.Computer2Button.Click += new System.EventHandler(this.Computer2Button_Click);
            // 
            // Human2Button
            // 
            this.Human2Button.Location = new System.Drawing.Point(4, 17);
            this.Human2Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Human2Button.Name = "Human2Button";
            this.Human2Button.Size = new System.Drawing.Size(98, 23);
            this.Human2Button.TabIndex = 0;
            this.Human2Button.Text = "Human";
            this.Human2Button.UseVisualStyleBackColor = true;
            this.Human2Button.Click += new System.EventHandler(this.Human2Button_Click);
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.TimeToWaitLabel);
            this.ControlBox.Controls.Add(this.TimeToWaitDropdown);
            this.ControlBox.Controls.Add(this.StepBackButton);
            this.ControlBox.Controls.Add(this.StepForwardButton);
            this.ControlBox.Controls.Add(this.ResetButton);
            this.ControlBox.Controls.Add(this.StartButton);
            this.ControlBox.Location = new System.Drawing.Point(9, 356);
            this.ControlBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ControlBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlBox.Size = new System.Drawing.Size(235, 150);
            this.ControlBox.TabIndex = 17;
            this.ControlBox.TabStop = false;
            this.ControlBox.Text = "Control";
            // 
            // TimeToWaitLabel
            // 
            this.TimeToWaitLabel.AutoSize = true;
            this.TimeToWaitLabel.Location = new System.Drawing.Point(130, 63);
            this.TimeToWaitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeToWaitLabel.Name = "TimeToWaitLabel";
            this.TimeToWaitLabel.Size = new System.Drawing.Size(68, 13);
            this.TimeToWaitLabel.TabIndex = 21;
            this.TimeToWaitLabel.Text = "AI Wait Time";
            // 
            // TimeToWaitDropdown
            // 
            this.TimeToWaitDropdown.FormattingEnabled = true;
            this.TimeToWaitDropdown.Items.AddRange(new object[] {
            "5 seconds",
            "10 seconds",
            "20 seconds",
            "1 minute",
            "No Limit"});
            this.TimeToWaitDropdown.Location = new System.Drawing.Point(133, 78);
            this.TimeToWaitDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeToWaitDropdown.Name = "TimeToWaitDropdown";
            this.TimeToWaitDropdown.Size = new System.Drawing.Size(98, 21);
            this.TimeToWaitDropdown.TabIndex = 20;
            this.TimeToWaitDropdown.SelectedIndexChanged += new System.EventHandler(this.TimeToWaitDropdown_SelectedIndexChanged);
            // 
            // StepBackButton
            // 
            this.StepBackButton.Location = new System.Drawing.Point(4, 106);
            this.StepBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StepBackButton.Name = "StepBackButton";
            this.StepBackButton.Size = new System.Drawing.Size(112, 22);
            this.StepBackButton.TabIndex = 3;
            this.StepBackButton.Text = "Step Backward in Log";
            this.StepBackButton.UseVisualStyleBackColor = true;
            this.StepBackButton.Click += new System.EventHandler(this.StepBackButton_Click);
            // 
            // StepForwardButton
            // 
            this.StepForwardButton.Location = new System.Drawing.Point(4, 67);
            this.StepForwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StepForwardButton.Name = "StepForwardButton";
            this.StepForwardButton.Size = new System.Drawing.Size(112, 22);
            this.StepForwardButton.TabIndex = 2;
            this.StepForwardButton.Text = "Step Forward in Log";
            this.StepForwardButton.UseVisualStyleBackColor = true;
            this.StepForwardButton.Click += new System.EventHandler(this.StepForwardButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(133, 29);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(98, 19);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset Game";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(4, 29);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(98, 19);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CurrentPlayersTurnLabel
            // 
            this.CurrentPlayersTurnLabel.AutoSize = true;
            this.CurrentPlayersTurnLabel.BackColor = System.Drawing.Color.Wheat;
            this.CurrentPlayersTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CurrentPlayersTurnLabel.Location = new System.Drawing.Point(435, 232);
            this.CurrentPlayersTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentPlayersTurnLabel.Name = "CurrentPlayersTurnLabel";
            this.CurrentPlayersTurnLabel.Size = new System.Drawing.Size(286, 31);
            this.CurrentPlayersTurnLabel.TabIndex = 18;
            this.CurrentPlayersTurnLabel.Text = "Current Player\'s Turn: ";
            // 
            // CurrentPlayerTurnButton
            // 
            this.CurrentPlayerTurnButton.BackColor = System.Drawing.Color.LightGray;
            this.CurrentPlayerTurnButton.Location = new System.Drawing.Point(753, 209);
            this.CurrentPlayerTurnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CurrentPlayerTurnButton.Name = "CurrentPlayerTurnButton";
            this.CurrentPlayerTurnButton.Size = new System.Drawing.Size(75, 81);
            this.CurrentPlayerTurnButton.TabIndex = 19;
            this.CurrentPlayerTurnButton.UseVisualStyleBackColor = false;
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImage.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundImage.Image")));
            this.BackgroundImage.Location = new System.Drawing.Point(311, 24);
            this.BackgroundImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(720, 452);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage.TabIndex = 20;
            this.BackgroundImage.TabStop = false;
            // 
            // Pocket7
            // 
            this.Pocket7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket7.Location = new System.Drawing.Point(311, 153);
            this.Pocket7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket7.Name = "Pocket7";
            this.Pocket7.Size = new System.Drawing.Size(105, 190);
            this.Pocket7.TabIndex = 27;
            this.Pocket7.Text = "0";
            this.Pocket7.UseVisualStyleBackColor = false;
            // 
            // Pocket6
            // 
            this.Pocket6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket6.Location = new System.Drawing.Point(382, 50);
            this.Pocket6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket6.Name = "Pocket6";
            this.Pocket6.Size = new System.Drawing.Size(92, 133);
            this.Pocket6.TabIndex = 26;
            this.Pocket6.Text = "0";
            this.Pocket6.UseVisualStyleBackColor = false;
            this.Pocket6.Click += new System.EventHandler(this.Pocket6_Click);
            this.Pocket6.MouseEnter += new System.EventHandler(this.Pocket6_MouseHover);
            this.Pocket6.MouseLeave += new System.EventHandler(this.Pocket6_MouseLeave);
            this.Pocket6.MouseHover += new System.EventHandler(this.Pocket6_MouseHover);
            // 
            // Pocket5
            // 
            this.Pocket5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket5.Location = new System.Drawing.Point(478, 50);
            this.Pocket5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket5.Name = "Pocket5";
            this.Pocket5.Size = new System.Drawing.Size(92, 133);
            this.Pocket5.TabIndex = 25;
            this.Pocket5.Text = "0";
            this.Pocket5.UseVisualStyleBackColor = false;
            this.Pocket5.Click += new System.EventHandler(this.Pocket5_Click);
            this.Pocket5.MouseEnter += new System.EventHandler(this.Pocket5_MouseHover);
            this.Pocket5.MouseLeave += new System.EventHandler(this.Pocket5_MouseLeave);
            this.Pocket5.MouseHover += new System.EventHandler(this.Pocket5_MouseHover);
            // 
            // Pocket4
            // 
            this.Pocket4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket4.Location = new System.Drawing.Point(574, 50);
            this.Pocket4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket4.Name = "Pocket4";
            this.Pocket4.Size = new System.Drawing.Size(92, 133);
            this.Pocket4.TabIndex = 24;
            this.Pocket4.Text = "0";
            this.Pocket4.UseVisualStyleBackColor = false;
            this.Pocket4.Click += new System.EventHandler(this.Pocket4_Click);
            this.Pocket4.MouseEnter += new System.EventHandler(this.Pocket4_MouseHover);
            this.Pocket4.MouseLeave += new System.EventHandler(this.Pocket4_MouseLeave);
            this.Pocket4.MouseHover += new System.EventHandler(this.Pocket4_MouseHover);
            // 
            // Pocket3
            // 
            this.Pocket3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket3.Location = new System.Drawing.Point(670, 50);
            this.Pocket3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket3.Name = "Pocket3";
            this.Pocket3.Size = new System.Drawing.Size(92, 133);
            this.Pocket3.TabIndex = 23;
            this.Pocket3.Text = "0";
            this.Pocket3.UseVisualStyleBackColor = false;
            this.Pocket3.Click += new System.EventHandler(this.Pocket3_Click);
            this.Pocket3.MouseEnter += new System.EventHandler(this.Pocket3_MouseHover);
            this.Pocket3.MouseLeave += new System.EventHandler(this.Pocket3_MouseLeave);
            this.Pocket3.MouseHover += new System.EventHandler(this.Pocket3_MouseHover);
            // 
            // Pocket2
            // 
            this.Pocket2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket2.Location = new System.Drawing.Point(766, 50);
            this.Pocket2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket2.Name = "Pocket2";
            this.Pocket2.Size = new System.Drawing.Size(92, 133);
            this.Pocket2.TabIndex = 22;
            this.Pocket2.Text = "0";
            this.Pocket2.UseVisualStyleBackColor = false;
            this.Pocket2.Click += new System.EventHandler(this.Pocket2_Click);
            this.Pocket2.MouseEnter += new System.EventHandler(this.Pocket2_MouseHover);
            this.Pocket2.MouseLeave += new System.EventHandler(this.Pocket2_MouseLeave);
            this.Pocket2.MouseHover += new System.EventHandler(this.Pocket2_MouseHover);
            // 
            // Pocket1
            // 
            this.Pocket1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pocket1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket1.Location = new System.Drawing.Point(862, 50);
            this.Pocket1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket1.Name = "Pocket1";
            this.Pocket1.Size = new System.Drawing.Size(92, 133);
            this.Pocket1.TabIndex = 21;
            this.Pocket1.Text = "0";
            this.Pocket1.UseVisualStyleBackColor = false;
            this.Pocket1.Click += new System.EventHandler(this.Pocket1_Click);
            this.Pocket1.MouseEnter += new System.EventHandler(this.Pocket1_MouseHover);
            this.Pocket1.MouseLeave += new System.EventHandler(this.Pocket1_MouseLeave);
            this.Pocket1.MouseHover += new System.EventHandler(this.Pocket1_MouseHover);
            // 
            // Pocket8
            // 
            this.Pocket8.BackColor = System.Drawing.Color.Salmon;
            this.Pocket8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket8.Location = new System.Drawing.Point(382, 322);
            this.Pocket8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket8.Name = "Pocket8";
            this.Pocket8.Size = new System.Drawing.Size(92, 133);
            this.Pocket8.TabIndex = 28;
            this.Pocket8.Text = "0";
            this.Pocket8.UseVisualStyleBackColor = false;
            this.Pocket8.Click += new System.EventHandler(this.Pocket8_Click);
            this.Pocket8.MouseEnter += new System.EventHandler(this.Pocket8_MouseHover);
            this.Pocket8.MouseLeave += new System.EventHandler(this.Pocket8_MouseLeave);
            this.Pocket8.MouseHover += new System.EventHandler(this.Pocket8_MouseHover);
            // 
            // Pocket9
            // 
            this.Pocket9.BackColor = System.Drawing.Color.Salmon;
            this.Pocket9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket9.Location = new System.Drawing.Point(478, 322);
            this.Pocket9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket9.Name = "Pocket9";
            this.Pocket9.Size = new System.Drawing.Size(92, 133);
            this.Pocket9.TabIndex = 29;
            this.Pocket9.Text = "0";
            this.Pocket9.UseVisualStyleBackColor = false;
            this.Pocket9.Click += new System.EventHandler(this.Pocket9_Click);
            this.Pocket9.MouseEnter += new System.EventHandler(this.Pocket9_MouseHover);
            this.Pocket9.MouseLeave += new System.EventHandler(this.Pocket9_MouseLeave);
            this.Pocket9.MouseHover += new System.EventHandler(this.Pocket9_MouseHover);
            // 
            // Pocket10
            // 
            this.Pocket10.BackColor = System.Drawing.Color.Salmon;
            this.Pocket10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket10.Location = new System.Drawing.Point(574, 322);
            this.Pocket10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket10.Name = "Pocket10";
            this.Pocket10.Size = new System.Drawing.Size(92, 133);
            this.Pocket10.TabIndex = 30;
            this.Pocket10.Text = "0";
            this.Pocket10.UseVisualStyleBackColor = false;
            this.Pocket10.Click += new System.EventHandler(this.Pocket10_Click);
            this.Pocket10.MouseEnter += new System.EventHandler(this.Pocket10_MouseHover);
            this.Pocket10.MouseLeave += new System.EventHandler(this.Pocket10_MouseLeave);
            this.Pocket10.MouseHover += new System.EventHandler(this.Pocket10_MouseHover);
            // 
            // Pocket11
            // 
            this.Pocket11.BackColor = System.Drawing.Color.Salmon;
            this.Pocket11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket11.Location = new System.Drawing.Point(670, 322);
            this.Pocket11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket11.Name = "Pocket11";
            this.Pocket11.Size = new System.Drawing.Size(92, 133);
            this.Pocket11.TabIndex = 31;
            this.Pocket11.Text = "0";
            this.Pocket11.UseVisualStyleBackColor = false;
            this.Pocket11.Click += new System.EventHandler(this.Pocket11_Click);
            this.Pocket11.MouseEnter += new System.EventHandler(this.Pocket11_MouseHover);
            this.Pocket11.MouseLeave += new System.EventHandler(this.Pocket11_MouseLeave);
            this.Pocket11.MouseHover += new System.EventHandler(this.Pocket11_MouseHover);
            // 
            // Pocket12
            // 
            this.Pocket12.BackColor = System.Drawing.Color.Salmon;
            this.Pocket12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket12.Location = new System.Drawing.Point(766, 322);
            this.Pocket12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket12.Name = "Pocket12";
            this.Pocket12.Size = new System.Drawing.Size(92, 133);
            this.Pocket12.TabIndex = 32;
            this.Pocket12.Text = "0";
            this.Pocket12.UseVisualStyleBackColor = false;
            this.Pocket12.Click += new System.EventHandler(this.Pocket12_Click);
            this.Pocket12.MouseEnter += new System.EventHandler(this.Pocket12_MouseHover);
            this.Pocket12.MouseLeave += new System.EventHandler(this.Pocket12_MouseLeave);
            this.Pocket12.MouseHover += new System.EventHandler(this.Pocket12_MouseHover);
            // 
            // Pocket13
            // 
            this.Pocket13.BackColor = System.Drawing.Color.Salmon;
            this.Pocket13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket13.Location = new System.Drawing.Point(862, 322);
            this.Pocket13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket13.Name = "Pocket13";
            this.Pocket13.Size = new System.Drawing.Size(92, 133);
            this.Pocket13.TabIndex = 33;
            this.Pocket13.Text = "0";
            this.Pocket13.UseVisualStyleBackColor = false;
            this.Pocket13.Click += new System.EventHandler(this.Pocket13_Click);
            this.Pocket13.MouseEnter += new System.EventHandler(this.Pocket13_MouseHover);
            this.Pocket13.MouseLeave += new System.EventHandler(this.Pocket13_MouseLeave);
            this.Pocket13.MouseHover += new System.EventHandler(this.Pocket13_MouseHover);
            // 
            // Pocket14
            // 
            this.Pocket14.BackColor = System.Drawing.Color.Salmon;
            this.Pocket14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Pocket14.Location = new System.Drawing.Point(919, 153);
            this.Pocket14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pocket14.Name = "Pocket14";
            this.Pocket14.Size = new System.Drawing.Size(105, 190);
            this.Pocket14.TabIndex = 34;
            this.Pocket14.Text = "0";
            this.Pocket14.UseVisualStyleBackColor = false;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.BackColor = System.Drawing.Color.Wheat;
            this.Player1Label.Location = new System.Drawing.Point(335, 105);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(42, 13);
            this.Player1Label.TabIndex = 35;
            this.Player1Label.Text = "Player1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.BackColor = System.Drawing.Color.Wheat;
            this.Player2Label.Location = new System.Drawing.Point(335, 391);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(42, 13);
            this.Player2Label.TabIndex = 36;
            this.Player2Label.Text = "Player2";
            // 
            // MancalaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 524);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Pocket14);
            this.Controls.Add(this.Pocket13);
            this.Controls.Add(this.Pocket12);
            this.Controls.Add(this.Pocket11);
            this.Controls.Add(this.Pocket10);
            this.Controls.Add(this.Pocket9);
            this.Controls.Add(this.Pocket8);
            this.Controls.Add(this.Pocket7);
            this.Controls.Add(this.Pocket6);
            this.Controls.Add(this.Pocket5);
            this.Controls.Add(this.Pocket4);
            this.Controls.Add(this.Pocket3);
            this.Controls.Add(this.Pocket2);
            this.Controls.Add(this.Pocket1);
            this.Controls.Add(this.CurrentPlayersTurnLabel);
            this.Controls.Add(this.CurrentPlayerTurnButton);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.Player2Box);
            this.Controls.Add(this.Player1Box);
            this.Controls.Add(this.BackgroundImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MancalaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mancala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Player1Box.ResumeLayout(false);
            this.Player1Box.PerformLayout();
            this.Player2Box.ResumeLayout(false);
            this.Player2Box.PerformLayout();
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Player1Box;
        private System.Windows.Forms.Button Human1Button;
        private System.Windows.Forms.Label Score1Text;
        private System.Windows.Forms.Label Score1Label;
        private System.Windows.Forms.Button Computer1Button;
        private System.Windows.Forms.CheckBox Player1ConsoleWindowCheck;
        private System.Windows.Forms.GroupBox Player2Box;
        private System.Windows.Forms.CheckBox Player2ConsoleWindowCheck;
        private System.Windows.Forms.Label Score2Text;
        private System.Windows.Forms.Label Score2Label;
        private System.Windows.Forms.Button Computer2Button;
        private System.Windows.Forms.Button Human2Button;
        private System.Windows.Forms.GroupBox ControlBox;
        private System.Windows.Forms.Button StepBackButton;
        private System.Windows.Forms.Button StepForwardButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label CurrentPlayersTurnLabel;
        private System.Windows.Forms.Button CurrentPlayerTurnButton;
        private System.Windows.Forms.Label HumanComputerLabel1;
        private System.Windows.Forms.Label HumanComputerLabel2;
        private System.Windows.Forms.Label TimeToWaitLabel;
        private System.Windows.Forms.ComboBox TimeToWaitDropdown;
        private System.Windows.Forms.PictureBox BackgroundImage;
        private RoundButton Pocket1;
        private RoundButton Pocket2;
        private RoundButton Pocket3;
        private RoundButton Pocket4;
        private RoundButton Pocket5;
        private RoundButton Pocket6;
        private RoundButton Pocket7;
        private RoundButton Pocket8;
        private RoundButton Pocket9;
        private RoundButton Pocket10;
        private RoundButton Pocket11;
        private RoundButton Pocket12;
        private RoundButton Pocket13;
        private RoundButton Pocket14;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
    }
}

