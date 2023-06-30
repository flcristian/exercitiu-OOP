using exercitiu_OOP;
using exercitiu_OOP.elements;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        IFigure F = new Point(-4, 3);
        IFigure AE = new Line(0, 1, -4, 1);
        IFigure wheel = new Circle(new Point(-4, 3), new Line(-4, 3, 10, 3));
        IFigure ABCD = new Rectangle(new Line(0, 1, 0, 5), new Line(0, 5, 4, 5), new Line(4, 1, 4, 5), new Line(0, 1, 4, 1));
        IFigure tag = new Etiquette(new Rectangle(new Line(0, 0, 0, 3), new Line(0, 3, 5, 3), new Line(5, 0, 5, 3), new Line(0, 0, 5, 0)), "TEXT");
        List<IFigure> figures = new List<IFigure> { F, AE, wheel, ABCD, tag };
        IFigure desen = new Desen(figures);

        IPanel panel = new Panel(desen);
        panel.Menu();
    }
}