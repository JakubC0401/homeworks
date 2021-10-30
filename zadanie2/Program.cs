using System;

namespace zadanie2
{
    class Program
    {
        static void QuadricEquation(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine(delta);

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Solution is " + x1 + " and " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("Solution is" + x);
            }
            else
            {
                Console.WriteLine("There is no solution");
            }

            
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            if(a % b == 0)
            {
                Console.WriteLine("it's zero");
            }
            else
            {
                Console.WriteLine("it's not zero");
            }
            Console.ReadKey();

            QuadricEquation(1, 2, -3);
            QuadricEquation(4, 2, 5);
            QuadricEquation(2, 3, -2);
        }
    }
}
