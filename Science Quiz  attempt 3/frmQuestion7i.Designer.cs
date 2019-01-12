namespace Science_Quiz__attempt_3
{
    partial class frmQuestion7i
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMidday = new System.Windows.Forms.Button();
            this.btnMorning = new System.Windows.Forms.Button();
            this.btnEarlyEvening = new System.Windows.Forms.Button();
            this.btnMidafternoon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCharacter = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.NextQuestion = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.UserTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerName.Location = new System.Drawing.Point(49, 124);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerName.TabIndex = 15;
            this.lblPlayerName.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(50, 177);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(48, 18);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "On a clear day on June, John noticed that his shadow was ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(205, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "pointing in a westernly direction, what time of day do youy think it is?";
            // 
            // btnMidday
            // 
            this.btnMidday.Location = new System.Drawing.Point(238, 121);
            this.btnMidday.Name = "btnMidday";
            this.btnMidday.Size = new System.Drawing.Size(117, 41);
            this.btnMidday.TabIndex = 19;
            this.btnMidday.Text = "Midday";
            this.btnMidday.UseVisualStyleBackColor = true;
            this.btnMidday.Click += new System.EventHandler(this.btnMidday_Click);
            // 
            // btnMorning
            // 
            this.btnMorning.Location = new System.Drawing.Point(513, 124);
            this.btnMorning.Name = "btnMorning";
            this.btnMorning.Size = new System.Drawing.Size(117, 41);
            this.btnMorning.TabIndex = 20;
            this.btnMorning.Text = "Morning";
            this.btnMorning.UseVisualStyleBackColor = true;
            this.btnMorning.Click += new System.EventHandler(this.btnMorning_Click);
            // 
            // btnEarlyEvening
            // 
            this.btnEarlyEvening.Location = new System.Drawing.Point(238, 244);
            this.btnEarlyEvening.Name = "btnEarlyEvening";
            this.btnEarlyEvening.Size = new System.Drawing.Size(117, 41);
            this.btnEarlyEvening.TabIndex = 21;
            this.btnEarlyEvening.Text = "early evening";
            this.btnEarlyEvening.UseVisualStyleBackColor = true;
            this.btnEarlyEvening.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMidafternoon
            // 
            this.btnMidafternoon.Location = new System.Drawing.Point(513, 244);
            this.btnMidafternoon.Name = "btnMidafternoon";
            this.btnMidafternoon.Size = new System.Drawing.Size(117, 41);
            this.btnMidafternoon.TabIndex = 22;
            this.btnMidafternoon.Text = "midafternoon";
            this.btnMidafternoon.UseVisualStyleBackColor = true;
            this.btnMidafternoon.Click += new System.EventHandler(this.btnMidafternoon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(161, -49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 471);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureCharacter
            // 
            this.pictureCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureCharacter.Location = new System.Drawing.Point(12, 12);
            this.pictureCharacter.Name = "pictureCharacter";
            this.pictureCharacter.Size = new System.Drawing.Size(133, 109);
            this.pictureCharacter.TabIndex = 13;
            this.pictureCharacter.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Science_Quiz__attempt_3.Properties.Resources.Shadow;
            this.pictureBox2.Location = new System.Drawing.Point(161, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 386);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(13, 320);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(132, 23);
            this.btnHelp.TabIndex = 37;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(14, 349);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(132, 23);
            this.btnRestart.TabIndex = 36;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // NextQuestion
            // 
            this.NextQuestion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(50, 289);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 18);
            this.lblTime.TabIndex = 91;
            this.lblTime.Text = "Timer  :  ";
            // 
            // UserTimer
            // 
            this.UserTimer.Interval = 1000;
            this.UserTimer.Tick += new System.EventHandler(this.UserTimer_Tick);
            // 
            // frmQuestion7i
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnMidafternoon);
            this.Controls.Add(this.btnEarlyEvening);
            this.Controls.Add(this.btnMorning);
            this.Controls.Add(this.btnMidday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureCharacter);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmQuestion7i";
            this.Text = "frmQuestion7i";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCharacter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMidday;
        private System.Windows.Forms.Button btnMorning;
        private System.Windows.Forms.Button btnEarlyEvening;
        private System.Windows.Forms.Button btnMidafternoon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer NextQuestion;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer UserTimer;
    }
}