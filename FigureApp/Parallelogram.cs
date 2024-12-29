using FigureApp.Interfaces;
using FigureLibrary;
using System;

namespace FigureLibrary
{
    public class Parallelogram : Figure, IParallelogram
    {
        //going  from the left bottom point counterclockwise
        public XY point1 { get; private set; }
        public XY point2 { get; private set; }
        public XY point3 { get; private set; }
        public XY point4 { get; private set; }
        //side1 is horizontal, side2 is vertical
        public double side1 { get; private set; }
        public double side2 { get; private set; }

        public Parallelogram()
        {
            point1 = new XY();
            point2 = new XY();
            point3 = new XY();
            point4 = new XY();

            side1 = 0;
            side2 = 0;
        }

        //constructor using 4 points (for accurate modeling)
        public Parallelogram(XY left_bottom, XY right_bottom, XY right_top, XY left_top)
        {
            double sideA = left_bottom ^ right_bottom;
            double sideB = right_top ^ left_top;
            double sideC = left_bottom ^ left_top;
            double sideD = right_bottom ^ right_top;
            if (sideA != sideB || sideC != sideD)
            {
                throw new Exception("Incorrect parallelogram points");
            }
            point1 = left_bottom;
            point2 = right_bottom;
            point3 = right_top;
            point4 = left_top;
            side1 = sideA;
            side2 = sideC;
        }

        //automatically set 4th point
        public Parallelogram(XY left_bottom, XY right_bottom, XY right_top)
        {
            point1 = left_bottom;
            point2 = right_bottom;
            point3 = right_top;
            point4 = new XY((point1.x + point3.x - point2.x), (point1.y + point3.y - point2.y));
            side1 = point1 ^ point2;
            side2 = point1 ^ point4;
        }

        //standard rectangle
        public Parallelogram(XY start, double side1, double side2)
        {
            point1 = start;
            this.side1 = side1;
            this.side2 = side2;
            point2 = new XY(point1.x + side1, point1.y);
            point3 = new XY(point1.x + side1, point1.y + side2);
            point4 = new XY(point1.x, point1.y + side2);
        }

        //standard square
        public Parallelogram(XY start, double side)
        {
            point1 = start;
            side1 = side;
            side2 = side;
            point2 = new XY(point1.x + side, point1.y);
            point3 = new XY(point1.x + side, point1.y + side);
            point4 = new XY(point1.x, point1.y + side);
        }

        public override double Area()
        {
            double cos = (side1 * side1 + side2 * side2 - Math.Pow((point1 ^ point3), 2)) / (2 * side1 * side2);
            return Math.Round(cos * side1 * side2);
        }

        public override double Perimeter()
        {
            return Math.Round(side1 * 2 + side2 * 2, 2);
        }
    }
}
