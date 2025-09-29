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

        private void processImage_Click(object sender, EventArgs e)
        {
            if (originalBox.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            Bitmap source = new Bitmap(originalBox.Image);

            if (smooth.Checked)
            {
                Smooth(source, 1);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (gaussian.Checked)
            {
                GaussianBlur(source, 4);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (sharpen.Checked)
            {
                Sharpen(source, 11);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (meanRemoval.Checked)
            {
                MeanRemoval(source, 9);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (embossLaplascian.Checked)
            {
                EmbossLaplascian(source, 4);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if (horzvert.Checked)
            {
                HorzVert(source, 4);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (allDir.Checked)
            {
                AllDir(source, 8);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if (lossy.Checked)
            {
                Lossy(source, 4);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (horz.Checked)
            {
                Horz(source, 2);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (vert.Checked)
            {
                Vert(source, 0);
                processedBox.Image = source;
                processedBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        public static bool Vert(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.TopMid = -1;
            m.BottomMid = 1;
            m.Pixel = nWeight;
            m.Factor = nWeight + 1;
            m.Offset = 127;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool Horz(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.MidLeft = m.MidRight = -1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 1;
            m.Offset = 127;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool Lossy(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-2);
            m.TopLeft = m.TopRight = m.BottomMid = 1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 3;
            m.Offset = 127;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool AllDir(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = nWeight;
            m.Factor = nWeight - 7;
            m.Offset = 127;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool HorzVert(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.MidLeft = m.MidRight = m.BottomMid = m.TopMid = -1;
            m.Pixel = nWeight;
            m.Factor = nWeight - 3;
            m.Offset = 127;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool EmbossLaplascian(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.MidLeft = m.MidRight = m.BottomMid = m.TopMid = 0;
            m.Pixel = nWeight;
            m.Factor = nWeight - 3;
            m.Offset = 127;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool MeanRemoval(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);   
            m.Pixel = nWeight;
            m.Factor = nWeight - 8;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool Sharpen(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.MidLeft = m.MidRight = m.BottomMid = m.TopMid = -2;
            m.Pixel = nWeight;
            m.Factor = nWeight - 8;
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool GaussianBlur(Bitmap b, int nWeight)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);        
            m.MidLeft = m.MidRight = m.BottomMid = m.TopMid = 2; 
            m.Pixel = nWeight;   
            m.Factor = nWeight + 12; 
            return BitmapFilter.Conv3x3(b, m);
        }
        public static bool Smooth(Bitmap b, int nWeight /* default to 1 */)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.Factor = nWeight + 8;
            return BitmapFilter.Conv3x3(b, m);
        }
    }
}
