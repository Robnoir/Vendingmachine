using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Chocolate : Products , Interract
    {
       

        public static Chocolate twix = new Chocolate { name = "Twix", description = "The two stix of heaven with a core of amazing crumb and fudge", price = 10 };
        public static Chocolate Mars = new Chocolate { name = "Mars bar ", description = "A bar made on this planet but tastes as cosmic as the name", price = 10 };
        public static Chocolate KitKat = new Chocolate { name = "KitKat", description ="Four bars of heaven, where you get if you eat it piece by piece", price = 10 };
        public static Chocolate Toblerone = new Chocolate { name = "Toblerone", description = "The only row of mountain you need to climb to reach the tip of the ice berg", price= 10 };

        public static List<Chocolate> chocolist = new List<Chocolate>
        {
            twix,
            Mars,
            KitKat,
            Toblerone,
        };



        public static void PrintCoco()
        {


            while (true)
            {

                Console.Clear();

                Console.WriteLine("Here is the Sandwich menu, please make a selection on wich sandwich to buy: ");
                Console.WriteLine("1. Twix");
                Console.WriteLine("2. Mars");
                Console.WriteLine("3. KitKat");
                Console.WriteLine("4. Toblerone");
                Console.WriteLine("5.Description");
                string menuselect = Console.ReadLine();
                if (menuselect == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing Twix , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");
                    if (Console.ReadLine() == "1")
                    {
                        Console.Clear();
                        Interract.buyitem();
                        Interract.eatchocolate();
                        Console.ReadLine();

                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintCoco();

                    }
                    else if (Console.ReadLine() == "3")
                    {
                        break;
                    }


                }
                else if (menuselect == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing Mars , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");

                    if (Console.ReadLine() == "1")
                    {
                        Console.Clear();

                        Interract.buyitem();
                        Interract.eatchocolate();
                        Console.ReadLine();
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintCoco();
                    }

                }
                else if (menuselect == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for KitKat, Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");
                    if (Console.ReadLine() == "1")
                    {
                        Interract.buyitem();
                        Interract.eatchocolate();

                        Console.ReadKey();
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintCoco();
                    }
                }
                else if (menuselect == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Thanx for choosing Toblerone , Please make a selection: ");
                    Console.WriteLine("1. Buy Item.");
                    Console.WriteLine("2. Go Back");
                    if (Console.ReadLine() == "1")
                    {
                        Interract.buyitem();
                        Interract.eatchocolate();
                        Console.ReadKey();
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        PrintCoco();

                    }
                    Console.ReadKey();
                }
                else if (menuselect == "5")
                {
                    Interract.sandwichDescription();
                    foreach (var coco in chocolist)
                    {
                        Console.WriteLine(coco.description);
                    }
                }







            }



        }


    }
}
