using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Action_Delegate
{
     class Withparameter
    {
        static void Main()
        {
            Action<string, double> employee = (name, salary) =>
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Salary: " + salary);
            };

            employee("pujithaa", 35000);
        }
    }
}
