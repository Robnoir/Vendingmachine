using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Popsoda
    {
        public string name { get; set; }
        public string description;
        public int price;

        public static List<Popsoda> Sodapop = new List<Popsoda>();

        public Popsoda(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public static void PrintPop()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu: ");
            foreach (Popsoda popsoda in Popsoda.Sodapop)
            {

                Console.WriteLine("|{0}| {1},  ||Price: {2}||", popsoda.name, popsoda.description, popsoda.price);
            }
        }





    }
}
