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
    public partial class frmDifficulty : Form
    {

        // Generate random numbers
        Random random = new Random();
        int RandomNumber = 0;
        

        public frmDifficulty()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate a random number
            RandomNumber = random.Next(1, 7);

            // This section of code will be used to select a new random question. It will ensure that the user does not recieve the same question twice.
            if (RandomNumber == 1 && Globalvariables.CompletedQuestionsB[0] == false)
            {
                frmQuestion1b Question1b = new frmQuestion1b();
                this.Close();
                Question1b.Show();
            }
            else if (RandomNumber == 2 && Globalvariables.CompletedQuestionsB[1] == false)
            {
                frmQuestion2b Question2b = new frmQuestion2b();
                this.Close();
                Question2b.Show();
            }
            else if (RandomNumber == 3 && Globalvariables.CompletedQuestionsB[2] == false)
            {
                frmQuestion3b Question3b = new frmQuestion3b();
                this.Close();
                Question3b.Show();
            }
            else if (RandomNumber == 4 && Globalvariables.CompletedQuestionsB[3] == false)
            {
                frmQuestion4b Question4b = new frmQuestion4b();
                this.Close();
                Question4b.Show();
            }
            else if (RandomNumber == 5 && Globalvariables.CompletedQuestionsB[4] == false)
            {
                frmQuestion5b Question5b = new frmQuestion5b();
                this.Close();
                Question5b.Show();
            }
            else if (RandomNumber == 6 && Globalvariables.CompletedQuestionsB[5] == false)
            {
                frmQuestion6b Question6b = new frmQuestion6b();
                this.Close();
                Question6b.Show();
            }
            else if (RandomNumber == 7 && Globalvariables.CompletedQuestionsB[6] == false)
            {
                frmQuestion7b Question7b = new frmQuestion7b();
                this.Close();
                Question7b.Show();
            }
        }



        private void btnIntermediate_Click(object sender, EventArgs e)
        {
            // Generate a random number
            RandomNumber = random.Next(1, 7);

            // This section of code will be used to select a new random question. It will ensure that the user does not recieve the same question twice.
            if (RandomNumber == 1 && Globalvariables.CompletedQuestionsI[0] == false)
            {
                frmQuestion1i Question1i = new frmQuestion1i();
                this.Close();
                Question1i.Show();
            }
            else if (RandomNumber == 2 && Globalvariables.CompletedQuestionsI[1] == false)
            {
                frmQuestion2i Question2i = new frmQuestion2i();
                this.Close();
                Question2i.Show();
            }
            else if (RandomNumber == 3 && Globalvariables.CompletedQuestionsI[2] == false)
            {
                frmQuestion3i Question3i = new frmQuestion3i();
                this.Close();
                Question3i.Show();
            }
            else if (RandomNumber == 4 && Globalvariables.CompletedQuestionsI[3] == false)
            {
                frmQuestion4 Question4i = new frmQuestion4();
                this.Close();
                Question4i.Show();
            }
            else if (RandomNumber == 5 && Globalvariables.CompletedQuestionsI[4] == false)
            {
                frmQuestion5i Question5i = new frmQuestion5i();
                this.Close();
                Question5i.Show();
            }
            else if (RandomNumber == 6 && Globalvariables.CompletedQuestionsI[5] == false)
            {
                frmQuestion6i Question6i = new frmQuestion6i();
                this.Close();
                Question6i.Show();
            }
            else if (RandomNumber == 7 && Globalvariables.CompletedQuestionsI[6] == false)
            {
                frmQuestion7i Question7i = new frmQuestion7i();
                this.Close();
                Question7i.Show();
            }
        }

    }
}
