using System;


namespace True
{
    class Program
    {
        static void Main()
        {
            int year = 2020;
            bool isLeap = true;
            if (year % 4 == 0)
                Console.WriteLine(isLeap);
        }
    }
}