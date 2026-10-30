using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Delegates.Func_Delegates
{
  class Employeebonus
    {
        static void Main()
        {
            Func<double, double, double> salary = (basic, allowance) =>
            basic + allowance;

            Func<double,double>bonus = amount => amount * 0.15;

            double totalsalary = salary(3000, 5000);
            double bonusAmount = bonus(totalsalary);

            Console.WriteLine("Total Salary:" + totalsalary);
            Console.WriteLine("Bonus:" + bonusAmount);
            Console.WriteLine("salary with bonus:" + totalsalary +   bonusAmount);

        }
    }
}
