using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Popsoda
    {
        public string name { get; set; }
        public string description;
        public int Sodaprice;
        public string id;
       
        public static List<Popsoda> Sodapop = new List<Popsoda>();

        public Popsoda(string name, string description, int price, string id)
        {
            this.name = name;
            this.description = description;
            this.Sodaprice = price;
            this.id = id;
        }

        public static void PrintPop()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Soda pop menu: ");
            foreach (Popsoda popsoda in Popsoda.Sodapop)
            {

                Console.WriteLine("|{0}| {1},  ||Price: {2}||", popsoda.name, popsoda.description, popsoda.Sodaprice);
            }
        }





    }
}
