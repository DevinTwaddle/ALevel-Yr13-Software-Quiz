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

    public partial class frmQuestion1b : Form
    {
        // This will generate a random number, which will be needed later on.
        Random random = new Random();
        int RandomNumber = 0;

        bool loop;


        public frmQuestion1b()
        {
            InitializeComponent();

            // start and display user timer.
            UserTimer.Start();
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer); // This will make a smoother transition between forms.

            // State that this question has been used.
            Globalvariables.CompletedQuestionsB[0] = true;
            Globalvariables.form += 1;

            // This should check to see which image the user has selected for there character and display it within the form.
            switch (Globalvariables.Character)
            {
                case 1: {
                        pictureCharacter.Image = Properties.Resources.CharacterPlaceholder; // Displays 1st image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
                case 2: {
                        pictureCharacter.Image = Properties.Resources.CharacterPlaceholder2; // 2nd image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
                case 3: {
                        pictureCharacter.Image = Properties.Resources.NeilArmstrong; // 3rd image
                        pictureCharacter.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    break;
                case 4: {
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
            // This will display the form "Help"
            frmHelp help = new frmHelp();
            help.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Generate a random number
            RandomNumber = random.Next(1, 7);
            loop = true;
            NextQuestion.Start();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Correct answer
            Globalvariables.points += 1;
            Globalvariables.QuestionsCorrectB[0] = true;

            // Generate a random number
            RandomNumber = random.Next(1, 7);
            loop = true;
            NextQuestion.Start();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Load new form
            RandomNumber = random.Next(1, 7);
            loop = true;
            NextQuestion.Start();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Generate a random number
            RandomNumber = random.Next(1, 7);
            loop = true;
            NextQuestion.Start();
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

    }
}
