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
    public partial class frmQuestion2b : Form
    {
        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;

        // bools that will tell if the answer is correct
        bool[] TrueAnswers = new bool[4];
        bool[] FalseAnswers = new bool[4];



        // State whether or not the question has been finished
        bool[] Finished = new bool[8];

        public frmQuestion2b()
        {
            InitializeComponent();

            // This tells the system that this form has been used
            Globalvariables.CompletedQuestionsB[1] = true;
            Globalvariables.form += 1;

            // start timers
            AnswerCheck.Start();
            UserTimer.Start();
            ErrorTimer.Start();
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer); // This will make a smoother transition between forms.

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // This block of code is used to provide the user with the ability to drag information.
        private void btnSatement1_MouseDown(object sender, MouseEventArgs e)
        {
            btnSatement1.DoDragDrop(btnSatement1.Text,
               DragDropEffects.Copy);
        }

        private void btnSatement2_MouseDown(object sender, MouseEventArgs e)
        {
            btnSatement2.DoDragDrop(btnSatement2.Text,
              DragDropEffects.Copy);
        }

        private void btnStatement3_MouseDown(object sender, MouseEventArgs e)
        {
            btnStatement3.DoDragDrop(btnStatement3.Text,
             DragDropEffects.Copy);
        }

        private void btnStatement4_MouseDown(object sender, MouseEventArgs e)
        {
            btnStatement4.DoDragDrop(btnStatement4.Text,
             DragDropEffects.Copy);
        }

        private void btnStatement5_MouseDown(object sender, MouseEventArgs e)
        {
            btnStatement5.DoDragDrop(btnStatement5.Text,
           DragDropEffects.Copy);
        }

        private void btnStatement6_MouseDown(object sender, MouseEventArgs e)
        {
            btnStatement6.DoDragDrop(btnStatement6.Text,
           DragDropEffects.Copy);
        }

        private void btnStatement7_MouseDown(object sender, MouseEventArgs e)
        {
            btnStatement7.DoDragDrop(btnStatement7.Text,
           DragDropEffects.Copy);
        }

        private void btnStatement8_MouseDown(object sender, MouseEventArgs e)
        {
            btnStatement8.DoDragDrop(btnStatement8.Text,
           DragDropEffects.Copy);
        }



        // This part of the code will ensure that the components will only accept text data.
        private void lblAnswer1_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblAnswer2_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblanswer3_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblanswer4_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblanswer5_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblanswer6_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblanswer7_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lblanswer8_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is text
            if (e.Data.GetDataPresent(DataFormats.Text) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }



        // This section will be used to finalise the drop. pasting the dragged information.
        private void lblAnswer1_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblAnswer1.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblAnswer1.Location = new Point(230, 128);
        }

        private void lblAnswer2_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblAnswer2.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblAnswer2.Location = new Point(230, 200);
        }

        private void lblanswer3_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblanswer3.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblanswer3.Location = new Point(230, 260);
        }

        private void lblanswer4_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblanswer4.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblanswer4.Location = new Point(230, 330);
        }

        private void lblanswer5_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblanswer5.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblanswer5.Location = new Point(850, 130);
        }

        private void lblanswer6_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblanswer6.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblanswer6.Location = new Point(850, 200);
        }

        private void lblanswer7_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblanswer7.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblanswer7.Location = new Point(850, 260);
        }

        private void lblanswer8_DragDrop(object sender, DragEventArgs e)
        {
            // paste text
            lblanswer8.Text = e.Data.GetData(DataFormats.Text).ToString();
            lblanswer8.Location = new Point(850, 330);
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            // If the answers are palced into the correct section, at points.
            if (TrueAnswers[0] == true)
            {
                Globalvariables.points += 1;
            }
            if (TrueAnswers[1] == true)
            {
                Globalvariables.points += 1;
            }
            if (TrueAnswers[2] == true)
            {
                Globalvariables.points += 1;
            }
            if (TrueAnswers[3] == true)
            {
                Globalvariables.points += 1;
            }
            if (FalseAnswers[0] == true)
            {
                Globalvariables.points += 1;
            }
            if (FalseAnswers[1] == true)
            {
                Globalvariables.points += 1;
            }
            if (FalseAnswers[2] == true)
            {
                Globalvariables.points += 1;
            }
            if (FalseAnswers[3] == true)
            {
                Globalvariables.points += 1;
            }

            // All answers are correct
            if (TrueAnswers[0] == true && TrueAnswers[1] == true && TrueAnswers[2] == true && TrueAnswers[3] == true && FalseAnswers[0] == true
                && FalseAnswers[1] == true && FalseAnswers[2] == true && FalseAnswers[3] == true)
            {
                Globalvariables.QuestionsCorrectB[1] = true;
            }


            // Load New Question
            RandomNumber = random.Next(1, 7);
            NewQuestion.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // This section of code will check to see what answer has been dragged into the areas, and see if there correct.
            // Statesments 1-4 are true, while 5-8 are false.

            // True statements

            // 1st label
            // Correct
            if (lblAnswer1.Text == btnSatement1.Text)
            {
                TrueAnswers[0] = true;
                Finished[0] = true;
                btnSatement1.Hide();
                lblAnswer1.AllowDrop = false;
            }

            else if (lblAnswer1.Text == btnStatement4.Text)
            {
                TrueAnswers[0] = true;
                Finished[0] = true;
                btnStatement4.Hide();
                lblAnswer1.AllowDrop = false;
            }

            else if (lblAnswer1.Text == btnStatement5.Text)
            {
                TrueAnswers[0] = true;
                Finished[0] = true;
                btnStatement5.Hide();
                lblAnswer1.AllowDrop = false;
            }


            else if (lblAnswer1.Text == btnStatement6.Text)
            {
                TrueAnswers[0] = true;
                Finished[0] = true;
                btnStatement6.Hide();
                lblAnswer1.AllowDrop = false;
            }

            // Incorrect
            else if (lblAnswer1.Text == btnSatement2.Text)
            {
                Finished[0] = true;
                btnSatement2.Hide();
                lblAnswer1.AllowDrop = false;
            }

            else if (lblAnswer1.Text == btnStatement3.Text)
            {
                Finished[0] = true;
                btnStatement3.Hide();
                lblAnswer1.AllowDrop = false;
            }

            else if (lblAnswer1.Text == btnStatement7.Text)
            {
                Finished[0] = true;
                btnStatement7.Hide();
                lblAnswer1.AllowDrop = false;
            }

            else if (lblAnswer1.Text == btnStatement8.Text)
            {
                Finished[0] = true;
                btnStatement8.Hide();
                lblAnswer1.AllowDrop = false;
            }




            // 2nd label
            //Correct
            if (lblAnswer2.Text == btnSatement1.Text)
            {
                TrueAnswers[1] = true;
                Finished[1] = true;
                btnSatement1.Hide();
                lblAnswer2.AllowDrop = false;
            }

            else if (lblAnswer2.Text == btnStatement4.Text)
            {
                TrueAnswers[1] = true;
                Finished[1] = true;
                btnStatement4.Hide();
                lblAnswer2.AllowDrop = false;
            }

            else if (lblAnswer2.Text == btnStatement5.Text)
            {
                TrueAnswers[1] = true;
                Finished[1] = true;
                btnStatement5.Hide();
                lblAnswer2.AllowDrop = false;
            }

            else if (lblAnswer2.Text == btnStatement6.Text)
            {
                TrueAnswers[1] = true;
                Finished[1] = true;
                btnStatement6.Hide();
                lblAnswer2.AllowDrop = false;
            }

            // Incorrect
            else if (lblAnswer2.Text == btnSatement2.Text)
            {
                Finished[1] = true;
                btnSatement2.Hide();
                lblAnswer2.AllowDrop = false;
            }
            else if (lblAnswer2.Text == btnStatement3.Text)
            {
                Finished[1] = true;
                btnStatement3.Hide();
                lblAnswer2.AllowDrop = false;
            }

            else if (lblAnswer2.Text == btnStatement7.Text)
            {
                Finished[1] = true;
                btnStatement7.Hide();
                lblAnswer2.AllowDrop = false;
            }
            else if (lblAnswer2.Text == btnStatement8.Text)
            {
                Finished[1] = true;
                btnStatement8.Hide();
                lblAnswer2.AllowDrop = false;
            }



            // 3rd label
            // Correct
            if (lblanswer3.Text == btnSatement1.Text)
            {
                TrueAnswers[2] = true;
                Finished[2] = true;
                btnSatement1.Hide();
                lblanswer3.AllowDrop = false;
            }

            else if (lblanswer3.Text == btnStatement4.Text)
            {
                TrueAnswers[2] = true;
                Finished[2] = true;
                btnStatement4.Hide();
                lblanswer3.AllowDrop = false;
            }

            else if (lblanswer3.Text == btnStatement5.Text)
            {
                TrueAnswers[2] = true;
                Finished[2] = true;
                btnStatement5.Hide();
                lblanswer3.AllowDrop = false;
            }

            else if (lblanswer3.Text == btnStatement6.Text)
            {
                TrueAnswers[2] = true;
                Finished[2] = true;
                btnStatement6.Hide();
                lblanswer3.AllowDrop = false;
            }

            // incorrect
            else if (lblanswer3.Text == btnSatement2.Text)
            {
                Finished[2] = true;
                btnSatement2.Hide();
                lblanswer3.AllowDrop = false;
            }
            else if (lblanswer3.Text == btnStatement3.Text)
            {
                Finished[2] = true;
                btnStatement3.Hide();
                lblanswer3.AllowDrop = false;
            }


            else if (lblanswer3.Text == btnStatement7.Text)
            {
                Finished[2] = true;
                btnStatement7.Hide();
                lblanswer3.AllowDrop = false;
            }
            else if (lblanswer3.Text == btnStatement8.Text)
            {
                Finished[2] = true;
                btnStatement8.Hide();
                lblanswer3.AllowDrop = false;
            }



            // 4rd label
            // Correct
            if (lblanswer4.Text == btnSatement1.Text)
            {
                TrueAnswers[3] = true;
                Finished[3] = true;
                btnSatement1.Hide();
                lblanswer4.AllowDrop = false;
            }

            else if (lblanswer4.Text == btnStatement4.Text)
            {
                TrueAnswers[3] = true;
                Finished[3] = true;
                btnStatement4.Hide();
                lblanswer4.AllowDrop = false;
            }

            else if (lblanswer4.Text == btnStatement5.Text)
            {
                TrueAnswers[3] = true;
                Finished[3] = true;
                btnStatement5.Hide();
                lblanswer4.AllowDrop = false;
            }

            else if (lblanswer4.Text == btnStatement6.Text)
            {
                TrueAnswers[3] = true;
                Finished[3] = true;
                btnStatement6.Hide();
                lblanswer4.AllowDrop = false;
            }

            // Incorrect
            else if (lblanswer4.Text == btnSatement2.Text)
            {
                Finished[3] = true;
                btnSatement2.Hide();
                lblanswer4.AllowDrop = false;
            }
            else if (lblanswer4.Text == btnStatement3.Text)
            {
                Finished[3] = true;
                btnStatement3.Hide();
                lblanswer4.AllowDrop = false;
            }

            else if (lblanswer4.Text == btnStatement7.Text)
            {
                Finished[3] = true;
                btnStatement7.Hide();
                lblanswer4.AllowDrop = false;
            }
            else if (lblanswer4.Text == btnStatement8.Text)
            {
                Finished[3] = true;
                btnStatement8.Hide();
                lblanswer4.AllowDrop = false;
            }


            // False statements

            // 5rd label
            // Correct
            if (lblanswer5.Text == btnSatement2.Text)
            {
                FalseAnswers[0] = true;
                Finished[4] = true;
                btnSatement2.Hide();
                lblanswer5.AllowDrop = false;
            }

            else if (lblanswer5.Text == btnStatement3.Text)
            {
                FalseAnswers[0] = true;
                Finished[4] = true;
                btnStatement3.Hide();
                lblanswer5.AllowDrop = false;
            }

            else if (lblanswer5.Text == btnStatement7.Text)
            {
                FalseAnswers[0] = true;
                Finished[4] = true;
                btnStatement7.Hide();
                lblanswer5.AllowDrop = false;
            }

            else if (lblanswer5.Text == btnStatement8.Text)
            {
                FalseAnswers[0] = true;
                Finished[4] = true;
                btnStatement8.Hide();
                lblanswer5.AllowDrop = false;
            }

            // Incorrect
            else if (lblanswer5.Text == btnSatement1.Text)
            {
                Finished[4] = true;
                btnSatement1.Hide();
                lblanswer5.AllowDrop = false;
            }

            else if (lblanswer5.Text == btnStatement4.Text)
            {
                Finished[4] = true;
                btnStatement4.Hide();
                lblanswer5.AllowDrop = false;
            }
            else if (lblanswer5.Text == btnStatement5.Text)
            {
                Finished[4] = true;
                btnStatement5.Hide();
                lblanswer5.AllowDrop = false;
            }
            else if (lblanswer5.Text == btnStatement6.Text)
            {
                Finished[4] = true;
                btnStatement6.Hide();
                lblanswer5.AllowDrop = false;
            }



            // 6rd label
            // Correct
            if (lblanswer6.Text == btnSatement2.Text)
            {
                FalseAnswers[1] = true;
                Finished[5] = true;
                btnSatement2.Hide();
                lblanswer6.AllowDrop = false;
            }

            else if (lblanswer6.Text == btnStatement3.Text)
            {
                FalseAnswers[1] = true;
                Finished[5] = true;
                btnStatement3.Hide();
                lblanswer6.AllowDrop = false;
            }

            else if (lblanswer6.Text == btnStatement7.Text)
            {
                FalseAnswers[1] = true;
                Finished[5] = true;
                btnStatement7.Hide();
                lblanswer6.AllowDrop = false;
            }

            else if (lblanswer6.Text == btnStatement8.Text)
            {
                FalseAnswers[1] = true;
                Finished[5] = true;
                btnStatement8.Hide();
                lblanswer6.AllowDrop = false;
            }

            // Incorrect
            else if (lblanswer6.Text == btnSatement1.Text)
            {
                Finished[5] = true;
                btnSatement1.Hide();
                lblanswer6.AllowDrop = false;
            }

            else if (lblanswer6.Text == btnStatement4.Text)
            {
                Finished[5] = true;
                btnStatement4.Hide();
                lblanswer6.AllowDrop = false;
            }
            else if (lblanswer6.Text == btnStatement5.Text)
            {
                Finished[5] = true;
                btnStatement5.Hide();
                lblanswer6.AllowDrop = false;
            }
            else if (lblanswer6.Text == btnStatement6.Text)
            {
                Finished[5] = true;
                btnStatement6.Hide();
                lblanswer6.AllowDrop = false;
            }



            // 7rd label
            // Correct
            if (lblanswer7.Text == btnSatement2.Text)
            {
                FalseAnswers[2] = true;
                Finished[6] = true;
                btnSatement2.Hide();
                lblanswer7.AllowDrop = false;
            }

            else if (lblanswer7.Text == btnStatement3.Text)
            {
                FalseAnswers[2] = true;
                Finished[6] = true;
                btnStatement3.Hide();
                lblanswer7.AllowDrop = false;
            }

            else if (lblanswer7.Text == btnStatement7.Text)
            {
                FalseAnswers[2] = true;
                Finished[6] = true;
                btnStatement7.Hide();
                lblanswer7.AllowDrop = false;
            }
            else if (lblanswer7.Text == btnStatement8.Text)
            {
                FalseAnswers[2] = true;
                Finished[6] = true;
                btnStatement8.Hide();
                lblanswer7.AllowDrop = false;
            }

            // Incorrect
            else if (lblanswer7.Text == btnSatement1.Text)
            {
                Finished[6] = true;
                btnSatement1.Hide();
                lblanswer7.AllowDrop = false;
            }

            else if (lblanswer7.Text == btnStatement4.Text)
            {
                Finished[6] = true;
                btnStatement4.Hide();
                lblanswer7.AllowDrop = false;
            }

            else if (lblanswer7.Text == btnStatement5.Text)
            {
                Finished[6] = true;
                btnStatement5.Hide();
                lblanswer7.AllowDrop = false;
            }

            else if (lblanswer7.Text == btnStatement6.Text)
            {
                Finished[6] = true;
                btnStatement6.Hide();
                lblanswer7.AllowDrop = false;
            }



            // 8rd label
            // Correct
            if (lblanswer8.Text == btnSatement2.Text)
            {
                FalseAnswers[3] = true;
                Finished[7] = true;
                btnSatement2.Hide();
                lblanswer8.AllowDrop = false;
            }

            else if (lblanswer8.Text == btnStatement3.Text)
            {
                FalseAnswers[3] = true;
                Finished[7] = true;
                btnStatement3.Hide();
                lblanswer8.AllowDrop = false;
            }

            else if (lblanswer8.Text == btnStatement7.Text)
            {
                FalseAnswers[3] = true;
                Finished[7] = true;
                btnStatement7.Hide();
                lblanswer8.AllowDrop = false;
            }

            else if (lblanswer8.Text == btnStatement8.Text)
            {
                FalseAnswers[3] = true;
                Finished[7] = true;
                btnStatement8.Hide();
                lblanswer8.AllowDrop = false;
            }

            // Incorrect
            else if (lblanswer8.Text == btnSatement1.Text)
            {
                Finished[7] = true;
                btnSatement1.Hide();
                lblanswer8.AllowDrop = false;
            }

            else if (lblanswer8.Text == btnStatement4.Text)
            {
                Finished[7] = true;
                btnStatement4.Hide();
                lblanswer8.AllowDrop = false;
            }
            else if (lblanswer8.Text == btnStatement5.Text)
            {
                Finished[7] = true;
                btnStatement5.Hide();
                lblanswer8.AllowDrop = false;
            }
            else if (lblanswer8.Text == btnStatement6.Text)
            {
                Finished[7] = true;
                btnStatement6.Hide();
                lblanswer8.AllowDrop = false;
            }
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.Show();
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


        private void UserTimer_Tick(object sender, EventArgs e)
        {
            // Increase timer
            Globalvariables.timer += 1;
            lblTime.Text = "Timer  :  " + Convert.ToString(Globalvariables.timer);
        }


        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            // I want to make it so that the user would only be able to submit their answer whenever all of the items have been dragged.
            // To do this I have created variables which will change if the user has changed the inforamtion present within all of the answer areas.
            if (Finished[0] == true && Finished[1] == true && Finished[2] == true && Finished[3] == true && Finished[4] == true
                && Finished[5] == true && Finished[6] == true && Finished[7] == true)
            {
                // Once this has been done the user will be able to press the continue button, which is visually represented with a change of colour.
                btnConfirm.BackColor = Color.White;
                btnConfirm.Enabled = true;
                lblError.Hide();
            }
            else
            {
                btnConfirm.BackColor = Color.Gray;
                btnConfirm.Enabled = false;
                lblError.Show(); // An error message will appear if the user tries anyway.
            }

        }


        private void btnResetQuestion_Click(object sender, EventArgs e)
        {
            // This block of code will reset any changes which could occur while answering this question.
            // This section will display all of the draggable buttons, incase the user has already dragged one or two.
            btnSatement1.Show();
            btnSatement2.Show();
            btnStatement3.Show();
            btnStatement4.Show();
            btnStatement5.Show();
            btnStatement6.Show();
            btnStatement7.Show();
            btnStatement8.Show();

            // This section will reset all of the answer areas.
            lblAnswer1.Text = "----------------------------------------";
            lblAnswer1.Location = new Point(275, 128);

            lblAnswer2.Text = "----------------------------------------";
            lblAnswer2.Location = new Point(275, 198);

            lblanswer3.Text = "----------------------------------------";
            lblanswer3.Location = new Point(275, 260);

            lblanswer4.Text = "----------------------------------------";
            lblanswer4.Location = new Point(275, 328);

            lblanswer5.Text = "----------------------------------------";
            lblanswer5.Location = new Point(909, 128);

            lblanswer6.Text = "----------------------------------------";
            lblanswer6.Location = new Point(909, 198);

            lblanswer7.Text = "----------------------------------------";
            lblanswer7.Location = new Point(909, 260);

            lblanswer8.Text = "----------------------------------------";
            lblanswer8.Location = new Point(909, 328);

            // Finally the following blocks will rest any variable changes which have been made. This ensures that the answer system works properly.
            Finished[0] = true;
            Finished[1] = true;
            Finished[2] = true;
            Finished[3] = true;
            Finished[4] = true;
            Finished[5] = true;
            Finished[6] = true;

            TrueAnswers[0] = false;
            TrueAnswers[1] = false;
            TrueAnswers[2] = false;
            TrueAnswers[3] = false;

            FalseAnswers[0] = false;
            FalseAnswers[1] = false;
            FalseAnswers[2] = false;
            FalseAnswers[3] = false;

            // This simply provides the user with the ability to drag information into the specific answer areas once again.
            lblAnswer1.AllowDrop = true;
            lblAnswer2.AllowDrop = true;
            lblanswer3.AllowDrop = true;
            lblanswer4.AllowDrop = true;
            lblanswer5.AllowDrop = true;
            lblanswer6.AllowDrop = true;
            lblanswer7.AllowDrop = true;
            lblanswer8.AllowDrop = true;
        }


        private void NewQuestion_Tick(object sender, EventArgs e)
        {
            if (Globalvariables.form == 5)
            {
                frmEndb Finish = new frmEndb(); // Opens end screen
                this.Hide();
                Finish.Show();// Opens end screen
                NewQuestion.Stop();
            }
            else
            {
                // This section of code will be used to select a new random question. It will ensure that the user does not recieve the same question twice.
                if (RandomNumber == 1 && Globalvariables.CompletedQuestionsB[0] == false)
                {
                    frmQuestion1b Question1b = new frmQuestion1b();
                    this.Close();
                    Question1b.Show();
                    NewQuestion.Stop();
                }
                else if (RandomNumber == 2 && Globalvariables.CompletedQuestionsB[1] == false)
                {
                    frmQuestion2b Question2b = new frmQuestion2b();
                    this.Close();
                    Question2b.Show();
                    NewQuestion.Stop();
                }
                else if (RandomNumber == 3 && Globalvariables.CompletedQuestionsB[2] == false)
                {
                    frmQuestion3b Question3b = new frmQuestion3b();
                    this.Close();
                    Question3b.Show();
                    NewQuestion.Stop();
                }
                else if (RandomNumber == 4 && Globalvariables.CompletedQuestionsB[3] == false)
                {
                    frmQuestion4b Question4b = new frmQuestion4b();
                    this.Close();
                    Question4b.Show();
                    NewQuestion.Stop();
                }
                else if (RandomNumber == 5 && Globalvariables.CompletedQuestionsB[4] == false)
                {
                    frmQuestion5b Question5b = new frmQuestion5b();
                    this.Close();
                    Question5b.Show();
                    NewQuestion.Stop();
                }
                else if (RandomNumber == 6 && Globalvariables.CompletedQuestionsB[5] == false)
                {
                    frmQuestion6b Question6b = new frmQuestion6b();
                    this.Close();
                    Question6b.Show();
                    NewQuestion.Stop();
                }
                else if (RandomNumber == 7 && Globalvariables.CompletedQuestionsB[6] == false)
                {
                    frmQuestion7b Question7b = new frmQuestion7b();
                    this.Close();
                    Question7b.Show();
                    NewQuestion.Stop();
                }
                else {
                    RandomNumber = random.Next(1, 7);
                }
            }
        }
    }
}
