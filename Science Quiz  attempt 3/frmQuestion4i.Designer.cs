namespace Science_Quiz__attempt_3
{
    partial class frmQuestion4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCharacter = new System.Windows.Forms.PictureBox();
            this.cbQuestion1 = new System.Windows.Forms.CheckBox();
            this.cbQuestion2 = new System.Windows.Forms.CheckBox();
            this.cbQuestion3 = new System.Windows.Forms.CheckBox();
            this.cbQuestion4 = new System.Windows.Forms.CheckBox();
            this.cbQuestion5 = new System.Windows.Forms.CheckBox();
            this.cbQuestion6 = new System.Windows.Forms.CheckBox();
            this.cbQuestion7 = new System.Windows.Forms.CheckBox();
            this.cbQuestion8 = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.NextQuestion = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.UserTimer = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Which of the following statements are true?";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(50, 190);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(48, 18);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Score";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerName.Location = new System.Drawing.Point(49, 124);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerName.TabIndex = 13;
            this.lblPlayerName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(164, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 471);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureCharacter
            // 
            this.pictureCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureCharacter.Location = new System.Drawing.Point(12, 12);
            this.pictureCharacter.Name = "pictureCharacter";
            this.pictureCharacter.Size = new System.Drawing.Size(133, 109);
            this.pictureCharacter.TabIndex = 11;
            this.pictureCharacter.TabStop = false;
            // 
            // cbQuestion1
            // 
            this.cbQuestion1.AutoSize = true;
            this.cbQuestion1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion1.Location = new System.Drawing.Point(180, 75);
            this.cbQuestion1.Name = "cbQuestion1";
            this.cbQuestion1.Size = new System.Drawing.Size(301, 17);
            this.cbQuestion1.TabIndex = 16;
            this.cbQuestion1.Text = "Global warming is caused by increased Earth temperatures";
            this.cbQuestion1.UseVisualStyleBackColor = true;
            this.cbQuestion1.CheckedChanged += new System.EventHandler(this.cbQuestion1_CheckedChanged);
            // 
            // cbQuestion2
            // 
            this.cbQuestion2.AutoSize = true;
            this.cbQuestion2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion2.Location = new System.Drawing.Point(180, 125);
            this.cbQuestion2.Name = "cbQuestion2";
            this.cbQuestion2.Size = new System.Drawing.Size(234, 17);
            this.cbQuestion2.TabIndex = 17;
            this.cbQuestion2.Text = "Bio-fuels are more enviormentla friendly fuels";
            this.cbQuestion2.UseVisualStyleBackColor = true;
            this.cbQuestion2.CheckedChanged += new System.EventHandler(this.cbQuestion2_CheckedChanged);
            // 
            // cbQuestion3
            // 
            this.cbQuestion3.AutoSize = true;
            this.cbQuestion3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion3.Location = new System.Drawing.Point(180, 190);
            this.cbQuestion3.Name = "cbQuestion3";
            this.cbQuestion3.Size = new System.Drawing.Size(210, 17);
            this.cbQuestion3.TabIndex = 18;
            this.cbQuestion3.Text = "Fossil fuels are good for the enviorment";
            this.cbQuestion3.UseVisualStyleBackColor = true;
            this.cbQuestion3.CheckedChanged += new System.EventHandler(this.cbQuestion3_CheckedChanged);
            // 
            // cbQuestion4
            // 
            this.cbQuestion4.AutoSize = true;
            this.cbQuestion4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion4.Location = new System.Drawing.Point(180, 248);
            this.cbQuestion4.Name = "cbQuestion4";
            this.cbQuestion4.Size = new System.Drawing.Size(217, 17);
            this.cbQuestion4.TabIndex = 19;
            this.cbQuestion4.Text = "Cutting down tress helps the atmosphere";
            this.cbQuestion4.UseVisualStyleBackColor = true;
            this.cbQuestion4.CheckedChanged += new System.EventHandler(this.cbQuestion4_CheckedChanged);
            // 
            // cbQuestion5
            // 
            this.cbQuestion5.AutoSize = true;
            this.cbQuestion5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion5.Location = new System.Drawing.Point(509, 75);
            this.cbQuestion5.Name = "cbQuestion5";
            this.cbQuestion5.Size = new System.Drawing.Size(230, 17);
            this.cbQuestion5.TabIndex = 20;
            this.cbQuestion5.Text = "Global warming causes the ice caps to melt";
            this.cbQuestion5.UseVisualStyleBackColor = true;
            this.cbQuestion5.CheckedChanged += new System.EventHandler(this.cbQuestion5_CheckedChanged);
            // 
            // cbQuestion6
            // 
            this.cbQuestion6.AutoSize = true;
            this.cbQuestion6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion6.Location = new System.Drawing.Point(509, 128);
            this.cbQuestion6.Name = "cbQuestion6";
            this.cbQuestion6.Size = new System.Drawing.Size(261, 17);
            this.cbQuestion6.TabIndex = 21;
            this.cbQuestion6.Text = "Nucular waste can be used to speed plant growth";
            this.cbQuestion6.UseVisualStyleBackColor = true;
            this.cbQuestion6.CheckedChanged += new System.EventHandler(this.cbQuestion6_CheckedChanged);
            // 
            // cbQuestion7
            // 
            this.cbQuestion7.AutoSize = true;
            this.cbQuestion7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion7.Location = new System.Drawing.Point(509, 190);
            this.cbQuestion7.Name = "cbQuestion7";
            this.cbQuestion7.Size = new System.Drawing.Size(311, 17);
            this.cbQuestion7.TabIndex = 22;
            this.cbQuestion7.Text = "Spraying lots of airsoles slows the progress of global warming";
            this.cbQuestion7.UseVisualStyleBackColor = true;
            this.cbQuestion7.CheckedChanged += new System.EventHandler(this.cbQuestion7_CheckedChanged);
            // 
            // cbQuestion8
            // 
            this.cbQuestion8.AutoSize = true;
            this.cbQuestion8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbQuestion8.Location = new System.Drawing.Point(509, 248);
            this.cbQuestion8.Name = "cbQuestion8";
            this.cbQuestion8.Size = new System.Drawing.Size(198, 17);
            this.cbQuestion8.TabIndex = 23;
            this.cbQuestion8.Text = "Nucular waste harms the enviorment";
            this.cbQuestion8.UseVisualStyleBackColor = true;
            this.cbQuestion8.CheckedChanged += new System.EventHandler(this.cbQuestion8_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(725, 346);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Continue";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // NextQuestion
            // 
            this.NextQuestion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Science_Quiz__attempt_3.Properties.Resources.CoalFactory;
            this.pictureBox2.Location = new System.Drawing.Point(164, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(668, 393);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(13, 319);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(132, 23);
            this.btnHelp.TabIndex = 37;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(14, 348);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(132, 23);
            this.btnRestart.TabIndex = 36;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(50, 282);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 18);
            this.lblTime.TabIndex = 85;
            this.lblTime.Text = "Timer  :  ";
            // 
            // UserTimer
            // 
            this.UserTimer.Interval = 1000;
            this.UserTimer.Tick += new System.EventHandler(this.UserTimer_Tick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.Location = new System.Drawing.Point(566, 349);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(153, 16);
            this.lblError.TabIndex = 86;
            this.lblError.Text = "Please select 4 answers";
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // frmQuestion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbQuestion8);
            this.Controls.Add(this.cbQuestion7);
            this.Controls.Add(this.cbQuestion6);
            this.Controls.Add(this.cbQuestion5);
            this.Controls.Add(this.cbQuestion4);
            this.Controls.Add(this.cbQuestion3);
            this.Controls.Add(this.cbQuestion2);
            this.Controls.Add(this.cbQuestion1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureCharacter);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmQuestion4";
            this.Text = "Intermediate Question";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureCharacter;
        private System.Windows.Forms.CheckBox cbQuestion1;
        private System.Windows.Forms.CheckBox cbQuestion2;
        private System.Windows.Forms.CheckBox cbQuestion3;
        private System.Windows.Forms.CheckBox cbQuestion4;
        private System.Windows.Forms.CheckBox cbQuestion5;
        private System.Windows.Forms.CheckBox cbQuestion6;
        private System.Windows.Forms.CheckBox cbQuestion7;
        private System.Windows.Forms.CheckBox cbQuestion8;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Timer NextQuestion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer UserTimer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer ErrorTimer;
    }
}