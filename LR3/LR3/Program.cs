using System;
namespace LR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Info inf = new Info();
            Human hum = new Human();
            int i = 0;
            Person person = new Person();
            int sw = 0;
            while (sw != 3)
            {
                Console.WriteLine("1 - Получить информацию\n2 - Запись информации\n3- Выйти");
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
                        Console.WriteLine("Введите имя");
                        hum.Name = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        hum.Surname = Console.ReadLine();
                        Console.WriteLine("Введите возраст");
                        hum.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите университет");
                        hum.Univercity = Console.ReadLine();
                        Console.WriteLine("Введите специальность");
                        hum.Specialty = Console.ReadLine();
                        inf.Student();
                        i++;
                        break;
                    case 2:
                        Console.WriteLine(hum.Name + " " + hum.Surname + " " + hum.Age + " лет " + hum.Univercity + " " + hum.Specialty);

                        break;
                    case 3:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
