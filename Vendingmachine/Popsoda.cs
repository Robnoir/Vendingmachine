using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Popsoda
    {
        public string name;
        public string description;
        public int price;

        public static List<Popsoda> Sodapop = new List<Popsoda>();

        public Popsoda(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }







    }
}
