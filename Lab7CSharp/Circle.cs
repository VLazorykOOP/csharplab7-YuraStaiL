using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, x - radius, y - radius, 2 * radius, 2 * radius);
        }
    }
}
