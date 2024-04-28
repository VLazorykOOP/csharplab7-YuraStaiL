using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public class Sector : Shape
    {
        private int radius;
        private int startAngle;
        private int sweepAngle;

        public Sector(int x, int y, int radius, int startAngle, int sweepAngle) : base(x, y)
        {
            this.radius = radius;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawPie(pen, x - radius, y - radius, 2 * radius, 2 * radius, startAngle, sweepAngle);
        }
    }
}
