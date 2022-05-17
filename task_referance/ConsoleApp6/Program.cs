using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string array1 = "Nurlan Faiq Emil Tural Yusif";
            Console.WriteLine(Reverse(array1));
        }

        static string Reverse(string array1)
        {
            string array2 = "";
            foreach (var word in array1.Split(' '))
            {
                string temp = "";
                foreach (var item in word.ToCharArray())
                {
                    temp = item + temp;
                }
                array2 = array2 + temp + " ";
            }
            return array2;
        }
    }
}
