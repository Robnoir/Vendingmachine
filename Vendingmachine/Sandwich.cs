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
        public string id;
       public static List<Sandwich> Sandwichlist = new List<Sandwich>();




        
        public Sandwich(string name, string description, int price, string id)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.id = id;

          
        }

        public void Info()
        {
            Console.WriteLine();
        }

        public int val;
        public static void PrintSandwich()
        {
            int val;


            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu, please make a selection: ");


            Console.WriteLine(" ");
            foreach (Sandwich sandwichlist in Sandwich.Sandwichlist)
            {

                Console.WriteLine("|{0}| |Price: {1}||", sandwichlist.name, sandwichlist.price);
                
            }

            


            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            do
            {
                
                Console.WriteLine(" ");
                switch(consoleKeyInfo.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("Thank you for choosing Philly steak sandwich!");
                        Console.WriteLine("Do you want to see information about the sandwich?");
                        string info = Console.ReadKey();
                        
                        if (info == "Y")
                        {
                            Console.WriteLine("{0}");
                        }

                        


                }


            } while (consoleKeyInfo.KeyChar.ToString() != "E");

           





               
        }


    }
}
