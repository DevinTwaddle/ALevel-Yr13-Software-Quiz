using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Science_Quiz__attempt_3
{
    public partial class frmRegistration : Form
    {

        public frmRegistration()
        {
            InitializeComponent();
            timer1.Start();
            lblError.Hide(); 
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // File location
            string path = @"c:\temp\Login.txt";

            // Create File
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(txtUsername.Text);
                    sw.WriteLine(txtPassword.Text);
                }
            }
            // Paste to file
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(txtUsername.Text);
                    sw.WriteLine(txtPassword.Text);
                }
            }

            // Fail safe
            if (!File.Exists(path))
            {
                Globalvariables.username = txtUsername.Text;
                Globalvariables.password = txtPassword.Text;
            }

            // This will close the login form
            this.Close();
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check that users have typed information in boxes
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                btnRegister.Enabled = false;
                btnRegister.BackColor = Color.Gray;

                //Show Error message
                lblError.Show();
                lblError.Text = "Please ensure there" +
                    Environment.NewLine+
                    "is text in both boxes";
            }
            else
            {
                btnRegister.Enabled = true;
                btnRegister.BackColor = Color.White;
                lblError.Hide();
            }


        }
    }
}
