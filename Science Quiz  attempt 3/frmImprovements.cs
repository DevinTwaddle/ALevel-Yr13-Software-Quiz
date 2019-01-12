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
    public partial class frmImprovements : Form
    {

        bool[] labelUsed = new bool[5];
        bool[] AlreadyUsed = new bool[7];


        public frmImprovements()
        {
            InitializeComponent();

            // Hide labels
            lblquestion1.Hide();
            lblquestion2.Hide();
            lblquestion3.Hide();
            lblquestion4.Hide();
            lblquestion5.Hide();
            lblquestion6.Hide();
            lblquestion7.Hide();



            // For the end of the quiz, I want it to tell the user if there are any improvements which could be made,
            // by looking at the questions which they have answered.


            // This block will check to see which questions have been answered.
            // Beginner
            // Question (1)
            if (Globalvariables.CompletedQuestionsB[0] == true)
            {
                lblquestion1.Show();
                if (Globalvariables.QuestionsCorrectB[0] == true)
                {
                    lblquestion1.Text = "Number of planets - Correct"
                        + Environment.NewLine
                        + "congratulations you answered correctly,"
                        + Environment.NewLine
                        + "There are 9 planets present within our solar system (including pluto)";
                }
                if (Globalvariables.QuestionsCorrectB[0] == false)
                {
                    lblquestion1.Text = "Number of planets - Incorrect"
                       + Environment.NewLine
                       + "Sorry the answer which you provide was incorrect,"
                       + Environment.NewLine
                        + "Please revise this topic, and try again.";
                }
            }
            // Question (2)
            if (Globalvariables.CompletedQuestionsB[1] == true)
            {
                lblquestion2.Show();
                if (Globalvariables.QuestionsCorrectB[1] == true)
                {
                    lblquestion2.Text = "True and False - Correct"
                        + Environment.NewLine
                        + "You answered this question perfectly!";
                }
                if (Globalvariables.QuestionsCorrectB[1] == false)
                {
                    lblquestion2.Text = "True and False - Incorrect"
                        + Environment.NewLine
                        + "You seem to have not answered this question perfectly."
                         + Environment.NewLine
                        + "Please revise some more on this question, and try again.";
                }
            }

            // Question (3)
             if (Globalvariables.CompletedQuestionsB[2] == true)
            {
                lblquestion3.Show();
                if (Globalvariables.QuestionsCorrectB[2] == true)
                {
                    lblquestion3.Text = "Planet Drag and Drop - Correct"
                        + Environment.NewLine
                        + "You were able to drag the planets into the correct order!"
                    + Environment.NewLine
                       + "Congradulations, you know our solar system.";
                }
                if (Globalvariables.QuestionsCorrectB[2] == false)
                {
                    lblquestion3.Text = "Planet Drag and Drop - Incorrect"
                        + Environment.NewLine
                        + "it seems that you did not align the planets correctly."
                         + Environment.NewLine
                        + "Please revise the order of the planets, and try again.";
                }
            }

            // Question (4)
             if (Globalvariables.CompletedQuestionsB[4] == true)
            {
                lblquestion4.Show();
                if (Globalvariables.QuestionsCorrectB[3] == true)
                {
                    lblquestion4.Text = "Why the sun is at the centre of the solar system - Correct"
                        + Environment.NewLine
                        + "You answered this question correctly";
                }
                if (Globalvariables.QuestionsCorrectB[3] == false)
                {
                    lblquestion4.Text = "Why the sun is at the centre of the solar system - Incorrect"
                        + Environment.NewLine
                        + "You did not select the correct answer"
                         + Environment.NewLine
                        + "Please revise this topic and try again.";
                }
            }

            // Question (5)
             if (Globalvariables.CompletedQuestionsB[4] == true)
            {
                lblquestion5.Show();
                if (Globalvariables.QuestionsCorrectB[4] == true)
                {
                    lblquestion5.Text = "Direction of sun rise - Correct"
                        + Environment.NewLine
                        + "Congradulations, the sun rises from the east.";
                }
                if (Globalvariables.QuestionsCorrectB[4] == false)
                {
                    lblquestion5.Text = "Direction of sun rise - Incorrect"
                        + Environment.NewLine
                        + "You said that the sun rises from the west, however it rises from the east.";
                }
            }

            // Question (6)
             if (Globalvariables.CompletedQuestionsB[5] == true)
            {
                lblquestion6.Show();
                if (Globalvariables.QuestionsCorrectB[5] == true)
                {
                    lblquestion6.Text = "Fossil Fuels - Correct"
                        + Environment.NewLine
                        + "You were able to identify all of the fossil fuels, congradulations";
                }
                if (Globalvariables.QuestionsCorrectB[5] == false)
                {
                    lblquestion6.Text = "Fossil Fuels - Incorrect"
                        + Environment.NewLine
                        + "It would seem that you did not identify all of the fossil fuels"
                         + Environment.NewLine
                        + "Please revise some more on this question, and try again.";
                }
            }

            // Question (7)
             if (Globalvariables.CompletedQuestionsB[6] == true)
            {
                lblquestion7.Show();
                if (Globalvariables.QuestionsCorrectB[6] == true)
                {
                    lblquestion7.Text = "Misc Questions - Correct"
                        + Environment.NewLine
                        + "You answered this question perfectly!";
                }
                if (Globalvariables.QuestionsCorrectB[6] == false)
                {
                    lblquestion7.Text = "True and False - Incorrect"
                        + Environment.NewLine
                        + "You seem to have not answered this question perfectly."
                         + Environment.NewLine
                        + "Please revise some more on this question, and try again.";
                }
            }



            // Intermediate
            // Question (1)
            if (Globalvariables.CompletedQuestionsI[0] == true)
            {
                lblquestion1.Show();
                if (Globalvariables.QuestionsCorrectI[0] == true)
                {
                    lblquestion1.Text = "Number of planets - Correct"
                        + Environment.NewLine
                        + "congratulations you answered correctly,"
                        + Environment.NewLine
                        + "There are 9 planets present within our solar system (including pluto)";
                }
                if (Globalvariables.QuestionsCorrectI[0] == false)
                {
                    lblquestion1.Text = "Number of planets - Incorrect"
                       + Environment.NewLine
                       + "Sorry the answer which you provide was incorrect,"
                       + Environment.NewLine
                        + "Please revise this topic, and try again.";
                }
            }
            // Question (2)
            if (Globalvariables.CompletedQuestionsI[1] == true)
            {
                lblquestion2.Show();
                if (Globalvariables.QuestionsCorrectI[1] == true)
                {
                    lblquestion2.Text = "True and False - Correct"
                        + Environment.NewLine
                        + "You answered this question perfectly!";
                }
                if (Globalvariables.QuestionsCorrectI[1] == false)
                {
                    lblquestion2.Text = "True and False - Incorrect"
                        + Environment.NewLine
                        + "You seem to have not answered this question perfectly."
                         + Environment.NewLine
                        + "Please revise some more on this question, and try again.";
                }
            }

            // Question (3)
            if (Globalvariables.CompletedQuestionsI[2] == true)
            {
                lblquestion3.Show();
                if (Globalvariables.QuestionsCorrectI[2] == true)
                {
                    lblquestion3.Text = "Planet Drag and Drop - Correct"
                        + Environment.NewLine
                        + "You were able to drag the planets into the correct order!"
                    + Environment.NewLine
                       + "Congradulations, you know our solar system.";
                }
                if (Globalvariables.QuestionsCorrectI[2] == false)
                {
                    lblquestion3.Text = "Planet Drag and Drop - Incorrect"
                        + Environment.NewLine
                        + "it seems that you did not align the planets correctly."
                         + Environment.NewLine
                        + "Please revise the order of the planets, and try again.";
                }
            }

            // Question (4)
            if (Globalvariables.CompletedQuestionsI[3] == true)
            {
                lblquestion4.Show();
                if (Globalvariables.QuestionsCorrectI[3] == true)
                {
                    lblquestion4.Text = "Why the sun is at the centre of the solar system - Correct"
                        + Environment.NewLine
                        + "You answered this question correctly";
                }
                if (Globalvariables.QuestionsCorrectI[3] == false)
                {
                    lblquestion4.Text = "Why the sun is at the centre of the solar system - Incorrect"
                        + Environment.NewLine
                        + "You did not select the correct answer"
                         + Environment.NewLine
                        + "Please revise this topic and try again.";
                }
            }

            // Question (5)
            if (Globalvariables.CompletedQuestionsI[4] == true)
            {
                lblquestion5.Show();
                if (Globalvariables.QuestionsCorrectI[4] == true)
                {
                    lblquestion5.Text = "Direction of sun rise - Correct"
                        + Environment.NewLine
                        + "Congradulations, the sun rises from the east.";
                }
                if (Globalvariables.QuestionsCorrectI[4] == false)
                {
                    lblquestion5.Text = "Direction of sun rise - Incorrect"
                        + Environment.NewLine
                        + "You said that the sun rises from the west, however it rises from the east.";
                }
            }

            // Question (6)
            if (Globalvariables.CompletedQuestionsI[5] == true)
            {
                lblquestion6.Show();
                if (Globalvariables.QuestionsCorrectI[5] == true)
                {
                    lblquestion6.Text = " Fossil Fuels - Correct"
                        + Environment.NewLine
                        + "You were able to identify all of the fossil fuels, congradulations";
                }
                if (Globalvariables.QuestionsCorrectI[5] == false)
                {
                    lblquestion6.Text = "Fossil Fuels - Incorrect"
                        + Environment.NewLine
                        + "It would seem that you did not identify all of the fossil fuels"
                         + Environment.NewLine
                        + "Please revise some more on this question, and try again.";
                }
            }

            // Question (7)
            if (Globalvariables.CompletedQuestionsI[6] == true)
            {
                lblquestion7.Show();
                if (Globalvariables.QuestionsCorrectI[6] == true)
                {
                    lblquestion7.Text = "Misc Questions - Correct"
                        + Environment.NewLine
                        + "You answered this question perfectly!";
                }
                if (Globalvariables.QuestionsCorrectI[6] == false)
                {
                    lblquestion7.Text = "Misc Question - Incorrect"
                        + Environment.NewLine
                        + "You seem to have not answered this question perfectly."
                         + Environment.NewLine
                        + "Please revise some more on this question, and try again.";
                }
            }
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
