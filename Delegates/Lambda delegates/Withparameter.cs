using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Lambda_delegates
{
    delegate int calculate(int a, int b);
    class Calcu
    {
        static void Main()
        {
            calculate add = (a, b) => a + b;

            Console.WriteLine(add(10, 20));
            Console.WriteLine(add(5, 3));
        }
    }
}
