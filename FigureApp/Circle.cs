using FigureApp.Interfaces;
using FigureLibrary;
using System;

namespace FigureLibrary
{
    public class Circle : Figure, ICircle
    {
        public XY center { get; set; }
        public double radius { get; set; }

        public Circle() { center = new XY(); radius = 0; }

        public Circle(double centerX, double centerY, double radius)
        {
            center = new XY();
            center.x = centerX;
            center.y = centerY;
            this.radius = radius;
        }

        public Circle(XY center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Circle(double radius)
        {
            center = new XY();
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * (radius * radius), 2);
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }
    }
}

