using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            // Показати діалог відкриття файлу
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Завантажити вибране зображення
                originalImage = new Bitmap(openFileDialog.FileName);

                pictureBoxOriginal.Image = originalImage;
            }
        }

        private void SuppressColorChannel(Bitmap image, ColorChannel channel)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    Color suppressedColor = Color.FromArgb(
                        channel == ColorChannel.Red     ? 0 : pixel.R,
                        channel == ColorChannel.Green   ? 0 : pixel.G,
                        channel == ColorChannel.Blue    ? 0 : pixel.B);

                    image.SetPixel(x, y, suppressedColor);
                }
            }
        }

        private enum ColorChannel
        {
            Red,
            Green,
            Blue
        }

        private void buttonProcessImage_Click_1(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Будь ласка, завантажте зображення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створити копію оригінального зображення для обробки
            processedImage = new Bitmap(originalImage);

            // Обробка зображення відповідно до вибраної опції пригнічення
            if (radioButtonRed.Checked)
                SuppressColorChannel(processedImage, ColorChannel.Red);
            else if (radioButtonGreen.Checked)
                SuppressColorChannel(processedImage, ColorChannel.Green);
            else if (radioButtonBlue.Checked)
                SuppressColorChannel(processedImage, ColorChannel.Blue);

            // Відобразити оброблене зображення у pictureBoxProcessed
            pictureBoxProcessed.Image   = processedImage;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Показати діалог збереження файлу
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Зберегти оброблене зображення у вибраному форматі
                processedImage.Save(saveFileDialog.FileName, ImageFormat.Bmp);
            }
        }
    }
}
