using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Lambda_delegates
{
    delegate string Message();
   class Withoutparameter
    {
        static void Main()
        {
            Message print = () =>("welcome to c#");
            Console.WriteLine(print());
            Console.WriteLine("welcome to home");

        }
    }
}
