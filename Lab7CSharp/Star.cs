using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public class Star : Shape
    {
        private int size;

        public Star(int x, int y, int size): base(x, y)
        {
            this.size = size;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            // Координати для малювання зірки
            Point[] starPoints = CalculateStarPoints(x, y, size);

            // Малюємо зірку за допомогою ліній, які з'єднують точки
            g.DrawPolygon(pen, starPoints);
        }

        // Метод для розрахунку координат точок зірки
        private Point[] CalculateStarPoints(int x, int y, int size)
        {
            Point[] starPoints = new Point[10]; // Зірка складається з 10 точок

            double angle = Math.PI / 2; // Починаємо з верхньої точки (90 градусів)

            for (int i = 0; i < 10; i++)
            {
                double radius = i % 2 == 0 ? size * 0.5 : size; // Змінюємо радіус для кожної другої точки
                starPoints[i] = new Point((int)(x + radius * Math.Cos(angle)), (int)(y - radius * Math.Sin(angle)));
                angle += Math.PI / 5; // Переходимо до наступної точки на 36 градусів (2π / 10)
            }

            return starPoints;
        }
    }
}
