using System;



namespace LR1
{

    class Program
    {
        static void Main(string[] args)
        {
            string one, two, three;
            double a, b, c, D, x1, x2, x3, x4, y1, y2;
            Console.WriteLine("Введите параметры  уравнения ax^4+bx^2+c=0.");
            Console.WriteLine("Введите a ");
            one = Console.ReadLine();
            Console.WriteLine("Введите b ");
            two = Console.ReadLine();
            Console.WriteLine("Введите c ");
            three = Console.ReadLine();
            a = Convert.ToDouble(one);
            b = Convert.ToDouble(two);
            c = Convert.ToDouble(three);
            Console.WriteLine("Пусть х^2=y, тогда x^4=y^2. Уравнение примет вид " + a + "y^2+" + b + "y+" + c + "=0.");
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискриминант равен " + D);
            if (D > 0)
            {
                Console.WriteLine("Дискриминант больше нуля.");
                y1 = (-b + Math.Sqrt(D)) / (2 * a);
                y2 = (-b - Math.Sqrt(D)) / (2 * a);

                if (y1 > 0)
                {
                    x1 = Math.Sqrt(y1);
                    x2 = -Math.Sqrt(y1);
                    Console.WriteLine("Уравнение иммет два корня.");
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);

                }
                else
                {
                    Console.WriteLine("у1<0.");                   
                    Console.WriteLine(" y1=" + y1);
                    Console.WriteLine("x^2=" + y1);
                    Console.WriteLine("x^2" + y1 + "=0");
                    D=  - 4  * y1;
                    Console.WriteLine("x1= " + Math.Sqrt(Math.Abs(D)) + " i/" + 2*a);
                    Console.WriteLine("x2= (-" + Math.Sqrt(Math.Abs(D)) + " i)/" + 2 * a);

                }

                    if (y2 > 0)
                    {
                     x3 = Math.Sqrt(y2);
                     x4 = -Math.Sqrt(y2);
                    Console.WriteLine("Уравнение иммет два корня.");
                    Console.WriteLine("x3= " + x3);
                        Console.WriteLine("x4= " + x4);

                    }
                    else 
                    {
                    Console.WriteLine("у2<0.");                    
                    Console.WriteLine(" y2=" + y2);
                    Console.WriteLine("x^2=" + y2);
                    Console.WriteLine("x^2" + y2 + "=0");
                    D = -4 * y2;
                    Console.WriteLine("x3= " + Math.Sqrt(Math.Abs(D)) + " i/" + 2 * a);
                    Console.WriteLine("x4= (-" + Math.Sqrt(Math.Abs(D)) + " i)/" + 2 * a);
                }

            }

            if (D == 0)
            {
                Console.WriteLine(" Уравнение имеет один у.");
                y1 = (-b + Math.Sqrt(D)) / (2 * a);
                y2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("y1=y2= " + y1);

                if (y1 > 0)
                {
                    x1 = Math.Sqrt(y1);
                    x4 = -Math.Sqrt(y2);
                    Console.WriteLine("Уравнение иммет два корня.");
                    Console.WriteLine("x1=x2= " + x1);
                    Console.WriteLine("x3=x4= " + x4);

                }
                else
                {
                    Console.WriteLine(" y1=y2 меньше нуля.");                    
                    Console.WriteLine("x^2=" + y1 );
                    Console.WriteLine("x^2" + y2 + "=0");
                    D = -4 * y1;
                    Console.WriteLine("x1=x2= " + Math.Sqrt(Math.Abs(D)) + " i/" + 2 * a);
                    Console.WriteLine("x3=x4 (-" + Math.Sqrt(Math.Abs(D)) + " i)/" + 2 * a);                    
                }
            }
                    if (D < 0)
                    {
                Console.WriteLine("Дискриминант меньше нуля. ");                                         
                Console.WriteLine("y1=(- " + b + -Math.Sqrt(Math.Abs(D)) +" i)/" + 2 * a);
                Console.WriteLine("y2=(- " + b + "+" + Math.Sqrt(Math.Abs(D)) + " i)/" + 2 * a);
                Console.WriteLine("x1=" + Math.Sqrt( Math.Abs(-b - Math.Sqrt(Math.Abs(D)))) + " i/" +  2 * a);
                Console.WriteLine("x2= -" + Math.Sqrt(Math.Abs(-b - Math.Sqrt(Math.Abs(D)))) + " i/"+2 *a) ;
                Console.WriteLine("x3=("  +Math.Sqrt(Math.Abs(-b + Math.Sqrt(Math.Abs(D)))) + " i/" + 2 * a);
                Console.WriteLine("x4=(-" + Math.Sqrt(Math.Abs(-b + Math.Sqrt(Math.Abs(D)))) + " i/" + 2 * a);




            }                
                    Console.ReadKey();
                }
            }
        }
    




