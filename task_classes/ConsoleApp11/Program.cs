using System;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //int[] array1 = { 4, 3, 6, 2, 8, 1 };
            //CustomSort(array1);



            // Task 2

            //string[] array2 = { "alma", "armud", "meyve", "dolma" };
            //Console.WriteLine(FindTheWord(array2, 'd'));


            // Task 3
            //Student student1 = new Student
            //{
            //    HomeworkGrades = new int[] { 100, 90, 100 },
            //    ProjectGrades = new int[] { 100, 100, 100 },
            //    FinalGrade = 90,
            //    Resistency = new bool[] { true, true, true, false, false }
            //};
            //if (student1.Diplom() > 90)
            //{
            //    Console.WriteLine("HighHonour");
            //}
            //else if (student1.Diplom() > 80)
            //{
            //    Console.WriteLine("Honour");
            //}
            //else
            //{
            //    Console.WriteLine("Normal");
            //}


            // Task 4
            //User user1 = new User
            //{
            //    Name = "nurlan",
            //    Password = "123mammadov123"
            //};
            //Console.WriteLine(user1.IsPasswordValid());

        }




        // Task 1

        //static void CustomSort(int[] arr)
        //{
        //    int temp = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[i] > arr[j])
        //            {
        //                temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }
        //    }
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}



        // Task 2

        //static string FindTheWord(string[] str, char X)
        //{
        //    StringBuilder arr = new StringBuilder();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i].ToLower().IndexOf(X) > -1)
        //        {
        //            arr.Append(str[i]).Append(" ");
        //        }
        //    }
        //    return arr.ToString();
        //}
    }


    // Task 3
    //class Student
    //{
    //    public int[] HomeworkGrades;
    //    public int[] ProjectGrades;
    //    public int FinalGrade;
    //    public bool[] Resistency;
    //    public int Resist;

    //    public double Diplom()
    //    {
    //        double UmumiBal;
    //        int count = 0;
    //        for (int i = 0; i < Resistency.Length; i++)
    //        {
    //            if (true)
    //            {
    //                count++;
    //            }
    //        }
    //        if (count > 2)
    //        {
    //            Resist = 100;
    //        }
    //        double Homework = Queryable.Average(HomeworkGrades.AsQueryable());
    //        double Project = Queryable.Average(ProjectGrades.AsQueryable());
    //        UmumiBal = (Project * 25 + Homework * 25 + Resist * 10 + FinalGrade * 40) / 100;

    //        return UmumiBal;
    //    }
    //}





    // Task 4

    //class User
    //{
    //    public string Name;
    //    public string Password;

    //    public bool IsPasswordValid()
    //    {
    //        //bool isAllDigits = !Password.Any(ch => ch < '0' || ch > '9');
    //        bool containsInt = Password.Any(char.IsDigit);
    //        if (Password.Length >= 6)
    //        {
    //            if (containsInt == true)
    //            {
    //                int i = 0;
    //                int j = 0;
    //                bool result = true;
    //                while (i < Password.Length && j < Name.Length)
    //                {
    //                    if (Password[i] == Name[j])
    //                    {
    //                        i++;
    //                        j++;
    //                        if (j == Name.Length)
    //                        {
    //                            result = false;
    //                        }
    //                    }
    //                    else
    //                    {
    //                        i = i - j + 1;
    //                        j = 0;
    //                    }
    //                }
    //                return result;
    //            }
    //        }
    //        return default;
    //    }
    //}
}
