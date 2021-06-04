using System;
namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sw = 0;
            while (sw != 5)
            {
                Console.WriteLine("1 - Программист\n2 - Экономист\n3 - Учитель\n4 - Доктор\n5 - Выход");
                try
                {
                    sw = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                }
                switch (sw)
                {
                    case 1:
                        Programmer programmer = new Programmer("БГУИР", "КСИС", "Минск",  "Екатерина", "Калинина", 17);
                        Console.WriteLine(programmer);
                        break;
                    case 2:
                        Economist economist = new Economist("БГУ", "Экономист", "Минск", "Ульяна", "Синявская", 18);
                        Console.WriteLine(economist);
                        break;
                    case 3:
                        Teacher teacher = new Teacher("БГПУ", "Филологический", "Минск", "Вероника", "Якимович", 18);
                        Console.WriteLine(teacher);
                        break;
                    case 4:
                        Doctor doctor = new Doctor("БГМУ", "Педиатр", "Минск", "Наташа", "Павловская", 18);
                        Console.WriteLine(doctor);
                        break;
                    case 5:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
