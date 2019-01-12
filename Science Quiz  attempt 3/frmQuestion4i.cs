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
    public partial class frmQuestion4 : Form
    {
        // Variables
        // Correct questions
        bool[] Answer = new bool [4];


        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;


        public frmQuestion4()
        {
            InitializeComponent();

            // Tell the system that this form has been used
            Globalvariables.CompletedQuestionsI[3] = true;
            Globalvariables.form += 1;

            // start timer
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

            // Display player name
            lblPlayerName.Text = Globalvariables.username;

            // Display player score
            lblScore.Text = Convert.ToString(Globalvariables.points);
        }




        // This block of code is used to acknowlesge the changes which have been made by the user.
        private void cbQuestion1_CheckedChanged(object sender, EventArgs e)
        {

            // if answer is selected, total answers will be reduced by 1, plus bool will change to true.
           if (cbQuestion1.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
                Answer[0] = true;
            }
           if (cbQuestion1.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
                Answer[0] = false;
            }
        }

        private void cbQuestion2_CheckedChanged(object sender, EventArgs e)
        {

            // if answer is selected, total answers will be reduced by 1, plus bool will change to true.
            if (cbQuestion2.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
                Answer[1] = true;
            }
            if (cbQuestion2.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
                Answer[1] = false;
            }
        }

        private void cbQuestion3_CheckedChanged(object sender, EventArgs e)
        {

            // if answer is selected, total answers will be reduced by 1
            if (cbQuestion3.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
            }
            // if the button is unselected it will return it to its default state
            if (cbQuestion3.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
            }
        }

        private void cbQuestion4_CheckedChanged(object sender, EventArgs e)
        {
            // if answer is selected, total answers will be reduced by 1
            if (cbQuestion4.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
            }
            // if the button is unselected it will return it to its default state
            if (cbQuestion4.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
            }
        }

        private void cbQuestion5_CheckedChanged(object sender, EventArgs e)
        {

            // if answer is selected, total answers will be reduced by 1, plus bool will change to true.
            if (cbQuestion5.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
                Answer[2] = true;
            }
            if (cbQuestion5.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
                Answer[2] = false;
            }
        }

        private void cbQuestion6_CheckedChanged(object sender, EventArgs e)
        {
            // if answer is selected, total answers will be reduced by 1
            if (cbQuestion6.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
            }
            // if the button is unselected it will return it to its default state
            if (cbQuestion6.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
            }
        }

        private void cbQuestion7_CheckedChanged(object sender, EventArgs e)
        {
            // if answer is selected, total answers will be reduced by 1
            if (cbQuestion7.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
            }
            // if the button is unselected it will return it to its default state
            if (cbQuestion7.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
            }
        }

        private void cbQuestion8_CheckedChanged(object sender, EventArgs e)
        {
            // if answer is selected, total answers will be reduced by 1, plus bool will change to true.
            if (cbQuestion8.CheckState == CheckState.Checked)
            {
                Globalvariables.question4i += 1;
                Answer[3] = true;
            }
            if (cbQuestion8.CheckState == CheckState.Unchecked)
            {
                Globalvariables.question4i -= 1;
                Answer[3] = false;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            // This is the point system, where the user will recieve the corrisponding number of points.
            if (Answer[0] == true)
            {
                Globalvariables.points += 1;
            }
            if (Answer[1] == true)
            {
                Globalvariables.points += 1;
            }
            if (Answer[2] == true)
            {
                Globalvariables.points += 1;
            }
            if (Answer[3] == true)
            {
                Globalvariables.points += 1;
            }

            // all answers are correct
            if (Answer[0] == true && Answer[1] == true && Answer[2] == true && Answer[3] == true)
            {
                Globalvariables.QuestionsCorrectI[3] = true;
            }


            // Load New Question
            NextQuestion.Start();
            RandomNumber = random.Next(1, 7);
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
                if (RandomNumber == 1 && Globalvariables.CompletedQuestionsI[0] == false)
                {
                    frmQuestion1i Question1i = new frmQuestion1i();
                    this.Close();
                    Question1i.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 2 && Globalvariables.CompletedQuestionsI[1] == false)
                {
                    frmQuestion2i Question2i = new frmQuestion2i();
                    this.Close();
                    Question2i.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 3 && Globalvariables.CompletedQuestionsI[2] == false)
                {
                    frmQuestion3i Question3i = new frmQuestion3i();
                    this.Close();
                    Question3i.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 4 && Globalvariables.CompletedQuestionsI[3] == false)
                {
                    frmQuestion4 Question4i = new frmQuestion4();
                    this.Close();
                    Question4i.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 5 && Globalvariables.CompletedQuestionsI[4] == false)
                {
                    frmQuestion5i Question5i = new frmQuestion5i();
                    this.Close();
                    Question5i.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 6 && Globalvariables.CompletedQuestionsI[5] == false)
                {
                    frmQuestion6i Question6i = new frmQuestion6i();
                    this.Close();
                    Question6i.Show();
                    NextQuestion.Stop();
                }
                else if (RandomNumber == 7 && Globalvariables.CompletedQuestionsI[6] == false)
                {
                    frmQuestion7i Question7i = new frmQuestion7i();
                    this.Close();
                    Question7i.Show();
                    NextQuestion.Stop();
                }
                else {
                    RandomNumber = random.Next(1, 7);
                }
            }
        }




        private void btnRestart_Click(object sender, EventArgs e)
        {
            // This sectiom of code will reset any variables which could have been adjusted throughout the quiz.
            // This section will be used to state that none of the questions have been answered by the user.
            int i = 0;
            while (i < 7)
            {
                Globalvariables.CompletedQuestionsI[i] = false;
                i++;
            }

            // This will state that none of the answers are currently correct.
            int x = 0;
            while (x < 7)
            {
                Globalvariables.QuestionsCorrectI[x] = false;
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
            frmHelp help = new frmHelp();
            help.Show();
        }


        private void UserTimer_Tick(object sender, EventArgs e)
        {
            // Increase timer
            Globalvariables.timer += 1;
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer);
        }


        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            if (Globalvariables.question4i == 4)
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

            if (Globalvariables.question4i < 0)
            {
                Globalvariables.question4i = 0; // This is just a fail safe encase the value falls under 0.
            }
        }
    }
}
