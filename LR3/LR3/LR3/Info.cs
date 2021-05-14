using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Info
    {
        private static void Id()
        {
            Console.WriteLine("Уникальный Id человека");
            int id;
            Random rand = new Random();
            id = rand.Next(100000, 999999);
            Console.WriteLine(id);
        }
        private static void Grade()
        {
            int sum = 0;
            int t = 0;
            int srednarifm;
            Console.WriteLine("Введите оценки учащегося по предмету  программирование: ");
            while (true)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                if (mark < 0 || mark > 10)
                {
                    Console.WriteLine("Оценки не существуют ");
                }
                if (mark >= 0 || mark < 11)
                {
                    sum += mark;
                    t++;
                }
                Console.WriteLine("Щелкните h, чтобы завершить ввод отметок ");
                if (Console.ReadLine() == "h")
                {
                    break;
                }
            }
            srednarifm = sum / t;
            Console.WriteLine("Средний балл студента  " + srednarifm);
        }
        public void Student()
        {
            Console.WriteLine("Выберите курс: ");
            string course = Console.ReadLine();
            switch (course)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Это не такой курс ");
                    break;
            }
            Grade();
            Id();
        }
    }
}
