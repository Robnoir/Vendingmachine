using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Sandwich
    {

        public string name { get; set; }
        public string description;
        public int price;

       public static List<Sandwich> Sandwichlist = new List<Sandwich>();




        
        public Sandwich(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;


          
        }

        public void Info()
        {
            Console.WriteLine();
        }

        public static void PrintSandwich()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu: ");
            foreach (Sandwich sandwichlist in Sandwich.Sandwichlist)
            {

                Console.WriteLine("|{0}| {1},  ||Price: {2}||", sandwichlist.name, sandwichlist.description, sandwichlist.price);
            }
        }


    }
}
