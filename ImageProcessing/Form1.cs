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
            chart1.Visible = false; 
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
            chart1.Visible = false;
            processedBox.Visible = true;
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
                chart1.Visible = true;
                processedBox.Visible = false;
                Histogram();
            }
            else if (sepia.Checked)
            {
                Sepia();
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

        public void Histogram()
        {
            if (originalBox.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            Bitmap source = new Bitmap(originalBox.Image);
            int[] histogram = new int[256];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    histogram[gray]++;
                }
            }

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Gray Level";
            chart1.ChartAreas[0].AxisY.Title = "Frequency";
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 255;

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Histogram");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Color = Color.LightBlue;

            for (int i = 0; i < 256; i++)
            {
                series.Points.AddXY(i, histogram[i]);
            }

            chart1.Series.Add(series);
        }

        public void Sepia()
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
                    Color p = source.GetPixel(x, y);
                    int tr = (int)(0.393 * p.R + 0.769 * p.G + 0.189 * p.B);
                    int tg = (int)(0.349 * p.R + 0.686 * p.G + 0.168 * p.B);
                    int tb = (int)(0.272 * p.R + 0.534 * p.G + 0.131 * p.B);
                    if (tr > 255) tr = 255;
                    if (tg > 255) tg = 255;
                    if (tb > 255) tb = 255;
                    Color sepia = Color.FromArgb(p.A, tr, tg, tb);
                    copy.SetPixel(x, y, sepia);
                }
            }

            processedBox.Image = copy;
            processedBox.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            originalBox.Image = null;
            processedBox.Image = null;
            chart1.Visible = false;
        }
    }
}
