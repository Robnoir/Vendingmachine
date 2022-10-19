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

        public string name;
        public string description;
        public int price;

       public static List<Sandwich> Sandwichlist = new List<Sandwich>();

        public Sandwich(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;


          
        }

       

       


    }
}
