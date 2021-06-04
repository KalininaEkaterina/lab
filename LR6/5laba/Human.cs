using System;
namespace LR5
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public Specialty Specialty { get; set; }
        public Type Type{ get; set; }
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Specialty = Specialty.Programming;
            Type = Type.Student;
            Country = "Беларусь";           
            Height = 155;
        }
        public Human(string name, string surname, int age, string country, Specialty specialty, Type type, int heightr)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Specialty = specialty;
           Type = type;
            Country = country;            
        }
        int _value_preobr;
        public Human(int value_preobr)
        {
            _value_preobr = 3 * value_preobr;
        }
        public int Time { get { return _value_preobr; } }
        public void Preobr(int value_preobr) { _value_preobr = 3 * value_preobr; }
        public void CompareTo()
        {
            if (_value_preobr > 186 * 24) Console.WriteLine("Увы, не успели сдать все лабораторные анализы !");
            else Console.WriteLine("Поздравляем, вам удалось пройти все лабораторные работы! ");
        }
    }
}
