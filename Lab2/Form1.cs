using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picBoxInitial.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RGBbutton_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(picBoxInitial.Image);
            Color color;
            for(int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    color = Color.FromArgb(color.R, 0 ,0);
                    image.SetPixel(i, j, color);
                }
            }
            picBoxRed.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    color = Color.FromArgb(0, color.G, 0);
                    image.SetPixel(i, j, color);
                }
            }
            picBoxGreen.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    color = Color.FromArgb(0, 0, color.B);
                    image.SetPixel(i, j, color);
                }
            }
            picBoxBlue.Image = image;
        }

        private void YCrCbButton_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(picBoxInitial.Image);
            Color color;
            double[,] y = new double[image.Width, image.Height];
            double[,] cb = new double[image.Width, image.Height];
            double[,] cr = new double[image.Width, image.Height];
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    y[i, j] = Math.Round(0.299 * color.R + 0.578 * color.G + 0.114 * color.B);
                    cb[i, j] = Math.Round(128 - (0.168736 * color.R) - (0.331264 * color.G) + (0.5 * color.B));
                    cr[i, j] = Math.Round(128 + (0.5 * color.R) - (0.418688 * color.G) - (0.081312 * color.B));
                    if (y[i, j] < 0) y[i, j] = 0; if (y[i, j] > 255) y[i, j] = 255;
                    if (cb[i, j] < 0) cb[i, j] = 0; if (cb[i, j] > 255) cb[i, j] = 255;
                    if (cr[i, j] < 0) cr[i, j] = 0; if (cr[i, j] > 255) cr[i, j] = 255;
                    
                }
            }
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = Color.FromArgb((int)y[i, j], (int)y[i, j], (int)y[i, j]);
                    image.SetPixel(i, j, color);
                }
            }
            picBoxY.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = Color.FromArgb((int)cb[i, j], (int)cb[i, j], (int)cb[i, j]);
                    image.SetPixel(i, j, color);
                }
            }
            picBoxCb.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = Color.FromArgb((int)cr[i, j], (int)cr[i, j], (int)cr[i, j]);
                    image.SetPixel(i, j, color);
                }
            }
            picBoxCr.Image = image;
        }

        private void restoreRGBButton_Click(object sender, EventArgs e)
        {
            Bitmap imageRed = new Bitmap(picBoxRed.Image);
            Bitmap imageGreen = new Bitmap(picBoxGreen.Image);
            Bitmap imageBlue = new Bitmap(picBoxBlue.Image);
            Color color, colorRed, colorGreen, colorBlue;
            for (int i = 0; i < imageRed.Width; i++)
            {
                for (int j = 0; j < imageRed.Height; j++)
                {
                    colorRed = imageRed.GetPixel(i, j);
                    colorGreen = imageGreen.GetPixel(i, j);
                    colorBlue = imageBlue.GetPixel(i, j);
                    color = Color.FromArgb(colorRed.R, colorGreen.G, colorBlue.B);
                    imageRed.SetPixel(i, j, color);
                }
            }
            picBoxRestored.Image = imageRed;
        }

        private void YCrCbRestore_Click(object sender, EventArgs e)
        {
            Bitmap imageY = new Bitmap(picBoxY.Image);
            Bitmap imageCb = new Bitmap(picBoxCb.Image);
            Bitmap imageCr = new Bitmap(picBoxCr.Image);
            Color[,] colors = new Color[imageY.Width, imageY.Height];
            for (int i = 0; i < imageY.Width; i++)
            {
                for (int j = 0; j < imageY.Height; j++)
                {
                    double r = Math.Round(imageY.GetPixel(i, j).R + 1.402*(imageCr.GetPixel(i,j).R - 128));
                    double g = Math.Round(imageY.GetPixel(i, j).R - 0.34414 * (imageCb.GetPixel(i,j).R - 128) - 0.71414 * (imageCr.GetPixel(i, j).R - 128));
                    double b = Math.Round(imageY.GetPixel(i, j).R + 1.772 * (imageCb.GetPixel(i, j).R - 128));
                    if (r < 0) r = 0; if (r > 255) r = 255;
                    if (g < 0) g = 0; if (g > 255) g = 255;
                    if (b < 0) b = 0; if (b > 255) b = 255;
                    colors[i, j] = Color.FromArgb((int)r, (int)g, (int)b);
                    imageY.SetPixel(i, j, colors[i, j]);
                }
            }
            picBoxRestored.Image = imageY;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void waveletButton_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(picBoxInitial.Image);
            Color color, colorFQ, colorSQ, colorTQ, colorFoQ;
            double[,] y = new double[image.Width, image.Height];
            int[,] firstQuarter = new int[image.Width, image.Height];
            int[,] secondQuarter = new int[image.Width, image.Height];
            int[,] thirdQuarter = new int[image.Width, image.Height];
            int[,] fourthQuarter = new int[image.Width, image.Height];
            for (int i = 0; i < image.Width; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    y[i, j] = Math.Round(0.299 * color.R + 0.578 * color.G + 0.114 * color.B);
                    if (y[i, j] < 0) y[i, j] = 0; if (y[i, j] > 255) y[i, j] = 255;
                }    
            }
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height - 1; j+=2)
                {
                    firstQuarter[i, j] = (int)(y[j, i] + y[j + 1, i]) / 2;
                    if (firstQuarter[i, j] < 0) firstQuarter[i, j] = 0; if (firstQuarter[i, j] > 255) firstQuarter[i, j] = 255;
                    secondQuarter[i, j] = (int)(y[j, i] - y[j + 1, i]) / 2;
                    if (secondQuarter[i, j] < 0) secondQuarter[i, j] = 0; if (secondQuarter[i, j] > 255) secondQuarter[i, j] = 255;
                }
            }
            for(int i = 0; i < image.Width; i++)
            {
                for(int j = 0; j < image.Height - 1; j+=2)
                {
                    thirdQuarter[i, j] = (firstQuarter[i, j ] + firstQuarter[i, j + 1]) / 2;
                    if (thirdQuarter[i, j] < 0) thirdQuarter[i, j] = 0; if (thirdQuarter[i, j] > 255) thirdQuarter[i, j] = 255;
                    fourthQuarter[i, j] = (thirdQuarter[i, j] - thirdQuarter[i, j + 1]) / 2;
                    if (fourthQuarter[i, j] < 0) fourthQuarter[i, j] = 0; if (fourthQuarter[i, j] > 255) fourthQuarter[i, j] = 255;
                }
            }    

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    colorFQ = Color.FromArgb(firstQuarter[i, j], firstQuarter[i, j], firstQuarter[i, j]);
                    image.SetPixel(i, j, colorFQ);
                }
            }
            picBoxY.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    colorSQ = Color.FromArgb(secondQuarter[i, j], secondQuarter[i, j], secondQuarter[i, j]);
                    image.SetPixel(i, j, colorSQ);
                }
            }
            picBoxWL1.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    colorTQ = Color.FromArgb(thirdQuarter[i, j], thirdQuarter[i, j], thirdQuarter[i, j]);
                    image.SetPixel(i, j, colorTQ);
                }
            }
            picBoxWL2.Image = image;
            image = new Bitmap(picBoxInitial.Image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    colorFoQ = Color.FromArgb(fourthQuarter[i, j], fourthQuarter[i, j], fourthQuarter[i, j]);
                    image.SetPixel(i, j, colorFoQ);
                }
            }
            picBoxWL3.Image = image;
        }
    }
}
