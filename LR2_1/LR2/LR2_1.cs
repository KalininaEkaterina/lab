using System;


namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ;
            Console.WriteLine("Введите строку ");
            str = Console.ReadLine();
            string[] words = str.Split(' ');
            Console.WriteLine("В обратном порядке:");            
            for (int i= words.Length-1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadKey();
        }        
    }
}
