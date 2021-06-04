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
                        Console.WriteLine("Количество лабораторных работ в семестре  8");
                        Console.WriteLine("Среднее время выполнения заказа :");
                        programmer.Preobr(8);
                        if (programmer.Time == 1)
                        {
                            Console.WriteLine(programmer.Time + " час");
                        }
                        else if (programmer.Time <= 23 && programmer.Time == 1)
                        {
                            Console.WriteLine(programmer.Time + " часов");
                        }
                        else if (programmer.Time >= 24)
                        {
                            int d, h;
                            h = programmer.Time % 24;
                            d = programmer.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " дней");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " день");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " день " + h + " часов");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " дней " + h + " часов");
                            }
                        }                        
                        programmer.CompareTo();
                        break;
                    case 2:
                        Economist economist = new Economist("БГУ", "Экономист", "Минск", "Ульяна", "Синявская", 18);
                        Console.WriteLine(economist);
                        Console.WriteLine("Количество лабораторных работ в семестре  9");
                        Console.WriteLine("Среднее время выполнения заказа :");
                        economist.Preobr(9);
                        if (economist.Time == 1)
                        {
                            Console.WriteLine(economist.Time + " час");
                        }
                        else if (economist.Time <= 23 && economist.Time == 1)
                        {
                            Console.WriteLine(economist.Time + " часов");
                        }
                        else if (economist.Time >= 24)
                        {
                            int d, h;
                            h = economist.Time % 24;
                            d = economist.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " дней");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " день");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " день " + h + " часов");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " дней " + h + " часов");
                            }
                        }
                        economist.CompareTo();
                        break;
                    case 3:
                        Teacher teacher = new Teacher("БГПУ", "Филологический", "Минск", "Вероника", "Якимович", 18);
                        Console.WriteLine(teacher);
                        Console.WriteLine("Количество лабораторных работ в семестре  10");
                        Console.WriteLine("Среднее время выполнения заказа :");
                        teacher.Preobr(10);
                        if (teacher.Time == 1)
                        {
                            Console.WriteLine(teacher.Time + " час");
                        }
                        else if (teacher.Time <= 23 && teacher.Time == 1)
                        {
                            Console.WriteLine(teacher.Time + " часов");
                        }
                        else if (teacher.Time >= 24)
                        {
                            int d, h;
                            h = teacher.Time % 24;
                            d = teacher.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " дней");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " день");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " день " + h + " часов");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " дней " + h + " часов");
                            }
                        }
                        teacher.CompareTo();
                        break;
                    case 4:
                        Doctor doctor = new Doctor("БГМУ", "Педиатр", "Минск", "Наташа", "Павловская", 18);
                        Console.WriteLine(doctor);
                        Console.WriteLine("Количество лабораторных работ в семестре  11");
                        Console.WriteLine("Среднее время выполнения заказа :");
                        doctor.Preobr(11);
                        if (doctor.Time == 1)
                        {
                            Console.WriteLine(doctor.Time + " час");
                        }
                        else if (doctor.Time <= 23 && doctor.Time == 1)
                        {
                            Console.WriteLine(doctor.Time + " часов");
                        }
                        else if (doctor.Time >= 24)
                        {
                            int d, h;
                            h = doctor.Time % 24;
                            d = doctor.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " дней");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " день");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " день " + h + " часов");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " день " + h + " час");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " дней " + h + " часов");
                            }
                        }
                        doctor.CompareTo();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
