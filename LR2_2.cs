using System;

namespace LR2
{
    class Program
    {

        static void Main(string[] args)
        {
            String s;
            Console.WriteLine("Введите строку :");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                if (char.IsUpper(c) && (c > 90))
                {
                    Console.WriteLine(c);
                }
            }
            Console.ReadKey();
        }
    }
}
