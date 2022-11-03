using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vendingmachine
{
    internal class Sandwich : Products, Interract
    {



        public static Sandwich BLT = new Sandwich { name = "BLT", description = "Description: Bacon, Lettuce and tomato", price = 50 };
        public static Sandwich PhillyCheese = new Sandwich { name = "Cheese", description = "Description: Cheese, Lettuce and tomato", price = 50 };
        public static Sandwich Ostmacka = new Sandwich { name = "Ostmacka", description = "Plain Cheese sandwich", price = 50 };
        public static Sandwich ClubSandwich = new Sandwich { name = "ClubSandwich", description = "Delicius turkey sallad sandwich", price = 50 };

        public static List<Sandwich> Sandwichlist = new List<Sandwich>
        {
            BLT,
            PhillyCheese,
            Ostmacka,
            ClubSandwich,
        };



        public static void PrintSandwich()
        {

            while (true)
            {

                Console.Clear();

                Console.WriteLine("Here is the Sandwich menu, please make a selection on wich sandwich to buy: ");
                Console.WriteLine("1. BLT");
                Console.WriteLine("2. Philly Cheese");
                Console.WriteLine("3. Ostmacka");
                Console.WriteLine("4. Clubsandwich");
                Console.WriteLine("5.Description");
                string menuselect= Console.ReadLine();
                if (menuselect == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing BLT , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");
                    if (Console.ReadLine() == "1")
                    {
                        Console.Clear();
                        Interract.buyitem();
                        Interract.eatsandwich();
                        Console.ReadLine();

                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintSandwich();

                    }
                    else if (Console.ReadLine() == "3")
                    {
                        break;
                    }


                }else if(menuselect == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing Philly Cheese , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");

                    if(Console.ReadLine() == "1")
                    {
                        Console.Clear();
                        
                        Interract.buyitem();
                        Interract.eatsandwich();
                        Console.ReadLine();
                    } else if (Console.ReadLine() == "2")
                    {
                        PrintSandwich();
                    }

                } else if(menuselect == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing Ostmacka , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");
                    if (Console.ReadLine() == "1")
                    {
                        Interract.buyitem();
                        Interract.eatsandwich();

                        Console.ReadKey();
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintSandwich();
                    }
                } else if(menuselect == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing Clubsandwich , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");
                    if (Console.ReadLine() == "1")
                    {
                        Interract.buyitem();
                        Interract.eatsandwich();
                        Console.ReadKey();
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintSandwich();

                    }
                    Console.ReadKey();
                } else if(menuselect == "5")
                {
                    Interract.sandwichDescription();
                    foreach(var sandwich in Sandwichlist)
                    {
                        Console.WriteLine(sandwich.description);
                    }   
                }
                
                


              
                  

            }

            

        }
    }

}