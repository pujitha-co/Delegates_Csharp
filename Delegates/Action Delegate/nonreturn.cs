using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Action_Delegate
{
     class nonreturn
    {
        static void Main()
        {
            Action<int, double> total = (quantity, price) =>
            {
                double result = quantity * price;

                Console.WriteLine("Total Price: " + result);
            };

            total(5, 200);
        }

    }
}
