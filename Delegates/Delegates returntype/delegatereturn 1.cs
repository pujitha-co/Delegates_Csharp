using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Delegates_returntype
{
    delegate double salarydelegate(double salary, double bonus);
    class Employeesalary
    {
        static double calculatesalary(double salary, double bonus)
        {

            return salary + bonus;

        }
        static void Main()
        {
            salarydelegate sal = calculatesalary;
            sal(2344, 43222);

            Console.WriteLine("salary: 2344");
            Console.WriteLine("bonus: 43222");
        }

    }
}
