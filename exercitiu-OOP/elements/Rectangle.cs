using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Rectangle : Figure
    {
        private Line _top;
        private Line _right;
        private Line _bottom;
        private Line _left;

        // Constructors

        public Rectangle(Line top, Line right, Line bottom, Line left)
        {
            _top = top;
            _right = right;
            _bottom = bottom;
            _left = left;
        }

        // Accessors

        public Line Top
        {
            get { return _top; }
            set
            {
                _top = value;
            }
        }

        public Line Right
        {
            get { return _right; }
            set
            {
                _right = value;
            }
        }

        public Line Bottom
        {
            get { return _bottom; }
            set
            {
                _bottom = value;
            }
        }

        public Line Left
        {
            get { return _left; }
            set
            {
                _left = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "";
            desc = $"RECTANGLE:\nTop :\n{_top}Right :\n{_right}Bottom :\n{_bottom}Left :\n{_left}";

            return desc;
        }

        public override void Translate(int x, int y)
        {
            _top.Translate(x, y);
            _right.Translate(x, y);
            _bottom.Translate(x, y);
            _left.Translate(x, y);
        }

        public override void TranslateOX(int x)
        {
            _top.TranslateOX(x);
            _right.TranslateOX(x);
            _bottom.TranslateOX(x);
            _left.TranslateOX(x);
        }

        public override void TranslateOY(int y)
        {
            _top.TranslateOY(y);
            _right.TranslateOY(y);
            _bottom.TranslateOY(y);
            _left.TranslateOY(y);
        }

        public override void Afisare()
        {
            Console.WriteLine(this);
        }

        public override Rectangle Duplicare()
        {
            return new Rectangle(this.Top, this.Right, this.Bottom, this.Left);
        }

        public override bool Equals(object? obj)
        {
            return (obj as Rectangle).Top.Equals(_top) && (obj as Rectangle).Right.Equals(_right) && (obj as Rectangle).Bottom.Equals(_bottom) && (obj as Rectangle).Left.Equals(_left);
        }
    }
}
