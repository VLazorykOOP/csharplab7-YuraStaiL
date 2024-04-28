using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public abstract class Shape
    {
        protected int x;
        protected int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw(Graphics g, Pen pen);
        public virtual void Move(int deltaX, int deltaY)
        {
            x += deltaX;
            y += deltaY;
        }
    }
}
