using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Nurlan Faiq Emil Tural Yusif"));
        }

        static string Reverse(string soz)
        {
            char[] herf = soz.ToCharArray();
            string ReversedString = "";

            for (int i = herf.Length - 1; i > -1; i--)
            {
                ReversedString += herf[i];
            }
            return ReversedString;
        }
    }
}
