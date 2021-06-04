using System;
namespace LR5
{
    public class Economist : Student
    {
        public Economist(string university, string faculty, string hometown,
                          string name, string surname, int age)
                 : base(university, faculty, hometown,  name, surname, age)
        {
        }
        public override string ToString()
        {           
            return "Студент: \nИмя-" + Name + "  \nФамилия-" + Surname + "  \nВозраст-" + Age + "\n" +
                  "Страна-" + Country + "  \nРост-" + Height + "\t" +
            "\nУниверситет- " + University + "  \nФакyльтет-" + Faculty + "  \nРодной город-" + Hometown;
        }
    }
}
