namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxRestored = new System.Windows.Forms.PictureBox();
            this.picBoxInitial = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBoxBlue = new System.Windows.Forms.PictureBox();
            this.picBoxGreen = new System.Windows.Forms.PictureBox();
            this.picBoxRed = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBoxCb = new System.Windows.Forms.PictureBox();
            this.picBoxCr = new System.Windows.Forms.PictureBox();
            this.picBoxY = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picBoxWL3 = new System.Windows.Forms.PictureBox();
            this.picBoxWL2 = new System.Windows.Forms.PictureBox();
            this.picBoxWL1 = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.RGBbutton = new System.Windows.Forms.Button();
            this.YCrCbButton = new System.Windows.Forms.Button();
            this.restoreRGBButton = new System.Windows.Forms.Button();
            this.YCrCbRestore = new System.Windows.Forms.Button();
            this.waveletButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInitial)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxY)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWL1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxRestored);
            this.groupBox1.Controls.Add(this.picBoxInitial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исх./Восст. изображение";
            // 
            // picBoxRestored
            // 
            this.picBoxRestored.Location = new System.Drawing.Point(6, 225);
            this.picBoxRestored.Name = "picBoxRestored";
            this.picBoxRestored.Size = new System.Drawing.Size(200, 200);
            this.picBoxRestored.TabIndex = 1;
            this.picBoxRestored.TabStop = false;
            // 
            // picBoxInitial
            // 
            this.picBoxInitial.Location = new System.Drawing.Point(6, 19);
            this.picBoxInitial.Name = "picBoxInitial";
            this.picBoxInitial.Size = new System.Drawing.Size(200, 200);
            this.picBoxInitial.TabIndex = 0;
            this.picBoxInitial.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBoxBlue);
            this.groupBox2.Controls.Add(this.picBoxGreen);
            this.groupBox2.Controls.Add(this.picBoxRed);
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 650);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "R - G - B разложение";
            // 
            // picBoxBlue
            // 
            this.picBoxBlue.Location = new System.Drawing.Point(6, 431);
            this.picBoxBlue.Name = "picBoxBlue";
            this.picBoxBlue.Size = new System.Drawing.Size(200, 200);
            this.picBoxBlue.TabIndex = 3;
            this.picBoxBlue.TabStop = false;
            // 
            // picBoxGreen
            // 
            this.picBoxGreen.Location = new System.Drawing.Point(5, 225);
            this.picBoxGreen.Name = "picBoxGreen";
            this.picBoxGreen.Size = new System.Drawing.Size(200, 200);
            this.picBoxGreen.TabIndex = 2;
            this.picBoxGreen.TabStop = false;
            // 
            // picBoxRed
            // 
            this.picBoxRed.Location = new System.Drawing.Point(6, 19);
            this.picBoxRed.Name = "picBoxRed";
            this.picBoxRed.Size = new System.Drawing.Size(200, 200);
            this.picBoxRed.TabIndex = 1;
            this.picBoxRed.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBoxCb);
            this.groupBox3.Controls.Add(this.picBoxCr);
            this.groupBox3.Controls.Add(this.picBoxY);
            this.groupBox3.Location = new System.Drawing.Point(480, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 650);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Y - Cr -Cb разложение";
            // 
            // picBoxCb
            // 
            this.picBoxCb.Location = new System.Drawing.Point(6, 431);
            this.picBoxCb.Name = "picBoxCb";
            this.picBoxCb.Size = new System.Drawing.Size(200, 200);
            this.picBoxCb.TabIndex = 3;
            this.picBoxCb.TabStop = false;
            // 
            // picBoxCr
            // 
            this.picBoxCr.Location = new System.Drawing.Point(5, 225);
            this.picBoxCr.Name = "picBoxCr";
            this.picBoxCr.Size = new System.Drawing.Size(200, 200);
            this.picBoxCr.TabIndex = 2;
            this.picBoxCr.TabStop = false;
            // 
            // picBoxY
            // 
            this.picBoxY.Location = new System.Drawing.Point(6, 19);
            this.picBoxY.Name = "picBoxY";
            this.picBoxY.Size = new System.Drawing.Size(200, 200);
            this.picBoxY.TabIndex = 1;
            this.picBoxY.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picBoxWL3);
            this.groupBox4.Controls.Add(this.picBoxWL2);
            this.groupBox4.Controls.Add(this.picBoxWL1);
            this.groupBox4.Location = new System.Drawing.Point(712, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 650);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wavelet - разложение";
            // 
            // picBoxWL3
            // 
            this.picBoxWL3.Location = new System.Drawing.Point(6, 431);
            this.picBoxWL3.Name = "picBoxWL3";
            this.picBoxWL3.Size = new System.Drawing.Size(200, 200);
            this.picBoxWL3.TabIndex = 3;
            this.picBoxWL3.TabStop = false;
            // 
            // picBoxWL2
            // 
            this.picBoxWL2.Location = new System.Drawing.Point(5, 225);
            this.picBoxWL2.Name = "picBoxWL2";
            this.picBoxWL2.Size = new System.Drawing.Size(200, 200);
            this.picBoxWL2.TabIndex = 2;
            this.picBoxWL2.TabStop = false;
            // 
            // picBoxWL1
            // 
            this.picBoxWL1.Location = new System.Drawing.Point(6, 19);
            this.picBoxWL1.Name = "picBoxWL1";
            this.picBoxWL1.Size = new System.Drawing.Size(200, 200);
            this.picBoxWL1.TabIndex = 1;
            this.picBoxWL1.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(18, 453);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(204, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // RGBbutton
            // 
            this.RGBbutton.Location = new System.Drawing.Point(18, 482);
            this.RGBbutton.Name = "RGBbutton";
            this.RGBbutton.Size = new System.Drawing.Size(204, 23);
            this.RGBbutton.TabIndex = 5;
            this.RGBbutton.Text = "RGB разложение";
            this.RGBbutton.UseVisualStyleBackColor = true;
            this.RGBbutton.Click += new System.EventHandler(this.RGBbutton_Click);
            // 
            // YCrCbButton
            // 
            this.YCrCbButton.Location = new System.Drawing.Point(18, 512);
            this.YCrCbButton.Name = "YCrCbButton";
            this.YCrCbButton.Size = new System.Drawing.Size(204, 23);
            this.YCrCbButton.TabIndex = 6;
            this.YCrCbButton.Text = "Y - Cr - Cb разложение";
            this.YCrCbButton.UseVisualStyleBackColor = true;
            this.YCrCbButton.Click += new System.EventHandler(this.YCrCbButton_Click);
            // 
            // restoreRGBButton
            // 
            this.restoreRGBButton.Location = new System.Drawing.Point(18, 571);
            this.restoreRGBButton.Name = "restoreRGBButton";
            this.restoreRGBButton.Size = new System.Drawing.Size(204, 23);
            this.restoreRGBButton.TabIndex = 7;
            this.restoreRGBButton.Text = "Восстановить из RGB";
            this.restoreRGBButton.UseVisualStyleBackColor = false;
            this.restoreRGBButton.Click += new System.EventHandler(this.restoreRGBButton_Click);
            // 
            // YCrCbRestore
            // 
            this.YCrCbRestore.Location = new System.Drawing.Point(18, 600);
            this.YCrCbRestore.Name = "YCrCbRestore";
            this.YCrCbRestore.Size = new System.Drawing.Size(204, 23);
            this.YCrCbRestore.TabIndex = 8;
            this.YCrCbRestore.Text = "Восстановить из Y - Cr - Cb";
            this.YCrCbRestore.UseVisualStyleBackColor = true;
            this.YCrCbRestore.Click += new System.EventHandler(this.YCrCbRestore_Click);
            // 
            // waveletButton
            // 
            this.waveletButton.Location = new System.Drawing.Point(18, 542);
            this.waveletButton.Name = "waveletButton";
            this.waveletButton.Size = new System.Drawing.Size(204, 23);
            this.waveletButton.TabIndex = 9;
            this.waveletButton.Text = "Wavelet - разложение";
            this.waveletButton.UseVisualStyleBackColor = true;
            this.waveletButton.Click += new System.EventHandler(this.waveletButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 670);
            this.Controls.Add(this.waveletButton);
            this.Controls.Add(this.YCrCbRestore);
            this.Controls.Add(this.restoreRGBButton);
            this.Controls.Add(this.YCrCbButton);
            this.Controls.Add(this.RGBbutton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Разложение и восстановление изображения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInitial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxY)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWL1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxRestored;
        private System.Windows.Forms.PictureBox picBoxInitial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBoxBlue;
        private System.Windows.Forms.PictureBox picBoxGreen;
        private System.Windows.Forms.PictureBox picBoxRed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBoxCb;
        private System.Windows.Forms.PictureBox picBoxCr;
        private System.Windows.Forms.PictureBox picBoxY;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picBoxWL3;
        private System.Windows.Forms.PictureBox picBoxWL2;
        private System.Windows.Forms.PictureBox picBoxWL1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button RGBbutton;
        private System.Windows.Forms.Button YCrCbButton;
        private System.Windows.Forms.Button restoreRGBButton;
        private System.Windows.Forms.Button YCrCbRestore;
        private System.Windows.Forms.Button waveletButton;
    }
}

