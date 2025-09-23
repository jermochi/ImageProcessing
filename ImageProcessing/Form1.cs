using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void processImage_Click(object sender, EventArgs e)
        {
            if (basicCopy.Checked)
            {
                BasicCopy();
            }
            else if (greyScale.Checked)
            {
                GrayScale();
            }
            else if (colorInversion.Checked)
            {
                ColorInversion();
            }
            else if (histogram.Checked)
            {
           
            }
            else if (sepia.Checked)
            {

            }
            else
            {
                MessageBox.Show("Select a process option.");
                return;
            }
        }
        public void BasicCopy()
        {
            if (originalBox.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            Bitmap source = new Bitmap(originalBox.Image);
            Bitmap copy = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.A, pixelColor.R, pixelColor.G, pixelColor.B);
                    copy.SetPixel(x, y, newColor);
                }
            }
            processedBox.Image = copy;
            processedBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void GrayScale()
        {
            if (originalBox.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            Bitmap source = new Bitmap(originalBox.Image);
            Bitmap copy = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);
                    int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color gray = Color.FromArgb(pixelColor.A, avg, avg, avg);
                    copy.SetPixel(x, y, gray);
                }
            }
            processedBox.Image = copy;
            processedBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void ColorInversion()
        {
            if (originalBox.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            Bitmap source = new Bitmap(originalBox.Image);
            Bitmap copy = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);
                    Color inverted = Color.FromArgb(pixelColor.A, 255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    copy.SetPixel(x, y, inverted);
                }
            }
            processedBox.Image = copy;
            processedBox.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            originalBox.Image = null;
            processedBox.Image = null; 
        }
    }
}
