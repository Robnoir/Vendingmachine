using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Chocolate
    {

        public string name;
        public string description;
        public int price;
        public static List<Chocolate> Coco = new List<Chocolate>();
        public Chocolate(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }





    }
}
