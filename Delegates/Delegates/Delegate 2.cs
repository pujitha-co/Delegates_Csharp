using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Delegates
{
    delegate void ProductDetails(string productName, double productPrice);
   
 
    
    class ShoppingManagement
    {
        static void Displayproduct(string productName,double productprice)
        {
            Console.WriteLine("productname" + productName);
            Console.WriteLine("ProductPrice" + productprice);
        }

        static void Main(string[]args)
        {
            ProductDetails pp = Displayproduct;
            pp("dress", 2434);
        }
       

        }
    }

