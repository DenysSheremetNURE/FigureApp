using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace FigureLibrary
{
    public class XY
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

    public abstract class Figure
    {
        public Figure() { }
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Figures
    {
        public List<Figure> figures { get; set; }

        public Figures()
        {
            figures = new List<Figure>();
        }
        public Figures(Figure[] args)
        {
            figures = new List<Figure>();
            foreach (Figure f in args)
            {
                figures.Add(f);
            }
        }

        public void AddFigure(Figure f)
        {
            if (figures == null)
                figures = new List<Figure>();
            figures.Add(f);
        }

        public void PopFigure()
        {
            if (figures != null)
            {
                if (figures.Count > 0)
                    figures.RemoveAt(figures.Count - 1);
            }
        }

        public void DeleteFigure(Figure name)
        {
            if (figures != null)
            {
                if (figures.Count > 0)
                    figures.Remove(name);
            }
        }

        public void DeleteFigureAt(int index)
        {
            if (figures != null)
            {
                if (figures.Count >= ++index)
                    figures.RemoveAt(index);
            }
        }

        public int FiguresCount()
        {
            if (figures != null)
                return figures.Count;
            return 0;
        }
    }
}

