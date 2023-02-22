using System;

namespace Practical_1
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 7;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}