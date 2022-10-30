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
            Console.WriteLine("Item bought.");
        }

       

        public void drink()
        {

            Console.WriteLine("You are now drinking");
        }  
        public void eat()
        {
            Console.WriteLine("You are now eating your chocolate");
        }
        public void eatsandwich()
        {
            Console.WriteLine("You are now eating your sandwich");
        }


       


    }
}
