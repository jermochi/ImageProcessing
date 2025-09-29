using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class ConvolutionForm : Form
    {
        Device[] devices;
        Device selectedDevice;
        bool isPreviewing = false;
        public ConvolutionForm()
        {

            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
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
                originalBox.Image = Image.FromFile(ofd.FileName);
                originalBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            originalBox.Image = null;
            processedBox.Image = null;
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

                selectedDevice.ShowWindow(originalBox);
                camera.Text = "Capture";
                isPreviewing = true;
            }
            else
            {
                selectedDevice.Sendmessage();
                if (Clipboard.ContainsImage())
                {
                    var img = Clipboard.GetImage();
                    originalBox.Image = new System.Drawing.Bitmap(img);
                }

                selectedDevice.Stop();
                camera.Text = "Use Camera";
                originalBox.SizeMode = PictureBoxSizeMode.Zoom;
                isPreviewing = false;
            }
        }
    }
}
