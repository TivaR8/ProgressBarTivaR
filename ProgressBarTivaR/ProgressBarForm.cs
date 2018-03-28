using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 28-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Factorial Do While
 * This program loads a progress bar.
*/

namespace ProgressBarTivaR
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Declaring variables and constants
            const int MAX_PROGRESS_BAR_VALUE = 100;
            int valueOfProgressBar = 0;

            // Increment to the value of progress bar till full
            do
            {
                this.prbProgress.Value = valueOfProgressBar;
                valueOfProgressBar = valueOfProgressBar + 5;
                this.Refresh();
            } while (valueOfProgressBar <= MAX_PROGRESS_BAR_VALUE);
        }
    }
}
