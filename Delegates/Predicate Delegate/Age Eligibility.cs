using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Predicate_Delegate
{
     class Age_Eligibility
    {

        static void Main()
        {
            Predicate<int> eligible = age =>
            {
                return age >= 18;
            };

            Console.WriteLine(eligible(21));
            Console.WriteLine(eligible(15));
        }
    }
}
