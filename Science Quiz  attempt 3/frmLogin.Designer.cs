namespace Science_Quiz__attempt_3
{
    partial class frmLogin
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
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAvatarInstruct = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Timer(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCharacter4 = new System.Windows.Forms.Button();
            this.btnCharater3 = new System.Windows.Forms.Button();
            this.btnCharacter2 = new System.Windows.Forms.Button();
            this.btnCharacter1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Errorclock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(13, 224);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(670, 23);
            this.loadingBar.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProgress.Location = new System.Drawing.Point(305, 208);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "Progress";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPercentage.Location = new System.Drawing.Point(331, 195);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 9;
            this.lblPercentage.Text = "Percentage";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(12, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 24);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPass.Location = new System.Drawing.Point(12, 74);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(97, 24);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(120, 78);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(209, 20);
            this.txtPass.TabIndex = 13;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.Location = new System.Drawing.Point(117, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(83, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error message 1";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 129);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAvatarInstruct
            // 
            this.lblAvatarInstruct.AutoSize = true;
            this.lblAvatarInstruct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvatarInstruct.Location = new System.Drawing.Point(430, 32);
            this.lblAvatarInstruct.Name = "lblAvatarInstruct";
            this.lblAvatarInstruct.Size = new System.Drawing.Size(70, 13);
            this.lblAvatarInstruct.TabIndex = 27;
            this.lblAvatarInstruct.Text = "Select avatar";
            // 
            // Load
            // 
            this.Load.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(254, 129);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCharacter4
            // 
            this.btnCharacter4.BackgroundImage = global::Science_Quiz__attempt_3.Properties.Resources.Predator2;
            this.btnCharacter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCharacter4.Location = new System.Drawing.Point(565, 131);
            this.btnCharacter4.Name = "btnCharacter4";
            this.btnCharacter4.Size = new System.Drawing.Size(100, 69);
            this.btnCharacter4.TabIndex = 32;
            this.btnCharacter4.UseVisualStyleBackColor = true;
            this.btnCharacter4.Click += new System.EventHandler(this.btnCharacter4_Click);
            // 
            // btnCharater3
            // 
            this.btnCharater3.BackgroundImage = global::Science_Quiz__attempt_3.Properties.Resources.NeilArmstrong;
            this.btnCharater3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCharater3.Location = new System.Drawing.Point(459, 129);
            this.btnCharater3.Name = "btnCharater3";
            this.btnCharater3.Size = new System.Drawing.Size(100, 72);
            this.btnCharater3.TabIndex = 31;
            this.btnCharater3.UseVisualStyleBackColor = true;
            this.btnCharater3.Click += new System.EventHandler(this.btnCharater3_Click);
            // 
            // btnCharacter2
            // 
            this.btnCharacter2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCharacter2.BackgroundImage = global::Science_Quiz__attempt_3.Properties.Resources.CharacterPlaceholder2;
            this.btnCharacter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCharacter2.Location = new System.Drawing.Point(565, 55);
            this.btnCharacter2.Name = "btnCharacter2";
            this.btnCharacter2.Size = new System.Drawing.Size(100, 69);
            this.btnCharacter2.TabIndex = 30;
            this.btnCharacter2.UseVisualStyleBackColor = false;
            this.btnCharacter2.Click += new System.EventHandler(this.btnCharacter2_Click);
            // 
            // btnCharacter1
            // 
            this.btnCharacter1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCharacter1.BackgroundImage = global::Science_Quiz__attempt_3.Properties.Resources.CharacterPlaceholder;
            this.btnCharacter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCharacter1.Location = new System.Drawing.Point(459, 55);
            this.btnCharacter1.Name = "btnCharacter1";
            this.btnCharacter1.Size = new System.Drawing.Size(100, 69);
            this.btnCharacter1.TabIndex = 29;
            this.btnCharacter1.UseVisualStyleBackColor = false;
            this.btnCharacter1.Click += new System.EventHandler(this.btnCharacter1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Errorclock
            // 
            this.Errorclock.Interval = 1000;
            this.Errorclock.Tick += new System.EventHandler(this.avatarcount_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(695, 259);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCharacter4);
            this.Controls.Add(this.btnCharater3);
            this.Controls.Add(this.btnCharacter2);
            this.Controls.Add(this.btnCharacter1);
            this.Controls.Add(this.lblAvatarInstruct);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.loadingBar);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAvatarInstruct;
        private System.Windows.Forms.Button btnCharacter1;
        private System.Windows.Forms.Button btnCharacter2;
        private System.Windows.Forms.Button btnCharater3;
        private System.Windows.Forms.Button btnCharacter4;
        private System.Windows.Forms.Timer Load;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer Errorclock;
    }
}