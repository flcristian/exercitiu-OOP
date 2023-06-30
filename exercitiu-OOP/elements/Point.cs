using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Point : IFigure
    {
        private int _x;
        private int _y;

        // Constructors

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Accessors

        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = $"POINT:\nx={_x}, y={_y}\n";

            return desc;
        }

        public void Translate(int x, int y)
        {
            _x = _x + x;
            _y = _y + y;
        }

        public void TranslateOX(int x)
        {
            _x = _x + x;
        }
        
        public void TranslateOY(int y)
        {
            _y = _y + y;
        }

        public void Afisare()
        {
            string desc = $"POINT:\nx={_x}, y={_y}\n";
            Console.WriteLine(desc);
        }

        public IFigure Duplicare()
        {
            return new Point(this.X, this.Y);
        }

        public override bool Equals(object? obj)
        {
            return ((obj as Point).X == _x) && ((obj as Point).Y == _y);
        }
    }
}
