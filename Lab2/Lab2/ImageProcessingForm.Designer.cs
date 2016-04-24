namespace Lab2
{
    partial class ImageProcessingForm
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
            System.Windows.Forms.Button medicalButton;
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcessingForm));
            this.targetPictureBox = new System.Windows.Forms.PictureBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.redProcessingButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.targetPictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectSecondButton = new System.Windows.Forms.Button();
            this.differenceButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.gamaButton = new System.Windows.Forms.Button();
            this.gamaTextBox = new System.Windows.Forms.TextBox();
            this.binarizationButton = new System.Windows.Forms.Button();
            this.coparisonTextBox = new System.Windows.Forms.TextBox();
            this.pointAButton = new System.Windows.Forms.Button();
            this.medianaFilterButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            medicalButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalButton
            // 
            medicalButton.Location = new System.Drawing.Point(794, 389);
            medicalButton.Name = "medicalButton";
            medicalButton.Size = new System.Drawing.Size(237, 27);
            medicalButton.TabIndex = 17;
            medicalButton.Text = "Pseudocoloring medical image";
            medicalButton.UseVisualStyleBackColor = true;
            medicalButton.Click += new System.EventHandler(this.medicalButton_Click);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(794, 422);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(237, 27);
            button1.TabIndex = 18;
            button1.Text = "Improve biomedical image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // targetPictureBox
            // 
            this.targetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("targetPictureBox.Image")));
            this.targetPictureBox.Location = new System.Drawing.Point(21, 83);
            this.targetPictureBox.Name = "targetPictureBox";
            this.targetPictureBox.Size = new System.Drawing.Size(300, 300);
            this.targetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPictureBox.TabIndex = 0;
            this.targetPictureBox.TabStop = false;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(21, 12);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(97, 23);
            this.selectImageButton.TabIndex = 2;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(124, 12);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(93, 23);
            this.saveImageButton.TabIndex = 3;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // redProcessingButton
            // 
            this.redProcessingButton.Location = new System.Drawing.Point(21, 41);
            this.redProcessingButton.Name = "redProcessingButton";
            this.redProcessingButton.Size = new System.Drawing.Size(75, 23);
            this.redProcessingButton.TabIndex = 4;
            this.redProcessingButton.Text = "Make it red";
            this.redProcessingButton.UseVisualStyleBackColor = true;
            this.redProcessingButton.Click += new System.EventHandler(this.redProcessingButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("resultPictureBox.Image")));
            this.resultPictureBox.Location = new System.Drawing.Point(351, 83);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(300, 300);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 1;
            this.resultPictureBox.TabStop = false;
            // 
            // targetPictureBox2
            // 
            this.targetPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("targetPictureBox2.Image")));
            this.targetPictureBox2.Location = new System.Drawing.Point(677, 83);
            this.targetPictureBox2.Name = "targetPictureBox2";
            this.targetPictureBox2.Size = new System.Drawing.Size(300, 300);
            this.targetPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPictureBox2.TabIndex = 5;
            this.targetPictureBox2.TabStop = false;
            // 
            // selectSecondButton
            // 
            this.selectSecondButton.Location = new System.Drawing.Point(677, 54);
            this.selectSecondButton.Name = "selectSecondButton";
            this.selectSecondButton.Size = new System.Drawing.Size(97, 23);
            this.selectSecondButton.TabIndex = 6;
            this.selectSecondButton.Text = "Select Image";
            this.selectSecondButton.UseVisualStyleBackColor = true;
            this.selectSecondButton.Click += new System.EventHandler(this.selectSecondButton_Click);
            // 
            // differenceButton
            // 
            this.differenceButton.Location = new System.Drawing.Point(102, 41);
            this.differenceButton.Name = "differenceButton";
            this.differenceButton.Size = new System.Drawing.Size(75, 23);
            this.differenceButton.TabIndex = 7;
            this.differenceButton.Text = "Difference";
            this.differenceButton.UseVisualStyleBackColor = true;
            this.differenceButton.Click += new System.EventHandler(this.differenceButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(183, 41);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(75, 23);
            this.reverseButton.TabIndex = 8;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // gamaButton
            // 
            this.gamaButton.Location = new System.Drawing.Point(351, 12);
            this.gamaButton.Name = "gamaButton";
            this.gamaButton.Size = new System.Drawing.Size(119, 23);
            this.gamaButton.TabIndex = 11;
            this.gamaButton.Text = "Gama correction";
            this.gamaButton.Click += new System.EventHandler(this.gamaButton_Click);
            // 
            // gamaTextBox
            // 
            this.gamaTextBox.Location = new System.Drawing.Point(476, 12);
            this.gamaTextBox.Name = "gamaTextBox";
            this.gamaTextBox.Size = new System.Drawing.Size(119, 20);
            this.gamaTextBox.TabIndex = 10;
            this.gamaTextBox.Text = "1";
            this.gamaTextBox.TextChanged += new System.EventHandler(this.gamaTextBox_TextChanged);
            // 
            // binarizationButton
            // 
            this.binarizationButton.Location = new System.Drawing.Point(351, 41);
            this.binarizationButton.Name = "binarizationButton";
            this.binarizationButton.Size = new System.Drawing.Size(119, 23);
            this.binarizationButton.TabIndex = 12;
            this.binarizationButton.Text = "Binarization";
            this.binarizationButton.Click += new System.EventHandler(this.binarizationButton_Click);
            // 
            // coparisonTextBox
            // 
            this.coparisonTextBox.Location = new System.Drawing.Point(476, 44);
            this.coparisonTextBox.Name = "coparisonTextBox";
            this.coparisonTextBox.Size = new System.Drawing.Size(119, 20);
            this.coparisonTextBox.TabIndex = 13;
            this.coparisonTextBox.Text = "127";
            // 
            // pointAButton
            // 
            this.pointAButton.Location = new System.Drawing.Point(21, 389);
            this.pointAButton.Name = "pointAButton";
            this.pointAButton.Size = new System.Drawing.Size(237, 27);
            this.pointAButton.TabIndex = 14;
            this.pointAButton.Text = "Mediation and fitering top-bottom";
            this.pointAButton.UseVisualStyleBackColor = true;
            this.pointAButton.Click += new System.EventHandler(this.pointAButton_Click);
            // 
            // medianaFilterButton
            // 
            this.medianaFilterButton.Location = new System.Drawing.Point(547, 389);
            this.medianaFilterButton.Name = "medianaFilterButton";
            this.medianaFilterButton.Size = new System.Drawing.Size(237, 27);
            this.medianaFilterButton.TabIndex = 16;
            this.medianaFilterButton.Text = "Median filter";
            this.medianaFilterButton.UseVisualStyleBackColor = true;
            this.medianaFilterButton.Click += new System.EventHandler(this.medianaFilterButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "Outline emphasis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(677, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Outline";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(806, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Thinning";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ImageProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 452);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(button1);
            this.Controls.Add(medicalButton);
            this.Controls.Add(this.medianaFilterButton);
            this.Controls.Add(this.targetPictureBox2);
            this.Controls.Add(this.pointAButton);
            this.Controls.Add(this.coparisonTextBox);
            this.Controls.Add(this.binarizationButton);
            this.Controls.Add(this.gamaTextBox);
            this.Controls.Add(this.gamaButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.differenceButton);
            this.Controls.Add(this.selectSecondButton);
            this.Controls.Add(this.redProcessingButton);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.targetPictureBox);
            this.Name = "ImageProcessingForm";
            this.Text = "ImageProcessingForm";
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox targetPictureBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button redProcessingButton;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.PictureBox targetPictureBox2;
        private System.Windows.Forms.Button selectSecondButton;
        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button gamaButton;
        private System.Windows.Forms.TextBox gamaTextBox;
        private System.Windows.Forms.Button binarizationButton;
        private System.Windows.Forms.TextBox coparisonTextBox;
        private System.Windows.Forms.Button pointAButton;
        private System.Windows.Forms.Button medianaFilterButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}