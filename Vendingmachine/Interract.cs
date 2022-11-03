using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal interface Interract
    {

        public static void buyitem()
        {
            Console.WriteLine("item bought");
        }

        public  static void sandwichDescription()
        {
            Console.WriteLine("Here is your information about your sandwiches: ");
                
        }
  

        public static void drink()
        {
            Console.WriteLine("You are now drinking your beverage");
        }
        public static void eatchocolate()
        {
            Console.WriteLine("You are now eating your chocolate");

            Console.ReadKey();
        }
        public static void eatsandwich()
        {
            Console.WriteLine("You are now eating your sandwich");
        }





    }
}
