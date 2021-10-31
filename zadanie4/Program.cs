using System;

namespace zadanie4
{
    
    class Program
    {
        static bool isZeroModulo(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else if(a % b != 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        static void DecimalChecker(double value)
        {
            switch (value)
            {
                case 1:
                    Console.WriteLine("value = " + value);
                    break;
                case 2:
                    Console.WriteLine("value = " + value);
                    break;
                default:
                    Console.WriteLine("value is not 1 and it's not 2");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DecimalChecker(1);
            DecimalChecker(2);
            DecimalChecker(3);

            int value = 10;
            int value2;

            value2 = value < 0 ? -1 : 1;
            Console.WriteLine(value2);

            isZeroModulo(10, 2);
            isZeroModulo(5, 2);

            int number;
            Console.WriteLine("Give a number from 1 to 10:");
            number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine("it's 1");
                    break;
                case 2:
                    Console.WriteLine("it's 2");
                    break;
                case 3:
                    Console.WriteLine("it's 3");
                    break;
                case 4:
                    Console.WriteLine("it's 4");
                    break;
                case 5:
                    Console.WriteLine("it's 5");
                    break;
                case 6:
                    Console.WriteLine("it's 6");
                    break;
                case 7:
                    Console.WriteLine("it's 7");
                    break;
                case 8:
                    Console.WriteLine("it's 8");
                    break;
                case 9:
                    Console.WriteLine("it's 9");
                    break;
                case 10:
                    Console.WriteLine("it's 10");
                    break;
                default:
                    Console.WriteLine("Value is not between 1 and 10");
                    break;
            }
        }
    }
}
