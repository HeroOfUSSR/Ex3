using Ex3;

namespace Ex3_Test
{
    public class GeometryTest
    {
        [Fact]
        public void Multiply()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Volume()
        {
            int r = 5;
            int h = 12;
            int expected = 942;

            Geometry g = new Geometry();
            double actual = g.Cylinder(r, h);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sqrt()
        {
            int a = 36;
            int expected = 6;

            Geometry g = new Geometry();
            double actual = g.Root(a);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eq()
        {
            double a = 4;
            double b = -16;
            double c = 10;
            var expected = new List<double> {0.775, 3.225 };

            Geometry g = new Geometry();
            List<double> actual = g.Equation(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}