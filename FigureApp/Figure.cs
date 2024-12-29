using System;
using System.Collections.Generic;
using System.Xml.Linq;
using FigureApp.Interfaces;

namespace FigureLibrary
{
    public abstract class Figure : IFigure
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

