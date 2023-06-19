using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Figure
    {
        // Methods

        public virtual void Translate(int x, int y) 
        {
            Console.WriteLine("Translatare din figura.");
        }

        public virtual void TranslateOX(int x)
        {
            Console.WriteLine("Translatare pe OX din figura.");
        }

        public virtual void TranslateOY(int y)
        {
            Console.WriteLine("Translatare pe OY din figura.");
        }

        public virtual void Afisare()
        {
            Console.WriteLine(this);
        }

        public virtual Figure Duplicare()
        {
            Console.WriteLine("Duplicare din figura.");
            return null;
        }

        public override string ToString()
        {
            return "";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
