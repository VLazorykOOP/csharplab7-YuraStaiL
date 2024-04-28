using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public class FilledRectangle : Shape
    {
        private int width;
        private int height;

        public FilledRectangle(int x, int y, int width, int height): base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, new Rectangle(x, y, width, height));
            g.FillRectangle(new SolidBrush(pen.Color), new Rectangle(x, y, width, height));
        }
    }
}
