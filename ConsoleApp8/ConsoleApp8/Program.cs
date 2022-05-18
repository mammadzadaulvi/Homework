using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 1, 3 };
            Console.WriteLine(Yoxla(array1, array2));
        }
        static bool Yoxla(int[] array1, int[] array2)
        {
            string result1 = string.Join("", array1.Select(i => i.ToString()).ToArray());

            string result2 = string.Join("", array2.Select(i => i.ToString()).ToArray());

            bool result = result1.Contains(result2);
            return result;
        }
    }
}
