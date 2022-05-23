using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

            IsAdult = false;
            if (age > 18)
            {
                IsAdult = true;
            }
        }

        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;

    }
}
