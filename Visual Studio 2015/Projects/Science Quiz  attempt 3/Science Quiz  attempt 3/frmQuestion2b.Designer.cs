namespace Science_Quiz__attempt_3
{
    partial class frmQuestion2b
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSatement1 = new System.Windows.Forms.Button();
            this.btnSatement2 = new System.Windows.Forms.Button();
            this.btnStatement3 = new System.Windows.Forms.Button();
            this.btnStatement4 = new System.Windows.Forms.Button();
            this.btnStatement5 = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblanswer3 = new System.Windows.Forms.Label();
            this.lblanswer4 = new System.Windows.Forms.Label();
            this.lblanswer5 = new System.Windows.Forms.Label();
            this.lblanswer6 = new System.Windows.Forms.Label();
            this.lblanswer7 = new System.Windows.Forms.Label();
            this.lblanswer8 = new System.Windows.Forms.Label();
            this.btnStatement6 = new System.Windows.Forms.Button();
            this.btnStatement7 = new System.Windows.Forms.Button();
            this.btnStatement8 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.AnswerCheck = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureCharacter = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.UserTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnResetQuestion = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.NewQuestion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerName.Location = new System.Drawing.Point(52, 124);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(53, 174);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 18);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(498, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Are the following statements true or false";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "True";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "False";
            // 
            // btnSatement1
            // 
            this.btnSatement1.Location = new System.Drawing.Point(609, 108);
            this.btnSatement1.Name = "btnSatement1";
            this.btnSatement1.Size = new System.Drawing.Size(138, 23);
            this.btnSatement1.TabIndex = 17;
            this.btnSatement1.Text = "The Earth orbits the sun";
            this.btnSatement1.UseVisualStyleBackColor = true;
            this.btnSatement1.Click += new System.EventHandler(this.button1_Click);
            this.btnSatement1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSatement1_MouseDown);
            // 
            // btnSatement2
            // 
            this.btnSatement2.Location = new System.Drawing.Point(571, 137);
            this.btnSatement2.Name = "btnSatement2";
            this.btnSatement2.Size = new System.Drawing.Size(210, 23);
            this.btnSatement2.TabIndex = 18;
            this.btnSatement2.Text = "The sun is the closest planet to the Earth";
            this.btnSatement2.UseVisualStyleBackColor = true;
            this.btnSatement2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSatement2_MouseDown);
            // 
            // btnStatement3
            // 
            this.btnStatement3.Location = new System.Drawing.Point(553, 166);
            this.btnStatement3.Name = "btnStatement3";
            this.btnStatement3.Size = new System.Drawing.Size(240, 23);
            this.btnStatement3.TabIndex = 19;
            this.btnStatement3.Text = "Our solar system is named after a chocolate bar";
            this.btnStatement3.UseVisualStyleBackColor = true;
            this.btnStatement3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStatement3_MouseDown);
            // 
            // btnStatement4
            // 
            this.btnStatement4.Location = new System.Drawing.Point(618, 195);
            this.btnStatement4.Name = "btnStatement4";
            this.btnStatement4.Size = new System.Drawing.Size(119, 23);
            this.btnStatement4.TabIndex = 20;
            this.btnStatement4.Text = "The sun is a star";
            this.btnStatement4.UseVisualStyleBackColor = true;
            this.btnStatement4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStatement4_MouseDown);
            // 
            // btnStatement5
            // 
            this.btnStatement5.Location = new System.Drawing.Point(599, 224);
            this.btnStatement5.Name = "btnStatement5";
            this.btnStatement5.Size = new System.Drawing.Size(166, 23);
            this.btnStatement5.TabIndex = 21;
            this.btnStatement5.Text = "The moon is a satalite";
            this.btnStatement5.UseVisualStyleBackColor = true;
            this.btnStatement5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStatement5_MouseDown);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AllowDrop = true;
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.BackColor = System.Drawing.Color.Tan;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(275, 128);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(168, 16);
            this.lblAnswer1.TabIndex = 22;
            this.lblAnswer1.Text = "----------------------------------------";
            this.lblAnswer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblAnswer1_DragDrop);
            this.lblAnswer1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblAnswer1_DragEnter);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AllowDrop = true;
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.BackColor = System.Drawing.Color.Tan;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(275, 198);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(168, 16);
            this.lblAnswer2.TabIndex = 23;
            this.lblAnswer2.Text = "----------------------------------------";
            this.lblAnswer2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblAnswer2_DragDrop);
            this.lblAnswer2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblAnswer2_DragEnter);
            // 
            // lblanswer3
            // 
            this.lblanswer3.AllowDrop = true;
            this.lblanswer3.AutoSize = true;
            this.lblanswer3.BackColor = System.Drawing.Color.Tan;
            this.lblanswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer3.Location = new System.Drawing.Point(275, 260);
            this.lblanswer3.Name = "lblanswer3";
            this.lblanswer3.Size = new System.Drawing.Size(168, 16);
            this.lblanswer3.TabIndex = 24;
            this.lblanswer3.Text = "----------------------------------------";
            this.lblanswer3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblanswer3_DragDrop);
            this.lblanswer3.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblanswer3_DragEnter);
            // 
            // lblanswer4
            // 
            this.lblanswer4.AllowDrop = true;
            this.lblanswer4.AutoSize = true;
            this.lblanswer4.BackColor = System.Drawing.Color.Tan;
            this.lblanswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer4.Location = new System.Drawing.Point(275, 328);
            this.lblanswer4.Name = "lblanswer4";
            this.lblanswer4.Size = new System.Drawing.Size(168, 16);
            this.lblanswer4.TabIndex = 25;
            this.lblanswer4.Text = "----------------------------------------";
            this.lblanswer4.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblanswer4_DragDrop);
            this.lblanswer4.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblanswer4_DragEnter);
            // 
            // lblanswer5
            // 
            this.lblanswer5.AllowDrop = true;
            this.lblanswer5.AutoSize = true;
            this.lblanswer5.BackColor = System.Drawing.Color.Tan;
            this.lblanswer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer5.Location = new System.Drawing.Point(909, 128);
            this.lblanswer5.Name = "lblanswer5";
            this.lblanswer5.Size = new System.Drawing.Size(168, 16);
            this.lblanswer5.TabIndex = 26;
            this.lblanswer5.Text = "----------------------------------------";
            this.lblanswer5.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblanswer5_DragDrop);
            this.lblanswer5.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblanswer5_DragEnter);
            // 
            // lblanswer6
            // 
            this.lblanswer6.AllowDrop = true;
            this.lblanswer6.AutoSize = true;
            this.lblanswer6.BackColor = System.Drawing.Color.Tan;
            this.lblanswer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer6.Location = new System.Drawing.Point(909, 195);
            this.lblanswer6.Name = "lblanswer6";
            this.lblanswer6.Size = new System.Drawing.Size(168, 16);
            this.lblanswer6.TabIndex = 27;
            this.lblanswer6.Text = "----------------------------------------";
            this.lblanswer6.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblanswer6_DragDrop);
            this.lblanswer6.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblanswer6_DragEnter);
            // 
            // lblanswer7
            // 
            this.lblanswer7.AllowDrop = true;
            this.lblanswer7.AutoSize = true;
            this.lblanswer7.BackColor = System.Drawing.Color.Tan;
            this.lblanswer7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer7.Location = new System.Drawing.Point(909, 260);
            this.lblanswer7.Name = "lblanswer7";
            this.lblanswer7.Size = new System.Drawing.Size(168, 16);
            this.lblanswer7.TabIndex = 28;
            this.lblanswer7.Text = "----------------------------------------";
            this.lblanswer7.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblanswer7_DragDrop);
            this.lblanswer7.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblanswer7_DragEnter);
            // 
            // lblanswer8
            // 
            this.lblanswer8.AllowDrop = true;
            this.lblanswer8.AutoSize = true;
            this.lblanswer8.BackColor = System.Drawing.Color.Tan;
            this.lblanswer8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer8.Location = new System.Drawing.Point(909, 328);
            this.lblanswer8.Name = "lblanswer8";
            this.lblanswer8.Size = new System.Drawing.Size(168, 16);
            this.lblanswer8.TabIndex = 29;
            this.lblanswer8.Text = "----------------------------------------";
            this.lblanswer8.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblanswer8_DragDrop);
            this.lblanswer8.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblanswer8_DragEnter);
            // 
            // btnStatement6
            // 
            this.btnStatement6.Location = new System.Drawing.Point(553, 253);
            this.btnStatement6.Name = "btnStatement6";
            this.btnStatement6.Size = new System.Drawing.Size(257, 23);
            this.btnStatement6.TabIndex = 30;
            this.btnStatement6.Text = "When the moon blocks the sun, it is a solar eclipse";
            this.btnStatement6.UseVisualStyleBackColor = true;
            this.btnStatement6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStatement6_MouseDown);
            // 
            // btnStatement7
            // 
            this.btnStatement7.Location = new System.Drawing.Point(571, 282);
            this.btnStatement7.Name = "btnStatement7";
            this.btnStatement7.Size = new System.Drawing.Size(210, 23);
            this.btnStatement7.TabIndex = 31;
            this.btnStatement7.Text = "Gravity is a man-made force";
            this.btnStatement7.UseVisualStyleBackColor = true;
            this.btnStatement7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStatement7_MouseDown);
            // 
            // btnStatement8
            // 
            this.btnStatement8.Location = new System.Drawing.Point(565, 311);
            this.btnStatement8.Name = "btnStatement8";
            this.btnStatement8.Size = new System.Drawing.Size(228, 23);
            this.btnStatement8.TabIndex = 32;
            this.btnStatement8.Text = "It is impossible for a sun to die";
            this.btnStatement8.UseVisualStyleBackColor = true;
            this.btnStatement8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStatement8_MouseDown);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirm.Location = new System.Drawing.Point(502, 417);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 32);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AnswerCheck
            // 
            this.AnswerCheck.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Tan;
            this.pictureBox3.Location = new System.Drawing.Point(822, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(322, 316);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Location = new System.Drawing.Point(211, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 316);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(161, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 477);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureCharacter
            // 
            this.pictureCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pictureCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureCharacter.Location = new System.Drawing.Point(12, 12);
            this.pictureCharacter.Name = "pictureCharacter";
            this.pictureCharacter.Size = new System.Drawing.Size(133, 109);
            this.pictureCharacter.TabIndex = 8;
            this.pictureCharacter.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 403);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(132, 23);
            this.btnHelp.TabIndex = 35;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(13, 432);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(132, 23);
            this.btnRestart.TabIndex = 34;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(33, 373);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 18);
            this.lblTime.TabIndex = 39;
            this.lblTime.Text = "Timer  :  ";
            // 
            // UserTimer
            // 
            this.UserTimer.Interval = 1000;
            this.UserTimer.Tick += new System.EventHandler(this.UserTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(499, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Drag the correct statements to the lines in the boxes";
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // btnResetQuestion
            // 
            this.btnResetQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetQuestion.Location = new System.Drawing.Point(706, 417);
            this.btnResetQuestion.Name = "btnResetQuestion";
            this.btnResetQuestion.Size = new System.Drawing.Size(138, 32);
            this.btnResetQuestion.TabIndex = 41;
            this.btnResetQuestion.Text = "Reset Question";
            this.btnResetQuestion.UseVisualStyleBackColor = false;
            this.btnResetQuestion.Click += new System.EventHandler(this.btnResetQuestion_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.Location = new System.Drawing.Point(584, 384);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(181, 18);
            this.lblError.TabIndex = 42;
            this.lblError.Text = "Please drag all statements";
            // 
            // NewQuestion
            // 
            this.NewQuestion.Tick += new System.EventHandler(this.NewQuestion_Tick);
            // 
            // frmQuestion2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1168, 461);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnResetQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnStatement8);
            this.Controls.Add(this.btnStatement7);
            this.Controls.Add(this.btnStatement6);
            this.Controls.Add(this.lblanswer8);
            this.Controls.Add(this.lblanswer7);
            this.Controls.Add(this.lblanswer6);
            this.Controls.Add(this.lblanswer5);
            this.Controls.Add(this.lblanswer4);
            this.Controls.Add(this.lblanswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnStatement5);
            this.Controls.Add(this.btnStatement4);
            this.Controls.Add(this.btnStatement3);
            this.Controls.Add(this.btnSatement2);
            this.Controls.Add(this.btnSatement1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pictureCharacter);
            this.Name = "frmQuestion2b";
            this.Text = "Beginner Question";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCharacter;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatement1;
        private System.Windows.Forms.Button btnSatement2;
        private System.Windows.Forms.Button btnStatement3;
        private System.Windows.Forms.Button btnStatement4;
        private System.Windows.Forms.Button btnStatement5;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblanswer3;
        private System.Windows.Forms.Label lblanswer4;
        private System.Windows.Forms.Label lblanswer5;
        private System.Windows.Forms.Label lblanswer6;
        private System.Windows.Forms.Label lblanswer7;
        private System.Windows.Forms.Label lblanswer8;
        private System.Windows.Forms.Button btnStatement6;
        private System.Windows.Forms.Button btnStatement7;
        private System.Windows.Forms.Button btnStatement8;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Timer AnswerCheck;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer UserTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ErrorTimer;
        private System.Windows.Forms.Button btnResetQuestion;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer NewQuestion;
    }
}