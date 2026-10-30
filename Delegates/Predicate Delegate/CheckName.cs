using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Predicate_Delegate
{
    class CheckName
    {
        static void Main()
        {
            Predicate<string> checkName = name =>
            {
                return name.StartsWith("A");
            };

            Console.WriteLine(checkName("Anu"));
            Console.WriteLine(checkName("Rahul"));
        }
    }
}
