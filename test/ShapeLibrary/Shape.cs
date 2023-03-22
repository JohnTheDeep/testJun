using System;
using System.Linq;

namespace ShapeLibrary
{
    public class Shape
    {
        public object[] Sides { get; set; }
        public Shape(params object[] sides)
        {
            Sides = sides;
        }
        public bool IsShapeRectangular() =>
            Sides.All(el => Convert.ToDouble(el) == Convert.ToDouble(Sides[0]));
        public object GetSquare()
        {
            if (Sides.Count() == 1)
                return (double)Math.Round(Math.PI, 2) * Math.Pow(Convert.ToDouble(Sides[0]), 2);
            else if (Sides.Count() == 3)
            {
                double
                a = Convert.ToDouble(Sides[0]),
                b = Convert.ToDouble(Sides[1]),
                c = Convert.ToDouble(Sides[2]);

                double half = (a + b + c) / 2;
                double square = half * (half - a) * (half - b) * (half - c);
                return Math.Round(Math.Sqrt(square), 4);
            }
            else
            {
                if (IsShapeRectangular())
                {
                    return Math.Round(Convert.ToDouble(Sides[0]) * Convert.ToDouble(Sides[1]), 4);
                }
                else
                    return default;
            }
        }
    }
}
