using System;

namespace zadanie3
{
    class Program
    {
        static void CircleInsideSquare(double a, double r)
        {
            if((0.5 * a) == r)
            {
                Console.WriteLine("it's possible to inscribe circle in square");
            }
            else
            {
                Console.WriteLine("it's not possible to inscribe circle in square");
            }
        }
        static void SquareInsideCircleField(double a)
        {
            double r = 0.5 * a;
            double field = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("A field of square is: " + field);
        }
        static void SquareOutsideCircleField(double side)
        {
            double diagonal = Math.Abs(Math.Pow(side, 2) + Math.Pow(side, 2));
            diagonal = Math.Sqrt(diagonal);
            Console.WriteLine("diagonal = " + diagonal);

            double R = 0.5 * diagonal;
            Console.WriteLine("R = " + R);

            double field = Math.PI * (Math.Pow(R, 2));
            Console.WriteLine("Field = " + field);
        }
        static void AbsoluteValue(double value)
        {
            if(value > 0)
            {
                Console.WriteLine("Absolute value of: " + value + " is " + value);
            }
            else if(value < 0)
            {
                Console.WriteLine("Absolute value of: " + value + " is " + -value);
            }
            else if(value == 0)
            {
                Console.WriteLine("Absolute value of: " + value + " is zero ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AbsoluteValue(10);
            AbsoluteValue(-4);
            AbsoluteValue(0);


            CircleInsideSquare(4, 2);
            CircleInsideSquare(5, 1);

            SquareInsideCircleField(10);

            SquareOutsideCircleField(100);
            Console.ReadLine();
        }
    }
}
