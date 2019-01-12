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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();

            // Hide text
            lblHelp.Hide();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display help related to Signing in
            if (comboBox1.Text == "Signing in")
            {
                lblHelp.Show();
                lblHelp.Text = "All accounts are handled by the system administrator." +
                     Environment.NewLine +
                     "Please Contact a Teacher or assistant if you cannot login";

            }
            
            // Display help related to Drag and Drop
            if (comboBox1.Text == "Drag and Drop")
            {
                lblHelp.Show();
                lblHelp.Text = "To drag the images or text click and hold the mouse over them" +
                    Environment.NewLine +
                    "You should see a change in the cursor, that indicates that you are carring the inforamtion" +
                    Environment.NewLine +
                    "Drag the mouse to the position you belive to be correct" +
                    Environment.NewLine +
                    "You shoould see a change in the cursor when the information can be dropped.";
            }

            // Display information related to multiple Choice
            if (comboBox1.Text == "Multiple Choice")
            {
                lblHelp.Show();
                lblHelp.Text = "There should be at least two buttons on screen, clicking on one of the buttons will confirm your answer" +
                    Environment.NewLine +
                    "Clicking the correct question will reward you a point, and load the next question";
            }

            // Displaying information realted to Check Boxes
            if (comboBox1.Text == "Check Boxes")
            {
                lblHelp.Show();
                lblHelp.Text = "Within the question there should be several statements, check the ones that you believe are correct" +
                    Environment.NewLine +
                    "There is a limit to how many statements can be selected" +
                    Environment.NewLine +
                    "The button to confirm your answers will become available once you have selected the right amount";
            }
        }
    }
}
