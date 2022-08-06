using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Science_Quiz__attempt_3
{
    public partial class frmQuestion6b : Form
    {
        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;

        // These bools will be sued to determine if the answer is correct
        bool[] Correct = new bool[3];


        public frmQuestion6b()
        {
            InitializeComponent();

            // This code should tell the system that this form has been used.
            Globalvariables.CompletedQuestionsB [5] = true;
            Globalvariables.form += 1;

            // Start timers
            UserTimer.Start();
            ErrorTimer.Start();
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer); // This will make a smoother transition between forms.

            // This will check to see which character image the user has selected, and then display it within this form.
            switch (Globalvariables.Character)
            {
                case 1:
                    {
                        pictureCharacter.Image = Properties.Resources.CharacterPlaceholder; // Displays 1st image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
                case 2:
                    {
                        pictureCharacter.Image = Properties.Resources.CharacterPlaceholder2; // 2nd image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
                case 3:
                    {
                        pictureCharacter.Image = Properties.Resources.NeilArmstrong; // 3rd image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
                case 4:
                    {
                        pictureCharacter.Image = Properties.Resources.Predator2; // 4th image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
            }


            // Displays player score
            lblScore.Text = Convert.ToString(Globalvariables.points);

            // Displays player name
            lblPlayerName.Text = Globalvariables.username;
        }



        // The followihng blocks of code are used to ensure that the user can only have three options selected at one time.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                // I have created a vaiable which will keep track of the number of options selected.
                Globalvariables.question6b += 1;
            }

            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                // if the box is unselected it will subtract 1.
                Globalvariables.question6b -= 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                Globalvariables.question6b += 1;
                Correct[0] = true; // This will tell the program that this answer is correct
            }

            if (checkBox2.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question6b -= 1;
                Correct[0] = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                Globalvariables.question6b += 1;
            }

            if (checkBox3.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question6b -= 1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
                Globalvariables.question6b += 1;
                Correct[1] = true;
            }

            if (checkBox4.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question6b -= 1;
                Correct[1] = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState == CheckState.Checked)
            {
                Globalvariables.question6b += 1;
            }

            if (checkBox5.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question6b -= 1;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.CheckState == CheckState.Checked)
            {
                Globalvariables.question6b += 1;
                Correct[2] = true;
            }

            if (checkBox6.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question6b -= 1;
                Correct[2] = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // This if statement will tell if the user has completed 5 questions
            if (Globalvariables.question6b == 3 && Globalvariables.form < 5)
            {
                // point system for this question
                if (Correct[0] == true)
                {
                    Globalvariables.points += 1;
                }

                if (Correct[1] == true)
                {
                    Globalvariables.points += 1;
                }

                if (Correct[2] == true)
                {
                    Globalvariables.points += 1;
                }

                if (Correct[0] == true && Correct[1] == true && Correct[2] == true)
                {
                    Globalvariables.QuestionsCorrectB[5] = true;
                }
            }
            
                // Load New Question
                NextQuestion.Start();
                RandomNumber = random.Next(1, 7);
           }



        private void btnRestart_Click(object sender, EventArgs e)
        {
            // This sectiom of code will reset any variables which could have been adjusted throughout the quiz.
            // This section will be used to state that none of the questions have been answered by the user.
            int i = 0;
            while (i < 7)
            {
                Globalvariables.CompletedQuestionsB[i] = false;
                i++;
            }

            // This will state that none of the answers are currently correct.
            int x = 0;
            while (x < 7)
            {
                Globalvariables.QuestionsCorrectB[x] = false;
                x++;
            }

            // This resets the variables which are used for the corrisponding questions, which is done to prevent any issues.
            Globalvariables.question4i = 0;
            Globalvariables.question6b = 0;
            Globalvariables.form = 0;
            Globalvariables.timer = 0;
            Globalvariables.points = 0; // this will reset the players points back to 0
            frmDifficulty restart = new frmDifficulty(); // I have named my form restart so that I can tell it to .show.
            this.Close();
            restart.Show();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            // This will open the help menu when the button is clicked.
            frmHelp help = new frmHelp();
            help.Show();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Globalvariables.form == 5)
            {
                frmEndb Finish = new frmEndb(); // Opens end screen
                this.Hide();
                Finish.Show();// Opens end screen
                NextQuestion.Stop();
            }
            else
            {
                // This section of code will be used to select a new random question. It will ensure that the user does not recieve the same question twice.
                if (RandomNumber == 1 && Globalvariables.CompletedQuestionsB[0] == false)
                {
                    frmQuestion1b Question1b = new frmQuestion1b();
                    this.Close();
                    Question1b.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 2 && Globalvariables.CompletedQuestionsB[1] == false)
                {
                    frmQuestion2b Question2b = new frmQuestion2b();
                    this.Close();
                    Question2b.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 3 && Globalvariables.CompletedQuestionsB[2] == false)
                {
                    frmQuestion3b Question3b = new frmQuestion3b();
                    this.Close();
                    Question3b.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 4 && Globalvariables.CompletedQuestionsB[3] == false)
                {
                    frmQuestion4b Question4b = new frmQuestion4b();
                    this.Close();
                    Question4b.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 5 && Globalvariables.CompletedQuestionsB[4] == false)
                {
                    frmQuestion5b Question5b = new frmQuestion5b();
                    this.Close();
                    Question5b.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 6 && Globalvariables.CompletedQuestionsB[5] == false)
                {
                    frmQuestion6b Question6b = new frmQuestion6b();
                    this.Close();
                    Question6b.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 7 && Globalvariables.CompletedQuestionsB[6] == false)
                {
                    frmQuestion7b Question7b = new frmQuestion7b();
                    this.Close();
                    Question7b.Show();
                    NextQuestion.Stop();
                }
                else {
                    RandomNumber = random.Next(1, 7);
                }
            }
        }



        private void UserTimer_Tick(object sender, EventArgs e)
        {
            // Increase timer
            Globalvariables.timer += 1;
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer);
        }


        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            // Ensure that only 3 answers have been selected.
            if (Globalvariables.question6b == 3)
            {
                btnConfirm.BackColor = Color.White;
                btnConfirm.Enabled = true;
                lblError.Hide();   
            }
            else
            {
                btnConfirm.BackColor = Color.Gray;
                btnConfirm.Enabled = false;
                lblError.Show();
            }
        }
    }
}
