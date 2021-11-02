using System;


namespace zadanie6
{
    class Program
    {
        static void forNotEven(int a)
        {
            Console.WriteLine();
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0) continue;
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void forEven(int a)
        {
            Console.WriteLine();
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 != 0) continue;
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void method1(bool[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 0)
                {
                    tab[i] = true;
                }
                else if(i % 2 != 0)
                {
                    tab[i] = false;
                }
            }

            for(int j = 0; j < tab.Length; j++)
            {
                Console.WriteLine(tab[j]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            forNotEven(20);
            forEven(20);

            Console.WriteLine();

            int[] tab1 = new int[10];
            for(int i = 1; i < tab1.Length; i++)
            {
                tab1[i] = 100 + i;
                Console.WriteLine(tab1[i]);
            }

            Console.WriteLine();

            int[] tab2 = new int[10];
            for(int j = 1; j < tab2.Length; j++)
            {
                tab2[j] = j * 10;
                Console.WriteLine(tab2[j]);
            }

            Console.WriteLine();

            bool[] tabs = new bool[20];
            method1(tabs);
        }
    }
}
