using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp.Interfaces
{
    public interface ICircle : IFigure
    {
        XY center { get; set; }     // Властивість для центру кола
        double radius { get; set; } // Властивість для радіуса кола
    }

}
