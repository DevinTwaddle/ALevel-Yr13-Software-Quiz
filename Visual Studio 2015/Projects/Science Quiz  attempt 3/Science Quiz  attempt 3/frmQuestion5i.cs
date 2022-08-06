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
    public partial class frmQuestion5i : Form
    {
        // Bools which will tell the application if the answer is correct or not.
        bool[] Answers = new bool[9];

        // Bools which will tell if a box does not have an image.
        bool[] Finished = new bool[9];


        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;



        public frmQuestion5i()
        {
            InitializeComponent();

            // Tell the system that this form has been used
            Globalvariables.CompletedQuestionsI[4] = true;
            Globalvariables.form += 1;

            //Start Timer
            UserTimer.Start();
            Error.Start();
            DragcheckTimer.Start();
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


            //Enable dropping
            pbDropMercury.AllowDrop = true;
            pbDropVenus.AllowDrop = true;
            pbDropEarth.AllowDrop = true;
            pbDropMars.AllowDrop = true;
            pbDropJupiter.AllowDrop = true;
            pbDropSaturn.AllowDrop = true;
            pbDropUranus.AllowDrop = true;
            pbDropNeptune.AllowDrop = true;
            pbDropPluto.AllowDrop = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmQuestion4 Question4i = new frmQuestion4();
            this.Hide();
            Question4i.Show();
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





        // The following Operations below are used to initalise the drag and drop operations when
        // the mouse is held down upon an image.
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragMercury.DoDragDrop(pbDragMercury.Image,
            DragDropEffects.Copy);
        }
        private void pbDragVenus_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragVenus.DoDragDrop(pbDragVenus.Image,
               DragDropEffects.Copy);
        }

        private void pbDragEarth_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragEarth.DoDragDrop(pbDragEarth.Image,
               DragDropEffects.Copy);
        }

        private void pbDragMars_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragMars.DoDragDrop(pbDragMars.Image,
               DragDropEffects.Copy);
        }

        private void pbDragJupiter_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragJupiter.DoDragDrop(pbDragJupiter.Image,
               DragDropEffects.Copy);
        }

        private void pbDragSaturn_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragSaturn.DoDragDrop(pbDragSaturn.Image,
               DragDropEffects.Copy);
        }

        private void pbDragUranus_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragUranus.DoDragDrop(pbDragUranus.Image,
               DragDropEffects.Copy);
        }

        private void pbDragNeptune_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragNeptune.DoDragDrop(pbDragNeptune.Image,
               DragDropEffects.Copy);
        }

        private void pbDragPluto_MouseDown(object sender, MouseEventArgs e)
        {
            pbDragPluto.DoDragDrop(pbDragPluto.Image,
               DragDropEffects.Copy);
        }





        // The operations below will ensure that the data the user is tring to insertis an image
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Move the image
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropVenus_DragEnter_1(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropEarth_DragEnter_1(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropMars_DragEnter_1(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropJupiter_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropSaturn_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropUranus_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropNeptune_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbDropPluto_DragEnter(object sender, DragEventArgs e)
        {
            // if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
        }



        // This block of code fianlises the drop, copying the image into the picturebox.
        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropMercury.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[0] = true;
        }
        private void pbDropVenus_DragDrop_1(object sender, DragEventArgs e)
        {
            // paste image
            pbDropVenus.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[1] = true;
        }

        private void pbDropEarth_DragDrop_1(object sender, DragEventArgs e)
        {
            // paste image
            pbDropEarth.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[2] = true;
        }

        private void pbDropMars_DragDrop_1(object sender, DragEventArgs e)
        {
            // paste image
            pbDropMars.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[3] = true;
        }

        private void pbDropJupiter_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropJupiter.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[4] = true;
        }

        private void pbDropSaturn_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropSaturn.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[5] = true;
        }

        private void pbDropUranus_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropUranus.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[6] = true;
        }

        private void pbDropNeptune_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropNeptune.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[7] = true;
        }

        private void pbDropPluto_DragDrop(object sender, DragEventArgs e)
        {
            // paste image
            pbDropPluto.Image =
        (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Finished[8] = true;
        }



        // This block of code is the point system, alloicating points if the correct images have been dragged.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Finished[0] == true && Finished[1] == true && Finished[2] == true && Finished[3] == true && Finished[4] == true && Finished[5] == true && Finished[6] == true && Finished[7] == true && Finished[8] == true)
            {
                // Point System
                if (Answers[0] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[1] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[2] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[3] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[4] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[5] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[6] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[7] == true)
                {
                    Globalvariables.points += 1;
                }
                if (Answers[8] == true)
                {
                    Globalvariables.points += 1;
                }


                // all answers are correct
                if (Answers[0] == true && Answers[1] == true && Answers[2] == true && Answers[3] == true && Answers[4] == true && Answers[5] == true && Answers[6] == true && Answers[7] == true && Answers[8] == true)
                {
                    Globalvariables.QuestionsCorrectI[4] = true;
                }

                // Generate a random number
                NextQuestion.Start();
                RandomNumber = random.Next(1, 7);
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

     

        private void Error_Tick(object sender, EventArgs e)
        {
            if (Finished[0] == true && Finished[1] == true && Finished[2] == true && Finished[3] == true && Finished[4] == true && Finished[5] == true && Finished[6] == true && Finished[7] == true && Finished[8] == true)
            {
                lblError.Hide();
                btnConfirm.Enabled = true;
                btnConfirm.BackColor = Color.White;
            }
            else
            {
                btnConfirm.Enabled = false;
                  lblError.Show();
                btnConfirm.BackColor = Color.Gray;
            }
        }



        private void DragcheckTimer_Tick(object sender, EventArgs e)
        {
            // This section of code will manage the planets which are being dragged by the user.
            // This includes checking to see if they are correct, and adjusting their size.
            // It will also make the draggable image boxes dissapear when a planet is dragged.

            // 1st Image box - Mercury
            // Correct
            if (pbDropMercury.Image == pbDragMercury.Image)
            {
                Answers[0] = true;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropMercury.Width = 52;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragVenus.Image)
            {
                Answers[0] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropMercury.Width = 77;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragEarth.Image)
            {
                Answers[0] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropMercury.Width = 52;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragMars.Image)
            {
                Answers[0] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropMercury.Width = 73;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragJupiter.Image)
            {
                Answers[0] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropMercury.Width = 52;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragSaturn.Image)
            {
                Answers[0] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropMercury.Width = 69;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragUranus.Image)
            {
                Answers[0] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropMercury.Width = 74;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragNeptune.Image)
            {
                Answers[0] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropMercury.Width = 70;
                pbDropMercury.AllowDrop = false;
            }
            if (pbDropMercury.Image == pbDragPluto.Image)
            {
                Answers[0] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropMercury.Width = 52;
                pbDropMercury.AllowDrop = false;
            }




            // Venus check
            if (pbDropVenus.Image == pbDragMercury.Image)
            {
                Answers[1] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropVenus.Width = 52;
                pbDropVenus.AllowDrop = false;
            }
            // Correct
            if (pbDropVenus.Image == pbDragVenus.Image)
            {
                Answers[1] = true;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropVenus.Width = 77;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragEarth.Image)
            {
                Answers[1] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropVenus.Width = 52;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragMars.Image)
            {
                Answers[1] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropVenus.Width = 73;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragJupiter.Image)
            {
                Answers[1] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropVenus.Width = 52;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragSaturn.Image)
            {
                Answers[1] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropVenus.Width = 69;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragUranus.Image)
            {
                Answers[1] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropVenus.Width = 74;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragNeptune.Image)
            {
                Answers[1] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropVenus.Width = 70;
                pbDropVenus.AllowDrop = false;
            }
            if (pbDropVenus.Image == pbDragPluto.Image)
            {
                Answers[1] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropVenus.Width = 52;
                pbDropVenus.AllowDrop = false;
            }



            // Earth check
            if (pbDropEarth.Image == pbDragMercury.Image)
            {
                Answers[2] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropEarth.Width = 52;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragVenus.Image)
            {
                Answers[2] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropEarth.Width = 77;
                pbDropEarth.AllowDrop = false;
            }
            // Correct
            if (pbDropEarth.Image == pbDragEarth.Image)
            {
                Answers[2] = true;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropEarth.Width = 52;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragMars.Image)
            {
                Answers[2] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropEarth.Width = 73;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragJupiter.Image)
            {
                Answers[2] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropEarth.Width = 52;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragSaturn.Image)
            {
                Answers[2] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropEarth.Width = 69;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragUranus.Image)
            {
                Answers[2] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropEarth.Width = 74;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragNeptune.Image)
            {
                Answers[2] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropEarth.Width = 70;
                pbDropEarth.AllowDrop = false;
            }
            if (pbDropEarth.Image == pbDragPluto.Image)
            {
                Answers[2] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropEarth.Width = 52;
                pbDropEarth.AllowDrop = false;
            }



            // Mars check
            if (pbDropMars.Image == pbDragMercury.Image)
            {
                Answers[3] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropMars.Width = 52;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragVenus.Image)
            {
                Answers[3] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropMars.Width = 77;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragEarth.Image)
            {
                Answers[3] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropMars.Width = 52;
                pbDropMars.AllowDrop = false;
            }
            // Correct
            if (pbDropMars.Image == pbDragMars.Image)
            {
                Answers[3] = true;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropMars.Width = 73;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragJupiter.Image)
            {
                Answers[3] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropMars.Width = 52;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragSaturn.Image)
            {
                Answers[3] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropMars.Width = 69;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragUranus.Image)
            {
                Answers[3] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropMars.Width = 74;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragNeptune.Image)
            {
                Answers[3] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropMars.Width = 70;
                pbDropMars.AllowDrop = false;
            }
            if (pbDropMars.Image == pbDragPluto.Image)
            {
                Answers[3] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropMars.Width = 52;
                pbDropMars.AllowDrop = false;
            }



            // Jupiter check
            if (pbDropJupiter.Image == pbDragMercury.Image)
            {
                Answers[4] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropJupiter.Width = 52;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragVenus.Image)
            {
                Answers[4] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropJupiter.Width = 77;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragEarth.Image)
            {
                Answers[4] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropJupiter.Width = 52;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragMars.Image)
            {
                Answers[4] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropJupiter.Width = 73;
                pbDropJupiter.AllowDrop = false;
            }
            // Correct
            if (pbDropJupiter.Image == pbDragJupiter.Image)
            {
                Answers[4] = true;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropJupiter.Width = 52;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragSaturn.Image)
            {
                Answers[4] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropJupiter.Width = 69;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragUranus.Image)
            {
                Answers[4] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropJupiter.Width = 74;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragNeptune.Image)
            {
                Answers[4] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropJupiter.Width = 70;
                pbDropJupiter.AllowDrop = false;
            }
            if (pbDropJupiter.Image == pbDragPluto.Image)
            {
                Answers[4] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropJupiter.Width = 52;
                pbDropJupiter.AllowDrop = false;
            }



            // Saturn check
            if (pbDropSaturn.Image == pbDragMercury.Image)
            {
                Answers[5] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropSaturn.Width = 52;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragVenus.Image)
            {
                Answers[5] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropSaturn.Width = 77;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragEarth.Image)
            {
                Answers[5] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropSaturn.Width = 52;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragMars.Image)
            {
                Answers[5] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropSaturn.Width = 73;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragJupiter.Image)
            {
                Answers[5] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropSaturn.Width = 52;
                pbDropSaturn.AllowDrop = false;
            }
            // Correct
            if (pbDropSaturn.Image == pbDragSaturn.Image)
            {
                Answers[5] = true;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropSaturn.Width = 69;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragUranus.Image)
            {
                Answers[5] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropSaturn.Width = 74;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragNeptune.Image)
            {
                Answers[5] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropSaturn.Width = 70;
                pbDropSaturn.AllowDrop = false;
            }
            if (pbDropSaturn.Image == pbDragPluto.Image)
            {
                Answers[5] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropSaturn.Width = 52;
                pbDropSaturn.AllowDrop = false;
            }



            // Uranus check
            if (pbDropUranus.Image == pbDragMercury.Image)
            {
                Answers[6] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropUranus.Width = 52;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragVenus.Image)
            {
                Answers[6] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropUranus.Width = 77;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragEarth.Image)
            {
                Answers[6] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropUranus.Width = 52;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragMars.Image)
            {
                Answers[6] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropUranus.Width = 73;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragJupiter.Image)
            {
                Answers[6] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropUranus.Width = 52;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragSaturn.Image)
            {
                Answers[6] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropUranus.Width = 69;
                pbDropUranus.AllowDrop = false;
            }
            // Correct
            if (pbDropUranus.Image == pbDragUranus.Image)
            {
                Answers[6] = true;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropUranus.Width = 74;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragNeptune.Image)
            {
                Answers[6] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropUranus.Width = 70;
                pbDropUranus.AllowDrop = false;
            }
            if (pbDropUranus.Image == pbDragPluto.Image)
            {
                Answers[6] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropUranus.Width = 52;
                pbDropUranus.AllowDrop = false;
            }



            // Neptune check
            if (pbDropNeptune.Image == pbDragMercury.Image)
            {
                Answers[7] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropNeptune.Width = 52;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragVenus.Image)
            {
                Answers[7] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropNeptune.Width = 77;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragEarth.Image)
            {
                Answers[7] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropNeptune.Width = 52;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragMars.Image)
            {
                Answers[7] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropNeptune.Width = 73;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragJupiter.Image)
            {
                Answers[7] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropNeptune.Width = 52;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragSaturn.Image)
            {
                Answers[7] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropNeptune.Width = 69;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragUranus.Image)
            {
                Answers[7] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropNeptune.Width = 74;
                pbDropNeptune.AllowDrop = false;
            }
            // Correct
            if (pbDropNeptune.Image == pbDragNeptune.Image)
            {
                Answers[7] = true;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropNeptune.Width = 70;
                pbDropNeptune.AllowDrop = false;
            }
            if (pbDropNeptune.Image == pbDragPluto.Image)
            {
                Answers[7] = false;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropNeptune.Width = 52;
                pbDropNeptune.AllowDrop = false;
            }



            // Pluto check
            if (pbDropPluto.Image == pbDragMercury.Image)
            {
                Answers[8] = false;
                pbDragMercury.Hide();
                lblMercury.Hide();
                pbDropPluto.Width = 52;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragVenus.Image)
            {
                Answers[8] = false;
                pbDragVenus.Hide();
                lblVenus.Hide();
                pbDropPluto.Width = 77;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragEarth.Image)
            {
                Answers[8] = false;
                pbDragEarth.Hide();
                lblEarth.Hide();
                pbDropPluto.Width = 52;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragMars.Image)
            {
                Answers[8] = false;
                pbDragMars.Hide();
                lblMars.Hide();
                pbDropPluto.Width = 73;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragJupiter.Image)
            {
                Answers[8] = false;
                pbDragJupiter.Hide();
                lblJupiter.Hide();
                pbDropPluto.Width = 52;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragSaturn.Image)
            {
                Answers[8] = false;
                pbDragSaturn.Hide();
                lblSaturn.Hide();
                pbDropPluto.Width = 69;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragUranus.Image)
            {
                Answers[8] = false;
                pbDragUranus.Hide();
                lblUranus.Hide();
                pbDropPluto.Width = 74;
                pbDropPluto.AllowDrop = false;
            }
            if (pbDropPluto.Image == pbDragNeptune.Image)
            {
                Answers[8] = false;
                pbDragNeptune.Hide();
                lblNeptune.Hide();
                pbDropPluto.Width = 70;
                pbDropPluto.AllowDrop = false;
            }
            // Correct
            if (pbDropPluto.Image == pbDragPluto.Image)
            {
                Answers[8] = true;
                pbDragPluto.Hide();
                lblPluto.Hide();
                pbDropPluto.Width = 52;
                pbDropPluto.AllowDrop = true;
            }
        }



        private void btnResetQuestion_Click(object sender, EventArgs e)
        {
            // This block of code will reset the question.
            // This section resets the accepting picture boxes, replacing any dragged planets with a white box.
            pbDropMercury.Image = Properties.Resources.DragDropBackground;
            pbDropVenus.Image = Properties.Resources.DragDropBackground;
            pbDropEarth.Image = Properties.Resources.DragDropBackground;
            pbDropMars.Image = Properties.Resources.DragDropBackground;
            pbDropJupiter.Image = Properties.Resources.DragDropBackground;
            pbDropSaturn.Image = Properties.Resources.DragDropBackground;
            pbDropUranus.Image = Properties.Resources.DragDropBackground;
            pbDropNeptune.Image = Properties.Resources.DragDropBackground;
            pbDropPluto.Image = Properties.Resources.DragDropBackground;

            // This section will make all pictureboxes reappear.
            pbDragMercury.Show();
            pbDragVenus.Show();
            pbDragEarth.Show();
            pbDragMars.Show();
            pbDragJupiter.Show();
            pbDragSaturn.Show();
            pbDragUranus.Show();
            pbDragNeptune.Show();
            pbDragPluto.Show();

            // This block of code will make the planet labels reappear
            lblMercury.Show();
            lblVenus.Show();
            lblEarth.Show();
            lblMars.Show();
            lblJupiter.Show();
            lblSaturn.Show();
            lblUranus.Show();
            lblNeptune.Show();
            lblPluto.Show();

            // This will let the user drag them.
            pbDropMercury.AllowDrop = true;
            pbDropVenus.AllowDrop = true;
            pbDropEarth.AllowDrop = true;
            pbDropMars.AllowDrop = true;
            pbDropJupiter.AllowDrop = true;
            pbDropSaturn.AllowDrop = true;
            pbDropUranus.AllowDrop = true;
            pbDropNeptune.AllowDrop = true;
            pbDropPluto.AllowDrop = true;

            // While the rest of this is used to reset any changed variables.
            Answers[0] = false;
            Answers[1] = false;
            Answers[2] = false;
            Answers[3] = false;
            Answers[4] = false;
            Answers[5] = false;
            Answers[6] = false;
            Answers[7] = false;
            Answers[8] = false;

            Finished[0] = false;
            Finished[1] = false;
            Finished[2] = false;
            Finished[3] = false;
            Finished[4] = false;
            Finished[5] = false;
            Finished[6] = false;
            Finished[7] = false;
            Finished[8] = false;
        }
    }
}

