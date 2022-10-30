using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public static void Info()
        {
            Console.WriteLine("sugavmig");
        }

        
        public static void PrintSandwich()
        {



             
            //Skriva ut innehållet från den statiska listan inuti klassen Person

            Console.WriteLine("Here is the Sandwich menu, please make a selection: ");


            ConsoleKeyInfo input;
            do
            {
                

                foreach (var sandwich in Sandwichlist)
                {

                    Console.WriteLine("|{0}| |Price: {1}||", sandwich.name , sandwich.price);

                }

                
                input = Console.ReadKey();
                string val;
                switch (input.KeyChar.ToString())
                {
                   //TODO
                   //Utveckla if valet.
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Thanx for choosing the BLT");
                        Console.WriteLine("1.See information");
                        Console.WriteLine("2.Buy Sandwich");

                        val = Console.ReadLine();
                        if(val =="1")
                        {
                            foreach(var sandwich in Sandwichlist)
                            {
                                Console.WriteLine(sandwich.description = "BLT");
                            }

                        }
                        else if(val =="2")
                        {
                            Interract.buyitem();

                        }
                       
                        
                        break;


                    default:
                        break;

                }
                

            } while (input.KeyChar.ToString() != "E");

            Console.ReadKey();
               
        }


    }
}
