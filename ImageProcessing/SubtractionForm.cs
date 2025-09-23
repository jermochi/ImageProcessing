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
        Device[] devices;
        Device selectedDevice;
        bool isPreviewing = false;
        public SubtractionForm()
        {
            InitializeComponent();
            basicCopy.Checked = false;
            greyScale.Checked = false;
            colorInversion.Checked = false;
            histogram.Checked = false;
            sepia.Checked = false;
            subtraction.Checked = true;
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

        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ABox.Image = Image.FromFile(ofd.FileName);
                ABox.SizeMode = PictureBoxSizeMode.Zoom;
                var img = new Bitmap(ABox.Image);
                label.Text = $"Resolution: {img.Width} x {img.Height}";
            }
        }

        private void loadBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BBox.Image = Image.FromFile(ofd.FileName);
                BBox.SizeMode = PictureBoxSizeMode.Zoom;
                var img = new Bitmap(BBox.Image);
                labelB.Text = $"Resolution: {img.Width} x {img.Height}";
            }
        }

        private void subtractImage_Click(object sender, EventArgs e)
        {
            if (ABox.Image == null || BBox.Image == null)
            {
                MessageBox.Show("Please load both images first.");
                return;
            }

            Bitmap imgA = new Bitmap(ABox.Image);
            Bitmap imgB = new Bitmap(BBox.Image);
            Bitmap result = new Bitmap(imgA.Width, imgA.Height);
            Color mygreen = Color.FromArgb(0,255,0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 30;

            for (int x = 0; x < imgA.Width; x++)
            {
                for (int y = 0; y < imgA.Height; y++)
                {
                    Color pixel = imgA.GetPixel(x, y);
                    Color backPixel = imgB.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if(subtractvalue < threshold && pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        result.SetPixel(x, y, backPixel);
                    }else
                    {
                        result.SetPixel(x, y, pixel);
                    }
                }
            }
            pictureBox1.Image = result;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ABox.Image = null;
            BBox.Image = null;
            pictureBox1.Image = null;
            label.Text = $"Resolution:";
            labelB.Text = $"Resolution:";
        }

        private void camera_Click(object sender, EventArgs e)
        {
            if (!isPreviewing)
            {
                if (devices == null)
                {
                    devices = DeviceManager.GetAllDevices();
                    if (devices.Length == 0)
                    {
                        MessageBox.Show("No webcam detected!");
                        return;
                    }
                    selectedDevice = devices[0];
                }

                selectedDevice.ShowWindow(ABox);
                camera.Text = "Capture";
                isPreviewing = true;
            }
            else
            {
                selectedDevice.Sendmessage();
                if (Clipboard.ContainsImage())
                {
                    var img = Clipboard.GetImage();
                    ABox.Image = new System.Drawing.Bitmap(img);
                    label.Text = $"Resolution: {img.Width} x {img.Height}";
                }

                selectedDevice.Stop();
                camera.Text = "Use Camera";
                ABox.SizeMode = PictureBoxSizeMode.Zoom;
                isPreviewing = false;
            }
        }
    }
}
