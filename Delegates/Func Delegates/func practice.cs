using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Func_Delegates
{
     class func_practice
    {

        static void Main()

        {

            // func without parameter

            Func<string> message =() => "welcome to csharp---###";
            Console.WriteLine(message());

            // func with one parameter-square

            Func<int, int> square = x => x * x;
            Console.WriteLine("square:" + square(5));

            //func with 2 parameters

            Func<int,int,int> multiply = (a, b) => a * b;
            Console.WriteLine(multiply(6,5));

           
        }
    }
}
