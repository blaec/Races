namespace LabRaces
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.dogToWin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.activeBettor = new System.Windows.Forms.Label();
            this.placeBet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(0, -2);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(600, 200);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(0, 12);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(0, 58);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(0, 111);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(0, 166);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // bettingParlor
            // 
            this.bettingParlor.Controls.Add(this.dogToWin);
            this.bettingParlor.Controls.Add(this.label3);
            this.bettingParlor.Controls.Add(this.betAmount);
            this.bettingParlor.Controls.Add(this.activeBettor);
            this.bettingParlor.Controls.Add(this.placeBet);
            this.bettingParlor.Controls.Add(this.button1);
            this.bettingParlor.Controls.Add(this.alBetLabel);
            this.bettingParlor.Controls.Add(this.bobBetLabel);
            this.bettingParlor.Controls.Add(this.joeBetLabel);
            this.bettingParlor.Controls.Add(this.label1);
            this.bettingParlor.Controls.Add(this.alRadioButton);
            this.bettingParlor.Controls.Add(this.bobRadioButton);
            this.bettingParlor.Controls.Add(this.joeRadioButton);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Location = new System.Drawing.Point(12, 204);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(576, 228);
            this.bettingParlor.TabIndex = 5;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Parlor";
            // 
            // dogToWin
            // 
            this.dogToWin.Location = new System.Drawing.Point(324, 190);
            this.dogToWin.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogToWin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogToWin.Name = "dogToWin";
            this.dogToWin.Size = new System.Drawing.Size(55, 23);
            this.dogToWin.TabIndex = 11;
            this.dogToWin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "bucks on dog number";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(134, 190);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(54, 23);
            this.betAmount.TabIndex = 9;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // activeBettor
            // 
            this.activeBettor.Location = new System.Drawing.Point(10, 194);
            this.activeBettor.Name = "activeBettor";
            this.activeBettor.Size = new System.Drawing.Size(37, 15);
            this.activeBettor.TabIndex = 8;
            this.activeBettor.Text = "name";
            this.activeBettor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // placeBet
            // 
            this.placeBet.Location = new System.Drawing.Point(53, 190);
            this.placeBet.Name = "placeBet";
            this.placeBet.Size = new System.Drawing.Size(75, 23);
            this.placeBet.TabIndex = 7;
            this.placeBet.Text = "Bets";
            this.placeBet.UseVisualStyleBackColor = true;
            this.placeBet.Click += new System.EventHandler(this.placeBet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 146);
            this.button1.TabIndex = 6;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(190, 145);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(189, 23);
            this.alBetLabel.TabIndex = 5;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(190, 106);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(189, 23);
            this.bobBetLabel.TabIndex = 5;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(190, 67);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(189, 23);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bets";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 147);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(100, 19);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 108);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(112, 19);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 69);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(107, 19);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimumBetLabel.Location = new System.Drawing.Point(10, 34);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(109, 15);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 444);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races!";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.NumericUpDown dogToWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label activeBettor;
        private System.Windows.Forms.Button placeBet;
        private System.Windows.Forms.Timer timer1;
    }
}

