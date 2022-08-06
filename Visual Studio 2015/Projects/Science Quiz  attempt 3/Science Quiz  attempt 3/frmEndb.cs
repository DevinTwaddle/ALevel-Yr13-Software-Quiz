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
    public partial class frmEndb : Form
    {
        public frmEndb()
        {
            InitializeComponent();

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

            // label changes
            lblScore.Text = Convert.ToString(Globalvariables.points);
            lblUserName.Text = Convert.ToString(Globalvariables.username);
            lblTime.Text = "You completed the quiz within  :  " + Convert.ToString(Globalvariables.timer) + " Seconds.";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmImprovements improvements = new frmImprovements();
            this.Hide();
            improvements.Show();
        }

        private void frmEndb_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
