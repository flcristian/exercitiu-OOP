using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Line : Figure
    {
        private Point _P1;
        private Point _P2;

        // Constructors

        public Line(Point P1, Point P2)
        {
            _P1 = P1;
            _P2 = P2;
        }

        public Line(int xP1, int yP1, int xP2, int yP2)
        {
            _P1 = new Point(xP1, yP1);
            _P2 = new Point(xP2, yP2);
        }

        // Accessors

        public Point P1
        {
            get { return _P1; }
            set
            {
                _P1 = value;
            }
        }

        public Point P2
        {
            get { return _P2; }
            set
            {
                _P2 = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "LINE:\n";

            desc += $"P1: {_P1}";
            desc += $"P2: {_P2}";

            return desc;
        }

        public override void Translate(int x, int y)
        {
            _P1.Translate(x, y);
            _P2.Translate(x, y);
        }

        public override void TranslateOX(int x)
        {
            _P1.TranslateOX(x);
            _P2.TranslateOX(x);
        }

        public override void TranslateOY(int y)
        {
            _P1.TranslateOY(y);
            _P2.TranslateOY(y);
        }

        public override void Afisare()
        {
            Console.WriteLine(this);
        }

        public override Line Duplicare()
        {
            return new Line(this.P1, this.P2);
        }

        public override bool Equals(object? obj)
        {
            return (obj as Line).P1.Equals(_P1) && (obj as Line).P2.Equals(_P2);
        }
    }
}
