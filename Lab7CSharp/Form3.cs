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
    public partial class Form3 : Form
    {
        private List<Shape> shapes  = new List<Shape>();
        private Random random       = new Random();
        private Pen pen;
        private Graphics graphics;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                pen = new Pen(Color.Red);
            } else if (radioButtonGreen.Checked)
            {
                pen = new Pen(Color.Green);
            } else if (radioButtonBlue.Checked)
            {
                pen = new Pen(Color.Blue);
            };

            int circleRadiusValue = Convert.ToInt32(circleRadius.Text);
            int sectorRadiusValue = Convert.ToInt32(sectorRadius.Text);
            int rectangleWidthValue = Convert.ToInt32(rectangleWidth.Text);
            int rectangleHeightValue = Convert.ToInt32(rectangleHeight.Text);
            int startAngle = Convert.ToInt32(sectorStartAngle.Text);
            int sweepAngle = Convert.ToInt32(sectorSweepAngle.Text);
            int starSizeValue = Convert.ToInt32(starSize.Text);

            int x = random.Next(pictureBoxCanvas.Width);
            int y = random.Next(pictureBoxCanvas.Height);
            shapes.Add(new Circle(x, y, circleRadiusValue));

            x = random.Next(pictureBoxCanvas.Width);
            y = random.Next(pictureBoxCanvas.Height);
            shapes.Add(new FilledRectangle(x, y, rectangleWidthValue, rectangleHeightValue));

            x = random.Next(pictureBoxCanvas.Width);
            y = random.Next(pictureBoxCanvas.Height);
            shapes.Add(new Sector(x, y, sectorRadiusValue, startAngle, sweepAngle));

            x = random.Next(pictureBoxCanvas.Width);
            y = random.Next(pictureBoxCanvas.Height);
            shapes.Add(new Star(x, y, starSizeValue));
            if (graphics == null)
            {
                graphics = pictureBoxCanvas.CreateGraphics();
            }
            printShapes(graphics);
            shapes.Clear();
        }

        private void printShapes(Graphics graphics)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics, pen);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (graphics != null)
            {
                graphics.Clear(Color.White);
            }

            if (shapes.Count > 0)
            {
                shapes.Clear();
            }
        }
    }
}
