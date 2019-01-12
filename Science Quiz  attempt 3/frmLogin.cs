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
    public partial class frmLogin : Form
    {
        // These will be used to determine the image selected
        bool[] Image = new bool[4];
        int Error;

        public frmLogin()
        {
            InitializeComponent();


            // This will hide alot of the text unless it is needed, making the form cleaner.
            lblPercentage.Hide();
            lblError.Hide();
            lblProgress.Hide();
            loadingBar.Hide();
           

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // load loading bar
            loadingBar.Increment(1);
            // show percentage
            lblPercentage.Show();
            lblPercentage.Text = Convert.ToString(loadingBar.Value + "%");

            //Show progress Text + Change Text
            if (loadingBar.Value < 30)
            {
                lblProgress.Show();
                lblProgress.Text = "Connecting to server";
            }
            if (loadingBar.Value > 30)
            {
                lblProgress.Text = "Establishing";
            }
            if (loadingBar.Value > 70)
            {
                lblProgress.Text = "Signing in";
            }

            // Load new form
            if (loadingBar.Value == 100)
            {
                Load.Stop();
                frmDifficulty Difficulty = new frmDifficulty();
                this.Hide();
                Difficulty.Show();

          
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // This is the desingated path where I want the file to be located.
            string path = @"c:\temp\Login.txt";

            using (StreamReader readtext = File.OpenText(path))
            {
                string Username = readtext.ReadLine(); // These lines of code will take the information from the file, and place them within strings.
                string Password = readtext.ReadLine();


                // If the login details are correct, load the nest form
                if (txtName.Text ==  Username && txtPass.Text == Password && Globalvariables.Character > 0)
                {
                    Globalvariables.username = Username;
                    loadingBar.Show();
                    Load.Start();
                    lblError.Hide();
                    Globalvariables.points = 0;
                }
                if ((txtName.Text != Username || txtPass.Text != Password && Globalvariables.Character > 0))
                {
                    // Error message for incorrect Username or Password
                    lblError.Show();
                    lblError.Text = "Username or Password is incorrect";
                    Errorclock.Start();
                }

                // Profile picture error message
                if (txtName.Text == Username && txtPass.Text == Password && Globalvariables.Character < 1)
                {
                    lblError.Show();
                    lblError.Text = "Please select a profile picture";
                    Errorclock.Start();
                }


                // Fail safe
                if(Globalvariables.username == txtName.Text && Globalvariables.password == txtPass.Text)
                {
                    Globalvariables.username = Username;
                    loadingBar.Show();
                    Load.Start();
                    lblError.Hide();
                    Globalvariables.points = 0;
                }

            }
        }



        // This section of the quiz is used to set the character image that will appear throughout the quiz,
        // and changes the label displayed at the log in screen

        private void btnCharacter1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            Globalvariables.Character = 1;
            Image[0] = true;
            Image[1] = false;
            Image[2] = false;
            Image[3] = false;
            btnCharacter1.BackColor = Color.LightBlue;
        }

        private void btnCharacter2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            Globalvariables.Character = 2;
            Image[0] = false;
            Image[1] = true;
            Image[2] = false;
            Image[3] = false;
            btnCharacter2.BackColor = Color.LightBlue;
        }

        private void btnCharater3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            Globalvariables.Character = 3;
            Image[0] = false;
            Image[1] = false;
            Image[2] = true;
            Image[3] = false;
            btnCharater3.BackColor = Color.LightBlue;
        }

        private void btnCharacter4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            Globalvariables.Character = 4;
            Image[0] = false;
            Image[1] = false;
            Image[2] = false;
            Image[3] = true;
            btnCharacter4.BackColor = Color.LightBlue;
        }


        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This allows the user to press keys to move between text boxes
            if (e.KeyChar == (Char)Keys.Enter)
            {
                txtPass.Select();
            }
            if (e.KeyChar == (Char)Keys.Down)
            {
                txtPass.Select();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This allows the user to press keys to move between text boxes
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnLogin.Select();
            }

            if (e.KeyChar == (Char)Keys.Up)
            {
                txtName.Select();
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration registation = new frmRegistration();
            registation.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // State what character has been selected
            if (Image[0] == true)
            {
                lblAvatarInstruct.Text = "Select avatar:  Astronaut";
                btnCharacter2.BackColor = Color.Gainsboro;
                btnCharater3.BackColor = Color.Gainsboro;
                btnCharacter4.BackColor = Color.Gainsboro;
                timer2.Stop();
            }
            if (Image[1] == true)
            {
                lblAvatarInstruct.Text = "Select avatar:  Alien";
                btnCharacter1.BackColor = Color.Gainsboro;
                btnCharater3.BackColor = Color.Gainsboro;
                btnCharacter4.BackColor = Color.Gainsboro;
                timer2.Stop();
            }
            if (Image[2] == true)
            {
                lblAvatarInstruct.Text = "Select avatar:  Neil Armstrong";
                btnCharacter1.BackColor = Color.Gainsboro;
                btnCharacter2.BackColor = Color.Gainsboro;
                btnCharacter4.BackColor = Color.Gainsboro;
                timer2.Stop();
            }
            if (Image[3] == true)
            {
                lblAvatarInstruct.Text = "Select avatar: Predator";
                btnCharacter1.BackColor = Color.Gainsboro;
                btnCharacter2.BackColor = Color.Gainsboro;
                btnCharater3.BackColor = Color.Gainsboro;
                timer2.Stop();
            }
        }

        private void avatarcount_Tick(object sender, EventArgs e)
        {
            lblError.Show();
            Error += 1;
            if (Error == 5)
            {
                lblError.Hide();
                Error = 0;
                Errorclock.Stop();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
    }

