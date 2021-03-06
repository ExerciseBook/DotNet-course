using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(Point p1, Point p2)
        {
            if (Math.Abs(p1.x - p2.x) < 1e-9 || Math.Abs(p1.y - p2.y) < 1e-9) throw new InvalidShape();

            Points.Add(new Point(p1));
            Points.Add(new Point(p2));
        }

        public override double Aera()
        {
            var p1 = Points[0];
            var p2 = Points[1];

            var l1 = Math.Abs(p1.x - p2.x);
            var l2 = Math.Abs(p1.y - p2.y);

            return l1 * l2;
        }
    }
}