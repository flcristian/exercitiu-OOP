using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public interface IFigure
    {
        // Methods

        void Translate(int x, int y);

        void TranslateOX(int x);

        void TranslateOY(int y);

        void Afisare();

        IFigure Duplicare();
    }
}
