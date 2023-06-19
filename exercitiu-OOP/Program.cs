using exercitiu_OOP;
using exercitiu_OOP.elements;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Point F = new Point(-4, 3);
        Line AE = new Line(0, 1, -4, 1);
        Circle wheel = new Circle(new Point(-4, 3), new Line(-4, 3, 10, 3));
        Rectangle ABCD = new Rectangle(new Line(0, 1, 0, 5), new Line(0, 5, 4, 5), new Line(4, 1, 4, 5), new Line(0, 1, 4, 1));
        Etiquette tag = new Etiquette(new Rectangle(new Line(0, 0, 0, 3), new Line(0, 3, 5, 3), new Line(5, 0, 5, 3), new Line(0, 0, 5, 0)), "TEXT");

        List<Figure> figures = new List<Figure> { F, AE, wheel, ABCD, tag };

        Desen desen = new Desen(figures);
        desen.Menu();
    }
}