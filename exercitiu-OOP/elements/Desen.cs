using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Desen : Figure
    {    
        private List<Figure> _figures;

        // Constructors

        public Desen()
        {
            _figures = new List<Figure>();
        }

        public Desen(List<Figure> figures)
        {
            _figures = figures;
        }

        // Methods

        public bool AddFigure(Figure figure)
        {
            foreach(Figure check in _figures)
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

            foreach(Figure figure in _figures)
            {
                Console.WriteLine(figure.ToString());
            }

            return desc;
        }

        public override void Afisare()
        {
            Console.WriteLine(this);
        }

        public override Desen Duplicare()
        {
            List<Figure> duped = new List<Figure>();
            
            foreach(Figure figure in _figures)
            {
                duped.Add(figure.Duplicare());
            }

            return new Desen(duped);
        }

        public override void Translate(int x, int y)
        {
            foreach (Figure figure in _figures)
            {
                figure.Translate(x, y);
            }
        }

        public override void TranslateOX(int x)
        {
            foreach (Figure figure in _figures)
            {
                figure.TranslateOX(x);
            }
        }

        public override void TranslateOY(int y)
        {
            foreach (Figure figure in _figures)
            {
                figure.TranslateOY(y);
            }
        }

        public void Menu()
        {
            bool running = true;
            while (running)
            {
                this.AfisareComenzi();
                string k = Console.ReadLine();

                switch (k)
                {
                    case "1":
                        this.Afisare();
                        break;
                    case "2":
                        this.TranslateOXMenu();
                        break;
                    case "3":
                        this.TranslateOYMenu();
                        break;
                    case "4":
                        this.TranslateMenu();
                        break;
                    default:
                        running = false;
                        break;
                }
            }
        }

        public void AfisareComenzi()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Introduceti :");
            Console.WriteLine("1 - Afiseaza desenul");
            Console.WriteLine("2 - Translateaza desenul pe axa OX");
            Console.WriteLine("3 - Translateaza desenul pe axa OY");
            Console.WriteLine("4 - Translateaza desenul pe ambele axe");
            Console.WriteLine();
        }

        public void TranslateMenu()
        {
            Console.WriteLine("Introdu cu cat doresti sa translatezi pe axa OX :");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introdu cu cat doresti sa translatezi pe axa OY :");
            int y = Int32.Parse(Console.ReadLine());

            this.Translate(x, y);
            Console.WriteLine("Desenul a fost translatat cu succes.");
        }

        public void TranslateOXMenu()
        {
            Console.WriteLine("Introdu cu cat doresti sa translatezi pe axa OX :");
            int x = Int32.Parse(Console.ReadLine());

            this.TranslateOX(x);
            Console.WriteLine("Desenul a fost translatat cu succes.");
        }

        public void TranslateOYMenu()
        {
            Console.WriteLine("Introdu cu cat doresti sa translatezi pe axa OY :");
            int y = Int32.Parse(Console.ReadLine());

            this.TranslateOY(y);
            Console.WriteLine("Desenul a fost translatat cu succes.");
        }

        public int FigureCount()
        {
            return _figures.Count();
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
