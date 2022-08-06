namespace Science_Quiz__attempt_3
{
    partial class frmDifficulty
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
            this.btnBeginner = new System.Windows.Forms.Button();
            this.btnIntermediate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeginner
            // 
            this.btnBeginner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBeginner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginner.Location = new System.Drawing.Point(12, 93);
            this.btnBeginner.Name = "btnBeginner";
            this.btnBeginner.Size = new System.Drawing.Size(260, 65);
            this.btnBeginner.TabIndex = 0;
            this.btnBeginner.Text = "Beginner";
            this.btnBeginner.UseVisualStyleBackColor = false;
            this.btnBeginner.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIntermediate
            // 
            this.btnIntermediate.BackColor = System.Drawing.Color.Red;
            this.btnIntermediate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediate.Location = new System.Drawing.Point(12, 184);
            this.btnIntermediate.Name = "btnIntermediate";
            this.btnIntermediate.Size = new System.Drawing.Size(260, 65);
            this.btnIntermediate.TabIndex = 1;
            this.btnIntermediate.Text = "Intermediate";
            this.btnIntermediate.UseVisualStyleBackColor = false;
            this.btnIntermediate.Click += new System.EventHandler(this.btnIntermediate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select a difficulty";
            // 
            // frmDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIntermediate);
            this.Controls.Add(this.btnBeginner);
            this.Name = "frmDifficulty";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeginner;
        private System.Windows.Forms.Button btnIntermediate;
        private System.Windows.Forms.Label label1;
    }
}