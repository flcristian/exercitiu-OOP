using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitiu_OOP.elements
{
    public class Circle : IFigure
    {
        private Point _center;
        private Line _radius;
        
        // Constructors

        public Circle(Point center, Line radius)
        {
            _center = center;
            _radius = radius;
        }

        // Accessors

        public Point Center
        {
            get { return _center; }
            set
            {
                _center = value;
            }
        }

        public Line Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = $"CIRCLE:\nCenter: {_center}";
            desc += $"Radius:\n{_radius}";

            return desc;
        }

        public void Translate(int x, int y)
        {
            _center.Translate(x, y);
            _radius.Translate(x, y);
        }

        public void TranslateOX(int x)
        {
            _center.TranslateOX(x);
            _radius.TranslateOX(x);
        }

        public void TranslateOY(int y)
        {
            _center.TranslateOY(y);
            _radius.TranslateOY(y);
        }

        public void Afisare()
        {
            string desc = $"CIRCLE:\nCenter: {_center}";
            desc += $"Radius:\n{_radius}";
            Console.WriteLine(desc);
        }

        public IFigure Duplicare()
        {
            return new Circle(this.Center, this.Radius);
        }

        public override bool Equals(object? obj)
        {
            return (obj as Circle).Center.Equals(_center) && (obj as Circle).Radius.Equals(_radius);
        }
    }
}
