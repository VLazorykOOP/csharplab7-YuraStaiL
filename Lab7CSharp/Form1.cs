using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримати поточний час
            DateTime currentTime = DateTime.Now;

            // Отримати текст з TextBox
            string sentence = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(sentence))
            {
                // Створити рядок з текстом та часом
                string sentenceWithTime = $"{currentTime} - {sentence}";

                // Додати рядок з текстом та часом до RichTextBox
                richTextBox1.AppendText(sentenceWithTime + Environment.NewLine);

                // Очистити TextBox після додавання речення
                //richTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть речення у TextBox.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
