using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp.Interfaces
{
    public interface IMyRectangle : IFigure
    {
        XY point1 { get; }    // Ліва нижня точка
        XY point2 { get; }    // Права нижня точка
        XY point3 { get; }    // Права верхня точка
        XY point4 { get; }    // Ліва верхня точка
        double side1 { get; } // Горизонтальна сторона
        double side2 { get; } // Вертикальна сторона
    }

}
