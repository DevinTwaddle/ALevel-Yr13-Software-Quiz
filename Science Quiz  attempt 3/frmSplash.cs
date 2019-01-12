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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
             InitializeComponent();

            //Start timer. This is needed to load the progress bar.
            timer1.Start();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increase loadingbar's value
            loadingBar.Increment(1);

            // Show percentage
            lblPercent.Text = Convert.ToString(loadingBar.Value) + "%";


            // Text describing the loading process
            if (loadingBar.Value < 30)
            {
                lblProgress.Text = "Initalising";
            }
            // ( >30 )
            if (loadingBar.Value > 30)
            {
                lblProgress.Text = "Organising files";
            }
            // ( >70 )
            if (loadingBar.Value > 70)
            {
                lblProgress.Text = "Finalising";
            }
            // Finished
            if (loadingBar.Value == 100)
            {
                lblProgress.Text = "Complete";

                /// Next form
                // stop timer
                timer1.Stop();
                frmLogin formlogin = new frmLogin();
                this.Hide();
                formlogin.Show();
                
            }

        }

       
    }
}
