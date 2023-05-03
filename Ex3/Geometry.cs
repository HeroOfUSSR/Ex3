using System.Collections.Generic;

namespace Ex3
{
    public class Geometry
    {
        public int RectangleArea(int a,int b)
        { 
            return a * b; 
        }

        public double Cylinder(int r, int h)
        {
            var result = Math.Round(3.14 * r * r * h);
            return result;
        }

        public double Root(int a)
        {
            var result = Math.Sqrt(a);
            return result;
          
        }

        public List<double> Equation(double a, double b, double c)
        {
            double x1, x2;
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                throw new Exception("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x2 = -b / (2 * a);
                    x1 = Math.Round(x2, 3);
                    var result = new List<double> { x2 };
                    return result;
                }
                else //уравнение имеет два разных корня
                {
                    x2 = Math.Round((-b + Math.Sqrt(discriminant)) / (2 * a), 3);
                    x1 = Math.Round((-b - Math.Sqrt(discriminant)) / (2 * a), 3);
                    var result = new List<double> { x1, x2 };
                    return result;
                }

            }
        }

        public void Gym()
        {
                var a = 147;
                double c = 0;

                for (int i = 0; i < 100; i++)
                {
                    if (c < a)
                    {
                        Console.WriteLine(Math.Pow(i, 2));
                        c = c + Math.Pow(i, 2);
                    }
                    else
                    {
                        break;
                    }

                }
                Console.WriteLine(c);
        }


    }
}