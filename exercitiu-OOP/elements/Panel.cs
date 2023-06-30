using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Panel : IPanel
    {
        private IFigure _desen;

        // Constructors

        public Panel()
        {
            _desen = new Desen();
        }

        public Panel(IFigure desen)
        {
            _desen = desen;
        }

        // Methods

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
                        _desen.Afisare();
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

            _desen.Translate(x, y);
            Console.WriteLine("Desenul a fost translatat cu succes.");
        }

        public void TranslateOXMenu()
        {
            Console.WriteLine("Introdu cu cat doresti sa translatezi pe axa OX :");
            int x = Int32.Parse(Console.ReadLine());

            _desen.TranslateOX(x);
            Console.WriteLine("Desenul a fost translatat cu succes.");
        }

        public void TranslateOYMenu()
        {
            Console.WriteLine("Introdu cu cat doresti sa translatezi pe axa OY :");
            int y = Int32.Parse(Console.ReadLine());

            _desen.TranslateOY(y);
            Console.WriteLine("Desenul a fost translatat cu succes.");
        }
    }
}
