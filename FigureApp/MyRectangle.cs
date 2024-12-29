using FigureApp.Interfaces;
using FigureLibrary;
using System;

namespace FigureLibrary
{
    public class MyRectangle : Figure, IMyRectangle
    {
        //going  from the left bottom point counterclockwise
        public XY point1 { get; private set; }
        public XY point2 { get; private set; }
        public XY point3 { get; private set; }
        public XY point4 { get; private set; }
        //side1 is horizontal, side2 is vertical
        public double side1 { get; private set; }
        public double side2 { get; private set; }

        public MyRectangle()
        {
            point1 = new XY();
            point2 = new XY();
            point3 = new XY();
            point4 = new XY();

            side1 = 0;
            side2 = 0;
        }

        //standard square
        public MyRectangle(XY start, double side)
        {
            point1 = start;
            side1 = side;
            side2 = side;
            point2 = new XY(point1.x + side, point1.y);
            point3 = new XY(point1.x + side, point1.y + side);
            point4 = new XY(point1.x, point1.y + side);
        }

        //standard rectangle
        public MyRectangle(XY start, double side1, double side2)
        {
            point1 = start;
            this.side1 = side1;
            this.side2 = side2;
            point2 = new XY(point1.x + side1, point1.y);
            point3 = new XY(point1.x + side1, point1.y + side2);
            point4 = new XY(point1.x, point1.y + side2);
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return Math.Round(side1 * 2 + side2 * 2, 2);
        }
    }
}

