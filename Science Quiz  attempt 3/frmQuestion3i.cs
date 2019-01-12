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
    public partial class frmQuestion3i : Form
    {
        // Create true/false for answers within textboxes
        bool[] answers = new bool[3];


        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;



        public frmQuestion3i()
        {
            InitializeComponent();

            // Tell the system that this form has been used
            Globalvariables.CompletedQuestionsI[2] = true;
            Globalvariables.form += 1;

            // Start timer
            UserTimer.Start();
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer); // This will make a smoother transition between forms.

            // Display different character images
            if (Globalvariables.Character == 1)
            {
                pictureCharacter.Image = Properties.Resources.CharacterPlaceholder; // Displays 1st image
                pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (Globalvariables.Character == 2)
            {
                pictureCharacter.Image = Properties.Resources.CharacterPlaceholder2; // 2nd image
                pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Globalvariables.Character == 3)
            {
                pictureCharacter.Image = Properties.Resources.NeilArmstrong; // 3rd image
                pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Globalvariables.Character == 4)
            {
                pictureCharacter.Image = Properties.Resources.Predator2; // 4th image
                pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            }


            // Displays player score
            lblScore.Text = Convert.ToString(Globalvariables.points);

            // Displays player name
            lblPlayerName.Text = Globalvariables.username;

            // Help for this question
            txtAnswe1.Text = "F";
            txtAnswer2.Text = "A";
            txtAnswer3.Text = "H";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmQuestion2i Question2i = new frmQuestion2i();
            this.Hide();
            Question2i.Show();
        }



       



        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (answers[0] == true)
            {
                Globalvariables.points += 1;
            }
            if (answers[1] == true)
            {
                Globalvariables.points += 1;
            }
            if (answers[2] == true)
            {
                Globalvariables.points += 1;
            }

            // all answers are correct
            if (answers[0] == true && answers[1] == true && answers[2] == true)
            {
                Globalvariables.QuestionsCorrectI[2] = true;
            }


            // Load next question
            NextQuestion.Start();
        RandomNumber = random.Next(1, 7);

        }



        // This block of code will check to see if the answer entered by the user is correct.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // set bool to true if answer is correct
            if (txtAnswe1.Text == "Fossil")
            {
                answers[0] = true;
            }
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            // set bool to true if answer is correct
            if (txtAnswer3.Text == "Heat")
            {
                answers[2] = true;
            }
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            // set bool to true if answer is correct
            if (txtAnswer2.Text == "Atmosphere")
            {
                answers[1] = true;
            }
        }


        // This is a small test and convenience peice of code which I wanted to add. This lets the user move to the next
        // text box by pressing enter.
        private void txtAnswe1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAnswer2.Select();
            }
        }

        private void txtAnswer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Select next textBox
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAnswer3.Select();
            }
        }

        private void txtAnswer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Select next textBox
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnContinue.Select();
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



        private void UserTimer_Tick(object sender, EventArgs e)
        {
            // Increase timer
            Globalvariables.timer += 1;
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer);
        }
    }
}
