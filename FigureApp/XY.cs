using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureApp.Interfaces;

namespace FigureLibrary
{
    public class XY : IXY
    {
        public double x { get; set; }
        public double y { get; set; }

        public XY() { x = 0; y = 0; }
        public XY(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static double operator ^(XY left, XY right)
        {
            return Math.Sqrt((Math.Pow(left.x - right.x, 2) + Math.Pow(left.y - right.y, 2)));
        }



        public override string ToString()
        {
            return $"[{x};{y}]";
        }
    }
}
