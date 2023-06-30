using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Etiquette : Rectangle
    {
        private string _text;

        // Constructors

        public Etiquette(Line top, Line right, Line bottom, Line left, string text) : base(top, right, bottom, left)
        {
            _text = text;
        }

        public Etiquette(Rectangle box, string text) : base(box.Top, box.Right, box.Bottom, box.Left)
        {
            _text = text;
        }

        // Accessors

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "ETIQUETTE:\n" + base.ToString();
            desc += $"Text : {_text}";

            return desc;
        }

        public void Translate(int x, int y)
        {
            base.Translate(x, y);
        }

        public void TranslateOX(int x)
        {
            base.TranslateOX(x);
        }

        public void TranslateOY(int y)
        {
            base.TranslateOY(y);
        }

        public void Afisare()
        {
            string desc = "ETIQUETTE:\n" + base.ToString();
            desc += $"Text : {_text}";
            Console.WriteLine(desc);
        }

        public IFigure Duplicare()
        {
            return new Etiquette(base.Top, base.Right, base.Bottom, base.Left, this.Text);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj) && (obj as Etiquette).Text.Equals(_text);          
        }
    }
}
