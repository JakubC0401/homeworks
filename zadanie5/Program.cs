using System;

namespace zadanie5
{
   
    class Program
    {
        public static void EvenFor(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " -Even");
                }
                else
                {
                    Console.WriteLine(i + " -Not even");
                }
            }
        }
        static void EvenWhile(int a)
        {
            int i = 0;

            while (i++ < a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " -Even");
                }
                else
                {
                    Console.WriteLine(i + " -Not even");
                }
            }
        }
        static void EvenDoWhile(int a)
        {
            int i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " -Even");
                }
                else
                {
                    Console.WriteLine(i + " -Not even");
                }
            } while (i++ < a);
        }
        static void Main(string[] args)
        {
            EvenFor(20);
            Console.WriteLine("---------------------------------------------");

            EvenWhile(10);
            Console.WriteLine("---------------------------------------------");

            EvenDoWhile(6);
            Console.WriteLine("---------------------------------------------");


            double a = 1;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(a/2);
                a += 1;
                
            }
            Console.WriteLine("---------------------------------------------");
            int j = 1;
            double x = 1;
            while (j++ <= 20)
            {
                Console.WriteLine(x/3);
                x += 1;
            }
        }
    }
}
