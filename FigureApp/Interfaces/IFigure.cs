using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp.Interfaces
{
    public interface IFigure
    {
        double Area();         // Метод для обчислення площі
        double Perimeter();    // Метод для обчислення периметру
    }

    public interface IFigures
    {
        List<IFigure> Figures { get; set; } // Властивість для доступу до списку фігур

        void AddFigure(IFigure figure);        // Метод для додавання фігури
        void PopFigure();                      // Метод для видалення останньої фігури
        void DeleteFigure(IFigure figure);    // Метод для видалення конкретної фігури
        void DeleteFigureAt(int index);        // Метод для видалення фігури за індексом
        int FiguresCount();                    // Метод для отримання кількості фігур
    }

}
