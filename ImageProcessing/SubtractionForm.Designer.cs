namespace ImageProcessing
{
    partial class SubtractionForm
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
            this.subtractImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ABox = new System.Windows.Forms.PictureBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.sepia = new System.Windows.Forms.RadioButton();
            this.histogram = new System.Windows.Forms.RadioButton();
            this.colorInversion = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.greyScale = new System.Windows.Forms.RadioButton();
            this.basicCopy = new System.Windows.Forms.RadioButton();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.loadBackground = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ABox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // subtractImage
            // 
            this.subtractImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.subtractImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractImage.Location = new System.Drawing.Point(1031, 459);
            this.subtractImage.Name = "subtractImage";
            this.subtractImage.Size = new System.Drawing.Size(249, 46);
            this.subtractImage.TabIndex = 11;
            this.subtractImage.Text = "Subtract";
            this.subtractImage.UseVisualStyleBackColor = false;
            this.subtractImage.Click += new System.EventHandler(this.subtractImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image B";
            // 
            // BBox
            // 
            this.BBox.Location = new System.Drawing.Point(0, 64);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(351, 263);
            this.BBox.TabIndex = 1;
            this.BBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.BBox);
            this.panel4.Location = new System.Drawing.Point(595, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 327);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image A";
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(0, 64);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(350, 263);
            this.ABox.TabIndex = 0;
            this.ABox.TabStop = false;
            // 
            // loadImage
            // 
            this.loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.Location = new System.Drawing.Point(267, 459);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(249, 46);
            this.loadImage.TabIndex = 10;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ABox);
            this.panel3.Location = new System.Drawing.Point(218, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 327);
            this.panel3.TabIndex = 8;
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
            this.sepia.CheckedChanged += new System.EventHandler(this.sepia_CheckedChanged);
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
            this.histogram.CheckedChanged += new System.EventHandler(this.histogram_CheckedChanged);
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
            this.colorInversion.CheckedChanged += new System.EventHandler(this.colorInversion_CheckedChanged);
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
            this.panel2.Location = new System.Drawing.Point(1, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 446);
            this.panel2.TabIndex = 7;
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
            this.greyScale.CheckedChanged += new System.EventHandler(this.greyScale_CheckedChanged);
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
            this.basicCopy.CheckedChanged += new System.EventHandler(this.basicCopy_CheckedChanged);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1144, 20);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 85);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Processed Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 263);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(972, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 327);
            this.panel5.TabIndex = 10;
            // 
            // loadBackground
            // 
            this.loadBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBackground.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBackground.Location = new System.Drawing.Point(649, 459);
            this.loadBackground.Name = "loadBackground";
            this.loadBackground.Size = new System.Drawing.Size(249, 46);
            this.loadBackground.TabIndex = 12;
            this.loadBackground.Text = "Load Background";
            this.loadBackground.UseVisualStyleBackColor = true;
            this.loadBackground.Click += new System.EventHandler(this.loadBackground_Click);
            // 
            // SubtractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 529);
            this.Controls.Add(this.loadBackground);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.subtractImage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SubtractionForm";
            this.Text = "SubtractionForm";
            ((System.ComponentModel.ISupportInitialize)(this.BBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ABox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subtractImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ABox;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton subtraction;
        private System.Windows.Forms.RadioButton sepia;
        private System.Windows.Forms.RadioButton histogram;
        private System.Windows.Forms.RadioButton colorInversion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton greyScale;
        private System.Windows.Forms.RadioButton basicCopy;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button loadBackground;
    }
}