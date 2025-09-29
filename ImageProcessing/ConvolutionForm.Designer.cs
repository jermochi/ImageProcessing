namespace ImageProcessing
{
    partial class ConvolutionForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.loadImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.processedBox = new System.Windows.Forms.PictureBox();
            this.horzvert = new System.Windows.Forms.RadioButton();
            this.embossLaplascian = new System.Windows.Forms.RadioButton();
            this.meanRemoval = new System.Windows.Forms.RadioButton();
            this.sharpen = new System.Windows.Forms.RadioButton();
            this.gaussian = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.originalBox = new System.Windows.Forms.PictureBox();
            this.smooth = new System.Windows.Forms.RadioButton();
            this.processImage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.camera = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allDir = new System.Windows.Forms.RadioButton();
            this.lossy = new System.Windows.Forms.RadioButton();
            this.horz = new System.Windows.Forms.RadioButton();
            this.vert = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.processedBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(27, 400);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(154, 46);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // loadImage
            // 
            this.loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.Location = new System.Drawing.Point(348, 457);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(157, 46);
            this.loadImage.TabIndex = 10;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
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
            this.processedBox.Location = new System.Drawing.Point(0, 64);
            this.processedBox.Name = "processedBox";
            this.processedBox.Size = new System.Drawing.Size(358, 263);
            this.processedBox.TabIndex = 1;
            this.processedBox.TabStop = false;
            // 
            // horzvert
            // 
            this.horzvert.AutoSize = true;
            this.horzvert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horzvert.Location = new System.Drawing.Point(19, 206);
            this.horzvert.Name = "horzvert";
            this.horzvert.Size = new System.Drawing.Size(119, 22);
            this.horzvert.TabIndex = 5;
            this.horzvert.TabStop = true;
            this.horzvert.Text = "Horz/Vertical";
            this.horzvert.UseVisualStyleBackColor = true;
            // 
            // embossLaplascian
            // 
            this.embossLaplascian.AutoSize = true;
            this.embossLaplascian.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embossLaplascian.Location = new System.Drawing.Point(17, 168);
            this.embossLaplascian.Name = "embossLaplascian";
            this.embossLaplascian.Size = new System.Drawing.Size(164, 22);
            this.embossLaplascian.TabIndex = 4;
            this.embossLaplascian.TabStop = true;
            this.embossLaplascian.Text = "Emboss Laplascian";
            this.embossLaplascian.UseVisualStyleBackColor = true;
            // 
            // meanRemoval
            // 
            this.meanRemoval.AutoSize = true;
            this.meanRemoval.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanRemoval.Location = new System.Drawing.Point(19, 130);
            this.meanRemoval.Name = "meanRemoval";
            this.meanRemoval.Size = new System.Drawing.Size(134, 22);
            this.meanRemoval.TabIndex = 3;
            this.meanRemoval.TabStop = true;
            this.meanRemoval.Text = "Mean Removal";
            this.meanRemoval.UseVisualStyleBackColor = true;
            // 
            // sharpen
            // 
            this.sharpen.AutoSize = true;
            this.sharpen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharpen.Location = new System.Drawing.Point(19, 94);
            this.sharpen.Name = "sharpen";
            this.sharpen.Size = new System.Drawing.Size(89, 22);
            this.sharpen.TabIndex = 2;
            this.sharpen.TabStop = true;
            this.sharpen.Text = "Sharpen";
            this.sharpen.UseVisualStyleBackColor = true;
            // 
            // gaussian
            // 
            this.gaussian.AutoSize = true;
            this.gaussian.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussian.Location = new System.Drawing.Point(19, 59);
            this.gaussian.Name = "gaussian";
            this.gaussian.Size = new System.Drawing.Size(129, 22);
            this.gaussian.TabIndex = 1;
            this.gaussian.TabStop = true;
            this.gaussian.Text = "Gaussian Blur";
            this.gaussian.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.processedBox);
            this.panel4.Location = new System.Drawing.Point(628, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 327);
            this.panel4.TabIndex = 9;
            // 
            // originalBox
            // 
            this.originalBox.Location = new System.Drawing.Point(0, 64);
            this.originalBox.Name = "originalBox";
            this.originalBox.Size = new System.Drawing.Size(350, 263);
            this.originalBox.TabIndex = 0;
            this.originalBox.TabStop = false;
            // 
            // smooth
            // 
            this.smooth.AutoSize = true;
            this.smooth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smooth.Location = new System.Drawing.Point(19, 21);
            this.smooth.Name = "smooth";
            this.smooth.Size = new System.Drawing.Size(83, 22);
            this.smooth.TabIndex = 0;
            this.smooth.TabStop = true;
            this.smooth.Text = "Smooth";
            this.smooth.UseVisualStyleBackColor = true;
            // 
            // processImage
            // 
            this.processImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.processImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processImage.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processImage.Location = new System.Drawing.Point(726, 457);
            this.processImage.Name = "processImage";
            this.processImage.Size = new System.Drawing.Size(157, 46);
            this.processImage.TabIndex = 11;
            this.processImage.Text = "Process";
            this.processImage.UseVisualStyleBackColor = false;
            this.processImage.Click += new System.EventHandler(this.processImage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.originalBox);
            this.panel3.Location = new System.Drawing.Point(251, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 327);
            this.panel3.TabIndex = 8;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.vert);
            this.panel2.Controls.Add(this.horz);
            this.panel2.Controls.Add(this.lossy);
            this.panel2.Controls.Add(this.allDir);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.horzvert);
            this.panel2.Controls.Add(this.embossLaplascian);
            this.panel2.Controls.Add(this.meanRemoval);
            this.panel2.Controls.Add(this.sharpen);
            this.panel2.Controls.Add(this.gaussian);
            this.panel2.Controls.Add(this.smooth);
            this.panel2.Location = new System.Drawing.Point(1, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 570);
            this.panel2.TabIndex = 7;
            // 
            // camera
            // 
            this.camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.camera.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera.Location = new System.Drawing.Point(409, 20);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(157, 46);
            this.camera.TabIndex = 7;
            this.camera.Text = "Use Camera";
            this.camera.UseVisualStyleBackColor = true;
            this.camera.Click += new System.EventHandler(this.camera_Click);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(827, 20);
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
            this.panel1.Controls.Add(this.camera);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 85);
            this.panel1.TabIndex = 6;
            // 
            // allDir
            // 
            this.allDir.AutoSize = true;
            this.allDir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDir.Location = new System.Drawing.Point(19, 245);
            this.allDir.Name = "allDir";
            this.allDir.Size = new System.Drawing.Size(123, 22);
            this.allDir.TabIndex = 9;
            this.allDir.TabStop = true;
            this.allDir.Text = "All Directions";
            this.allDir.UseVisualStyleBackColor = true;
            // 
            // lossy
            // 
            this.lossy.AutoSize = true;
            this.lossy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossy.Location = new System.Drawing.Point(19, 282);
            this.lossy.Name = "lossy";
            this.lossy.Size = new System.Drawing.Size(70, 22);
            this.lossy.TabIndex = 10;
            this.lossy.TabStop = true;
            this.lossy.Text = "Lossy";
            this.lossy.UseVisualStyleBackColor = true;
            // 
            // horz
            // 
            this.horz.AutoSize = true;
            this.horz.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horz.Location = new System.Drawing.Point(19, 319);
            this.horz.Name = "horz";
            this.horz.Size = new System.Drawing.Size(138, 22);
            this.horz.TabIndex = 11;
            this.horz.TabStop = true;
            this.horz.Text = "Horizontal Only";
            this.horz.UseVisualStyleBackColor = true;
            // 
            // vert
            // 
            this.vert.AutoSize = true;
            this.vert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vert.Location = new System.Drawing.Point(19, 355);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(117, 22);
            this.vert.TabIndex = 12;
            this.vert.TabStop = true;
            this.vert.Text = "Vertical Only";
            this.vert.UseVisualStyleBackColor = true;
            // 
            // ConvolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 558);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.processImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConvolutionForm";
            this.Text = "ConvolutionForm";
            ((System.ComponentModel.ISupportInitialize)(this.processedBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox processedBox;
        private System.Windows.Forms.RadioButton horzvert;
        private System.Windows.Forms.RadioButton embossLaplascian;
        private System.Windows.Forms.RadioButton meanRemoval;
        private System.Windows.Forms.RadioButton sharpen;
        private System.Windows.Forms.RadioButton gaussian;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox originalBox;
        private System.Windows.Forms.RadioButton smooth;
        private System.Windows.Forms.Button processImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button camera;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton lossy;
        private System.Windows.Forms.RadioButton allDir;
        private System.Windows.Forms.RadioButton vert;
        private System.Windows.Forms.RadioButton horz;
    }
}