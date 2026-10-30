using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Delegates
{

    delegate void BonusEmployee(string name, double bonusAmount);
    class Delegate_1
    {
        static void EmployeeBonus(string name, double bonusAmount)
        {
            Console.WriteLine($"Employee: {name}, Bonus Amount: {bonusAmount}");
        }
        static void Main(string[] args)
        {
            BonusEmployee emp = EmployeeBonus;
            emp("pujitha", 1000.00);

        }
    }
}
