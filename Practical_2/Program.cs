using System;

namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 7;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}