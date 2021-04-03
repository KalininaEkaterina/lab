using System;


namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значения: ");
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            string f = Console.ReadLine();
            int a = Convert.ToInt32(d);
            int b = Convert.ToInt32(e);
            int c = Convert.ToInt32(f);
            double p = (a + b + c) / 2;
            Console.WriteLine("Радиус вписанной окружности ");
            double r = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            Console.WriteLine("r=" + r);
            Console.WriteLine("Радиус oписанной окружности ");
            double R = (a * b * c) / (4 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine("R= " + R);
            Console.WriteLine("Площадь ");
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S=" + S);
            Console.WriteLine("Периметр ");
            double P = a + b + c;
            Console.WriteLine("P=" + P);
            Console.WriteLine("Высоты треугольника ");
            double h1 = 2 * S / a;
            double h2 = 2 * S / b;
            double h3 = 2 * S / c;
            Console.WriteLine("h1=" + h1);
            Console.WriteLine("h2=" + h2);
            Console.WriteLine("h3=" + h3);
            Console.ReadKey();
        }
    }
}