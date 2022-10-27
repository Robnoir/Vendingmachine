using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Chocolate
    {

        public string name { get; set; }
        public string description;
        public int price;
        public string id;

        public static List<Chocolate> Coco = new List<Chocolate>();
        public Chocolate(string name, string description, int price, string id)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = id;
        }


        public static void PrintCoco()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu: ");
            foreach (Chocolate chocolate in Chocolate.Coco)
            {

                Console.WriteLine("|{0}| {1},  ||Price: {2}||", chocolate.name, chocolate.description, chocolate.price);
            }
        }


    }
}
