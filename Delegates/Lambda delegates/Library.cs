using System;


namespace Delegates.Lambda_delegates
{

    delegate string Bookdelegate(string bookname);
    delegate void Issuedelegate(string studentName, string bookname);
    delegate int Finedelegate(int latedays);
    delegate string Messagedelegate();
    delegate void Displaydelegate();
     class Library
    {
        static void Main()
        {
            //lambda with one parameter & string return type

            Bookdelegate book = name => name;
            {
                Console.WriteLine(book("csharp"));

            } ;

            // 2 parameters and no return value

            Issuedelegate details = (studentname, bookname) =>
            {
                Console.WriteLine(studentname, bookname);
            };

            details("pujitha", "csharp");
            details("puja", "angular");

            // 1 parameter and int return type

            Finedelegate days = days => days * 10;
            {
                Console.WriteLine(days(3));

            }

            //without parameter and with return value

            Messagedelegate empty = () => "welcome tooooooo -----";

            Console.WriteLine(empty());

            // no parameter and without return value

            Displaydelegate display = () =>
            {
                Console.WriteLine("give me ");
            };

            display();


        }
    }
}
