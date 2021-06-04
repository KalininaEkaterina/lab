using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите два числа: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            RationalNumber example1 = new RationalNumber(n1, m1);
            RationalNumber example2 = new RationalNumber(n2, m2);
            Console.WriteLine("Математические операции");
            Console.WriteLine(n1 + "/" + m1 + " + " + n2 + "/" + m2 + " = " + (double)(example1 + example2));
            Console.WriteLine(n1 + "/" + m1 + " - " + n2 + "/" + m2 + " = " + (double)(example1 - example2));
            Console.WriteLine(n1 + "/" + m1 + " / " + n2 + "/" + m2 + " = " + (double)(example1 / example2));
            Console.WriteLine(n1 + "/" + m1 + " * " + n2 + "/" + m2 + " = " + (double)(example1 * example2));
            Console.WriteLine("Операции сравнения");
            Console.WriteLine(">");
            if (example1 > example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");
            Console.WriteLine($"{(double)example2}");
            Console.WriteLine("<");
            if (example1 < example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");

            Console.WriteLine(">= ");
            if (example1 >= example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");
            Console.WriteLine("<=");
            if (example1 <= example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");
            Console.WriteLine("==");

            if (example1 == example2)
                Console.WriteLine("Числа равны.");
            else
                Console.WriteLine("Числа не равны");

            Console.WriteLine("Перевести в string");
            Console.WriteLine(example1.ToString());
            Console.WriteLine(example2.ToString());
            Console.WriteLine("Перевести в  int");
            Console.WriteLine(example1.ToString());
            Console.WriteLine(example2.ToString());
        }
    }
}