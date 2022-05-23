using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Akif", "Memmedov", 20);
            Console.WriteLine(person1.Name + " " + person1.Surname + " " + person1.Age + " " + person1.IsAdult);


            Person person2 = new Person("Abbas", "Eliyev", 17);
            Console.WriteLine(person2.Name + " " + person2.Surname + " " + person2.Age + " " + person2.IsAdult);
        }
    }
}
