using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessing
{
    public partial class SubtractionForm : Form
    {
        public SubtractionForm()
        {
            InitializeComponent();
            basicCopy.Checked = false;
            greyScale.Checked = false;
            colorInversion.Checked = false;
            histogram.Checked = false;
            sepia.Checked = false;
            subtraction.Checked = false;
        }

        private void basicCopy_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }

        private void greyScale_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }

        private void colorInversion_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }

        private void histogram_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }

        private void sepia_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
        }
    }
}
