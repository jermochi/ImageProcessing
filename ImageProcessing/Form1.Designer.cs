namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sepia = new System.Windows.Forms.RadioButton();
            this.histogram = new System.Windows.Forms.RadioButton();
            this.colorInversion = new System.Windows.Forms.RadioButton();
            this.greyScale = new System.Windows.Forms.RadioButton();
            this.basicCopy = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.originalBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.processedBox = new System.Windows.Forms.PictureBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.processImage = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 85);
            this.panel1.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(787, 20);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(157, 46);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear Image";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image Processor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.subtraction);
            this.panel2.Controls.Add(this.sepia);
            this.panel2.Controls.Add(this.histogram);
            this.panel2.Controls.Add(this.colorInversion);
            this.panel2.Controls.Add(this.greyScale);
            this.panel2.Controls.Add(this.basicCopy);
            this.panel2.Location = new System.Drawing.Point(1, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 434);
            this.panel2.TabIndex = 1;
            // 
            // sepia
            // 
            this.sepia.AutoSize = true;
            this.sepia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepia.Location = new System.Drawing.Point(25, 255);
            this.sepia.Name = "sepia";
            this.sepia.Size = new System.Drawing.Size(69, 22);
            this.sepia.TabIndex = 4;
            this.sepia.TabStop = true;
            this.sepia.Text = "Sepia";
            this.sepia.UseVisualStyleBackColor = true;
            // 
            // histogram
            // 
            this.histogram.AutoSize = true;
            this.histogram.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogram.Location = new System.Drawing.Point(25, 210);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(101, 22);
            this.histogram.TabIndex = 3;
            this.histogram.TabStop = true;
            this.histogram.Text = "Histogram";
            this.histogram.UseVisualStyleBackColor = true;
            // 
            // colorInversion
            // 
            this.colorInversion.AutoSize = true;
            this.colorInversion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorInversion.Location = new System.Drawing.Point(25, 164);
            this.colorInversion.Name = "colorInversion";
            this.colorInversion.Size = new System.Drawing.Size(139, 22);
            this.colorInversion.TabIndex = 2;
            this.colorInversion.TabStop = true;
            this.colorInversion.Text = "Color Inversion";
            this.colorInversion.UseVisualStyleBackColor = true;
            // 
            // greyScale
            // 
            this.greyScale.AutoSize = true;
            this.greyScale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greyScale.Location = new System.Drawing.Point(25, 117);
            this.greyScale.Name = "greyScale";
            this.greyScale.Size = new System.Drawing.Size(106, 22);
            this.greyScale.TabIndex = 1;
            this.greyScale.TabStop = true;
            this.greyScale.Text = "Grey Scale";
            this.greyScale.UseVisualStyleBackColor = true;
            // 
            // basicCopy
            // 
            this.basicCopy.AutoSize = true;
            this.basicCopy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicCopy.Location = new System.Drawing.Point(25, 68);
            this.basicCopy.Name = "basicCopy";
            this.basicCopy.Size = new System.Drawing.Size(108, 22);
            this.basicCopy.TabIndex = 0;
            this.basicCopy.TabStop = true;
            this.basicCopy.Text = "Basic Copy";
            this.basicCopy.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.originalBox);
            this.panel3.Location = new System.Drawing.Point(218, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 327);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Image";
            // 
            // originalBox
            // 
            this.originalBox.Location = new System.Drawing.Point(20, 64);
            this.originalBox.Name = "originalBox";
            this.originalBox.Size = new System.Drawing.Size(311, 246);
            this.originalBox.TabIndex = 0;
            this.originalBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.processedBox);
            this.panel4.Location = new System.Drawing.Point(595, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 327);
            this.panel4.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(-21, 64);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(509, 263);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Processed Image";
            // 
            // processedBox
            // 
            this.processedBox.Location = new System.Drawing.Point(20, 64);
            this.processedBox.Name = "processedBox";
            this.processedBox.Size = new System.Drawing.Size(311, 246);
            this.processedBox.TabIndex = 1;
            this.processedBox.TabStop = false;
            // 
            // loadImage
            // 
            this.loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.Location = new System.Drawing.Point(316, 453);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(157, 46);
            this.loadImage.TabIndex = 4;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // processImage
            // 
            this.processImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.processImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processImage.Location = new System.Drawing.Point(692, 453);
            this.processImage.Name = "processImage";
            this.processImage.Size = new System.Drawing.Size(157, 46);
            this.processImage.TabIndex = 5;
            this.processImage.Text = "Process";
            this.processImage.UseVisualStyleBackColor = false;
            this.processImage.Click += new System.EventHandler(this.processImage_Click);
            // 
            // subtraction
            // 
            this.subtraction.AutoSize = true;
            this.subtraction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(25, 300);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(111, 22);
            this.subtraction.TabIndex = 5;
            this.subtraction.TabStop = true;
            this.subtraction.Text = "Subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.CheckedChanged += new System.EventHandler(this.subtraction_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 514);
            this.Controls.Add(this.processImage);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox originalBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox processedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button processImage;
        private System.Windows.Forms.RadioButton sepia;
        private System.Windows.Forms.RadioButton histogram;
        private System.Windows.Forms.RadioButton colorInversion;
        private System.Windows.Forms.RadioButton greyScale;
        private System.Windows.Forms.RadioButton basicCopy;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton subtraction;
    }
}

