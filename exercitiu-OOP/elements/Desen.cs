using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Desen : IFigure
    {    
        private List<IFigure> _figures;

        // Constructors

        public Desen()
        {
            _figures = new List<IFigure>();
        }

        public Desen(List<IFigure> figures)
        {
            _figures = figures;
        }

        // Methods

        public bool AddIFigure(IFigure figure)
        {
            foreach(IFigure check in _figures)
            {
                if (figure.Equals(check))
                {
                    return false;
                }
            }

            _figures.Add(figure);
            return true;
        }

        public override string ToString()
        {
            string desc = "";

            foreach(IFigure figure in _figures)
            {
                Console.WriteLine(figure.ToString());
            }

            return desc;
        }

        public void Afisare()
        {
            foreach (IFigure figure in _figures)
            {
                figure.Afisare();
            }
        }

        public IFigure Duplicare()
        {
            List<IFigure> duped = new List<IFigure>();
            
            foreach(IFigure figure in _figures)
            {
                duped.Add(figure.Duplicare());
            }

            return new Desen(duped);
        }

        public void Translate(int x, int y)
        {
            foreach (IFigure figure in _figures)
            {
                figure.Translate(x, y);
            }
        }

        public void TranslateOX(int x)
        {
            foreach (IFigure figure in _figures)
            {
                figure.TranslateOX(x);
            }
        }

        public void TranslateOY(int y)
        {
            foreach (IFigure figure in _figures)
            {
                figure.TranslateOY(y);
            }
        }

        public override bool Equals(object? obj)
        {
            Desen check = obj as Desen;
            for(int i = 0; i < _figures.Count(); i++)
            {
                if (!_figures[i].Equals(check._figures[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
