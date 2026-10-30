using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Action_Delegate
{
     class withoutparameter
    {
        static void Main()
        {
            Action welcome = () =>
            {
                Console.WriteLine("Welcome to C# Programming");
            };

            welcome();
        }
    }
}
