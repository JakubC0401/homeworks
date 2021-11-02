using System;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LiczbaCalkowita l1 = new LiczbaCalkowita();
            l1.wartosc = 10;
            l1.WyswietlLiczbe();
            l1.PobierzLiczbe();

            Prostokat p1 = new Prostokat(2, 3, 4, 5);
            p1.WyswietlRogi();
        }
    }
    class LiczbaCalkowita
    {
        public int wartosc;

        public void WyswietlLiczbe()
        {
            Console.WriteLine(wartosc);
        }
        public int PobierzLiczbe()
        {
            return wartosc;
        }
    }
    class Prostokat
    {
        int a;
        int b;
        int c;
        int d;

        public Prostokat(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public void WyswietlRogi()
        {
            Console.WriteLine("a: " + a + " b: " + b + " c: " + c + " d: " + d);
        }
    }
}
