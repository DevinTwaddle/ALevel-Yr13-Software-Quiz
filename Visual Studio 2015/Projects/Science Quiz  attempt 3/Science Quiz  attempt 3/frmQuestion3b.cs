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
    public partial class frmQuestion3b : Form
    {
        // This block of code will be used to call a few different variables which I will be using throughout this question.

        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;

        // Bools which will tell the application if the answer is correct or not.
        bool[] Correct = new bool[5];
        // Bools which will tell if a box does not have an image.
        bool[] Finsihed = new bool[5];


        public frmQuestion3b()
        {
            InitializeComponent();

            // This will tell the system that this form has been completed.
            Globalvariables.CompletedQuestionsB[2] = true;
            Globalvariables.form += 1;

            //Start Timers
            UserTimer.Start();
            DragcheckTimer.Start();
            ErrorClock.Start();
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

            // Allow drop for the image boxes
            pbDropMars.AllowDrop = true;
            pbDropVenus.AllowDrop = true;
            pbDropNeptune.AllowDrop = true;
            pbDropJupiter.AllowDrop = true;
            pbDropUranus.AllowDrop = true;
        }


        // This block of code is used to provide the user with the ability to initiate the drag and drop process.
        private void pbDragMars_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragMars.DoDragDrop(pbDragMars.Image,
               DragDropEffects.Copy);
        }

        private void pbDragNeptune_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragNeptune.DoDragDrop(pbDragNeptune.Image,
               DragDropEffects.Copy);
        }

        private void pbDragVenus_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragVenus.DoDragDrop(pbDragVenus.Image,
               DragDropEffects.Copy);
        }

        private void pbDragUranus_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragUranus.DoDragDrop(pbDragUranus.Image,
               DragDropEffects.Copy);
        }

        private void pbDragJupiter_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragJupiter.DoDragDrop(pbDragJupiter.Image,
               DragDropEffects.Copy);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        // While this block of code will check the data being dragged, to ensure that it is an image.
        private void pbDropVenus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropMars_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropJupiter_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropUranus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropNeptune_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }



        // Finally this block of code is used to finalise the drag and drop, pasting the image into the corrisponding area.
        private void pbDropVenus_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropVenus.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finsihed[0] = true;
        }

        private void pbDropMars_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropMars.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finsihed[1] = true;
        }

        private void pbDropJupiter_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropJupiter.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finsihed[2] = true;
        }

        private void pbDropUranus_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropUranus.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finsihed[3] = true;
        }

        private void pbDropNeptune_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropNeptune.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finsihed[4] = true;
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // If the user clicks the confirm button, and has dragged all of the images they system will check to see if they are correct, before allocating points.
            if (Finsihed[0] == true && Finsihed[1] == true && Finsihed[2] == true && Finsihed[3] == true && Finsihed[4] == true)
            {
                // Point System
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
                if (Correct[3] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Correct[4] == true)
                {
                    Globalvariables.points += 1;
                }


                // Run next question
                NextQuestion.Start();
                RandomNumber = random.Next(1, 7);
            }


            // This will be used later, to monitor whether or not the user has answered the questions absoultely correct.
            if (Correct[0] == true && Correct[1] == true && Correct[2] == true && Correct[3] == true && Correct[4] == true)
            {
                Globalvariables.QuestionsCorrectB[2] = true;
            }
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            // This will open up the help screen for the user
            frmHelp help = new frmHelp();
            help.Show();
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



        private void ErrorClock_Tick(object sender, EventArgs e)
        {
            // If the user has dragged all of the planets, the continue button will become active. This will be made apparent with a colour change.
            if (Finsihed[0] == true && Finsihed[1] == true && Finsihed[2] == true && Finsihed[3] == true && Finsihed[4] == true)
            {
                lblError.Hide();
                btnConfirm.Enabled = true;
                btnConfirm.BackColor = Color.White;
            }
            else
            // Otherwise the button will stay inactive.
            {
                lblError.Show();
                btnConfirm.Enabled = false;
                btnConfirm.BackColor = Color.Gray;
            }
        }



        private void btnResetQuestion_Click(object sender, EventArgs e)
        {
            // This block of code is used to reset the question, and any variables which may have been changed.

            // This first section resets any of the planets which the user may have previously dragged.
            // This includes reseting the answer pictureboxes to dispaly a standard background image.
            pbDropVenus.Image = Properties.Resources.DragDropBackground;
            pbDropMars.Image = Properties.Resources.DragDropBackground;
            pbDropJupiter.Image = Properties.Resources.DragDropBackground;
            pbDropUranus.Image = Properties.Resources.DragDropBackground;
            pbDropNeptune.Image = Properties.Resources.DragDropBackground;

            // Making the draggable planets and their names reappear.
            pbDragVenus.Show();
            pbDragMars.Show();
            pbDragJupiter.Show();
            pbDragUranus.Show();
            pbDragNeptune.Show();

            lblVenus.Show();
            lblMars.Show();
            lblJupiter.Show();
            lblUranus.Show();
            lblNeptune.Show();

            // And as mentioned, reseting any variables used within this question.
            Correct[0] = false;
            Correct[1] = false;
            Correct[2] = false;
            Correct[3] = false;
            Correct[4] = false;

            Finsihed[0] = false;
            Finsihed[1] = false;
            Finsihed[2] = false;
            Finsihed[3] = false;
            Finsihed[4] = false;

            // This part lets the planets become draggable again.
            pbDropVenus.AllowDrop = true;
            pbDropMars.AllowDrop = true;
            pbDropJupiter.AllowDrop = true;
            pbDropUranus.AllowDrop = true;
            pbDropNeptune.AllowDrop = true;
        }



        private void DragcheckTimer_Tick(object sender, EventArgs e)
        {
            /* This will check to see if the user has dragged the correct images,
             while also adjusting the size of the pixturebox to make it fit accordingly,
             and making it so that the user cannot drag the same image more than once.*/

            // Picturebox 1 - Venus
            // Correct Answer
            if (pbDropVenus.Image == pbDragVenus.Image)
            {
                Correct[0] = true;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropVenus.Width = 71;
                pbDropVenus.AllowDrop = false;
            }

            // False answers
            if (pbDropVenus.Image == pbDragMars.Image)
            {
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropVenus.AllowDrop = false;
                pbDropVenus.Width = 73;
            }

            if (pbDropVenus.Image == pbDragJupiter.Image)
            {

                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropVenus.AllowDrop = false;
                pbDropVenus.Width = 52;
            }

            if (pbDropVenus.Image == pbDragUranus.Image)
            {
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropVenus.AllowDrop = false;
                pbDropVenus.Width = 64;
            }

            if (pbDropVenus.Image == pbDragNeptune.Image)
            {
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropVenus.Width = 70;
                pbDropVenus.AllowDrop = false;
            }



            // picture Box 2 - Mars
            // Correct Answer
            if (pbDropMars.Image == pbDragMars.Image)
            {
                Correct[1] = true;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropMars.Width = 73;
                pbDropMars.AllowDrop = false;
            }

            // False Answers
            if (pbDropMars.Image == pbDragVenus.Image)
            {
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropMars.Width = 71;
                pbDropMars.AllowDrop = false;
            }

            if (pbDropMars.Image == pbDragJupiter.Image)
            {
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropMars.Width = 52;
                pbDropMars.AllowDrop = false;
            }

            if (pbDropMars.Image == pbDragUranus.Image)
            {
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropMars.Width = 64;
                pbDropMars.AllowDrop = false;
            }

            if (pbDropMars.Image == pbDragNeptune.Image)
            {
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropMars.Width = 70;
                pbDropMars.AllowDrop = false;
            }



            // Picture Box 3 - Jupiter
            // Correct Answer
            if (pbDropJupiter.Image == pbDragJupiter.Image)
            {
                Correct[2] = true;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropJupiter.Width = 52;
                pbDropJupiter.AllowDrop = false;
            }

            // False Answers
            if (pbDropJupiter.Image == pbDragMars.Image)
            {
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropJupiter.Width = 73;
                pbDropJupiter.AllowDrop = false;
            }

            if (pbDropJupiter.Image == pbDragVenus.Image)
            {
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropJupiter.Width = 71;
                pbDropJupiter.AllowDrop = false;
            }

            if (pbDropJupiter.Image == pbDragUranus.Image)
            {
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropJupiter.Width = 64;
                pbDropJupiter.AllowDrop = false;
            }

            if (pbDropJupiter.Image == pbDragNeptune.Image)
            {
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropJupiter.Width = 70;
                pbDropJupiter.AllowDrop = false;
            }



            // Picture Box 4 - Uranus
            // Correct Answer
            if (pbDropUranus.Image == pbDragUranus.Image)
            {
                Correct[3] = true;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropUranus.Width = 64;
                pbDropUranus.AllowDrop = false;
            }

            // False Answers
            if (pbDropUranus.Image == pbDragMars.Image)
            {
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropUranus.Width = 73;
                pbDropUranus.AllowDrop = false;
            }

            if (pbDropUranus.Image == pbDragJupiter.Image)
            {
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropUranus.Width = 52;
                pbDropUranus.AllowDrop = false;
            }

            if (pbDropUranus.Image == pbDragVenus.Image)
            {
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropUranus.Width = 71;
                pbDropUranus.AllowDrop = false;
            }

            if (pbDropUranus.Image == pbDragNeptune.Image)
            {
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropUranus.Width = 70;
                pbDropUranus.AllowDrop = false;
            }



            // Picture Box 5 - neptune
            // Correct Answer
            if (pbDropNeptune.Image == pbDragNeptune.Image)
            {
                Correct[4] = true;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropNeptune.Width = 70;
                pbDropNeptune.AllowDrop = false;
            }

            // False Answers
            if (pbDropNeptune.Image == pbDragMars.Image)
            {
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropNeptune.Width = 73;
                pbDropNeptune.AllowDrop = false;
            }

            if (pbDropNeptune.Image == pbDragJupiter.Image)
            {
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropNeptune.Width = 52;
                pbDropNeptune.AllowDrop = false;
            }

            if (pbDropNeptune.Image == pbDragUranus.Image)
            {
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropNeptune.Width = 64;
                pbDropNeptune.AllowDrop = false;
            }

            if (pbDropNeptune.Image == pbDragVenus.Image)
            {
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropNeptune.Width = 71;
                pbDropNeptune.AllowDrop = false;
            }
        }



        private void NextQuestion_Tick(object sender, EventArgs e)
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
    }
}