using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            double avgY = 0;
            for(int i = 0; i < image.Width; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    Color pixColor = image.GetPixel(i,j);//kr = 0.2627 kb = 0.0593
                    avgY += 0.2627 * pixColor.R + (1 - 0.2627 - 0.0593) * pixColor.G + 0.0593 * pixColor.B;
                }
            }
            avgY /= image.Width * image.Height;
            avgY = Math.Round(avgY);
            avgY = Convert.ToInt32(avgY);
            int[] comps = new int[3];
            int temp;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixColor = image.GetPixel(i, j);
                    Color newColor = new Color();
                    temp = pixColor.R - (int)avgY;
                    temp = temp * trackBar1.Value + (int)avgY;
                    if (temp < 0) comps[0] = 0;
                    else if (temp > 255) comps[0] = 255;
                    else comps[0] = temp;

                    temp = pixColor.G - (int)avgY;
                    temp = temp * trackBar1.Value + (int)avgY;
                    if (temp < 0) comps[1] = 0;
                    else if (temp > 255) comps[1] = 255;
                    else comps[1] = temp;

                    temp = pixColor.B - (int)avgY;
                    temp = temp * trackBar1.Value + (int)avgY;
                    if (temp < 0) comps[2] = 0;
                    else if (temp > 255) comps[2] = 255;
                    else comps[2] = temp;

                    newColor = Color.FromArgb(comps[0], comps[1], comps[2]);

                    image.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Image = image;
            
        }
    }
}
