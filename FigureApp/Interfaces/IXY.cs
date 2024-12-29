using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp.Interfaces
{
    public interface IXY
    {
        double x { get; set; } // Властивість для координати X
        double y { get; set; } // Властивість для координати Y

        string ToString(); // Метод для виведення у форматі рядка
    }

}
