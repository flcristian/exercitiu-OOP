using exercitiu_OOP.elements;
using Xunit.Sdk;

namespace testing_exercitiu_OOP
{
    public class TestDesen
    {
        [Fact]
        public void Equals_NotEqual_ReturnsFalse()
        {
            // Arrange
            Rectangle box1 = new Rectangle(new Line(0, 0, 1, 1), new Line(1, 1, 2, 1), new Line(2, 0, 2, 1), new Line(0, 0, 2, 0));
            Rectangle box2 = new Rectangle(new Line(0, 0, 1, 1), new Line(1, 1, 100, 1), new Line(100, 0, 100, 1), new Line(0, 0, 100, 1));
            Etiquette etiquette1 = new Etiquette(box1, "TEXT1");
            Etiquette etiquette2 = new Etiquette(box1, "TEXT2");
            Etiquette etiquette3 = new Etiquette(box1, "TEXT");
            List<IFigure> figures = new List<IFigure> { etiquette1, etiquette2, etiquette3 };
            List<IFigure> check = new List<IFigure> { etiquette2, etiquette3, box1 };
            Desen desen = new Desen(figures);
            Desen checkDesen = new Desen(check);

            // Assert
            Assert.NotEqual(checkDesen, desen);
        }

        [Fact]
        public void Equals_Equal_ReturnsTrue()
        {
            // Arrange
            Rectangle box = new Rectangle(new Line(0, 0, 1, 1), new Line(1, 1, 2, 1), new Line(2, 0, 2, 1), new Line(0, 0, 2, 0));
            Etiquette etiquette1 = new Etiquette(box, "TEXT");
            Etiquette etiquette2 = new Etiquette(box, "TEXT");
            List<IFigure> figures = new List<IFigure> { etiquette1, etiquette2 };
            List<IFigure> check = new List<IFigure> { etiquette1, etiquette2 };
            Desen desen = new Desen(figures);
            Desen checkDesen = new Desen(check);

            // Assert
            Assert.Equal(checkDesen, desen);
        }

        [Fact]
        public void AddIFigure_NoMatch_AddsIFigure_ReturnsTrue()
        {
            // Arrange
            Point toAdd = new Point(0, 0);
            List<IFigure> list = new List<IFigure>();
            Desen desen = new Desen(list);

            // Act
            bool add = desen.AddIFigure(toAdd);

            // Assert
            Assert.True(add);
            Assert.Equal(1, desen.IFigureCount());
        }

        [Fact]
        public void AddIFigure_ValidMatch_DoesNotAddIFigure_ReturnsFalse()
        {
            // Arrange
            Point toAdd = new Point(0, 0);
            List<IFigure> list = new List<IFigure> { toAdd.Duplicare() };
            Desen desen = new Desen(list);

            // Act
            bool add = desen.AddIFigure(toAdd);

            // Assert
            Assert.False(add);
            Assert.Equal(1, desen.IFigureCount());
        }

        [Fact]
        public void Duplicare_ReturnsSameDrawing()
        {
            // Arrange
            List<IFigure> list = new List<IFigure> { new Point(0, 0), new Point(1, 2), new Point(3, 4) };
            Desen desen = new Desen(list);

            // Assert
            Desen duped = desen.Duplicare();
            Assert.Equal(desen, duped);
        }

        [Fact]
        public void Translate_MakesCorrectChanges()
        {
            // Arrange
            List<IFigure> list = new List<IFigure> { new Point(0, 0), new Point(1, 2), new Point(3, 4) };
            List<IFigure> check = new List<IFigure> { new Point(1, 2), new Point(2, 4), new Point(4, 6) };
            Desen desen = new Desen(list);
            Desen checkDesen = new Desen(check);

            // Act
            desen.Translate(1, 2);

            // Arrange
            Assert.Equal(checkDesen, desen);
        }

        [Fact]
        public void TranslateOX_MakesCorrectChanges()
        {
            // Arrange
            List<IFigure> list = new List<IFigure> { new Point(0, 0), new Point(1, 2), new Point(3, 4) };
            List<IFigure> check = new List<IFigure> { new Point(1, 0), new Point(2, 2), new Point(4, 4) };
            Desen desen = new Desen(list);
            Desen checkDesen = new Desen(check);

            // Act
            desen.TranslateOX(1);

            // Arrange
            Assert.Equal(checkDesen, desen);
        }

        [Fact]
        public void TranslateOY_MakesCorrectChanges()
        {
            // Arrange
            List<IFigure> list = new List<IFigure> { new Point(0, 0), new Point(1, 2), new Point(3, 4) };
            List<IFigure> check = new List<IFigure> { new Point(0, 2), new Point(1, 4), new Point(3, 6) };
            Desen desen = new Desen(list);
            Desen checkDesen = new Desen(check);

            // Act
            desen.TranslateOY(2);

            // Arrange
            Assert.Equal(checkDesen, desen);
        }
    }
}