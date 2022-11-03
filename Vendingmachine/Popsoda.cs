using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Popsoda : Products, Interract
    {




        //Lägger till artiklar till listan Sodapop
        public static Popsoda CocaCola = new Popsoda { name = "CocaCola", description = "Classic CocaCola with the very secret recipe!", price = 20 };
        public static Popsoda Sprite = new Popsoda { name = "Sprite", description = "Every childs favourite drink with a taste of Lemon and Lime!", price = 20 };
        public static Popsoda Fanta = new Popsoda { name = "Fanta", description = " Taste of carbonated oranges but its yellow...", price = 20 };
        public static Popsoda Rootbeer = new Popsoda { name = "Rootbeer", description = "Probably the best soda in the world", price = 20 };

        //Skapa en lista för läsk 
        public static List<Popsoda> Sodapop = new List<Popsoda>
        {
            CocaCola,
            Sprite,
            Fanta,
            Rootbeer,
        };

        //En method som anropas när användaren har valt läskedryck.
        public static void PrintPop()
        {


            while (true)
            {

                Console.Clear();

                Console.WriteLine("Here is the Sandwich menu, please make a selection on wich sandwich to buy: ");
                Console.WriteLine("1. CocaCola");
                Console.WriteLine("2. Sprite");
                Console.WriteLine("3. Fanta");
                Console.WriteLine("4. Rootbeer");
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
                        PrintPop();


                    }
                    else if (Console.ReadLine() == "3")
                    {
                        break;




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
                            PrintPop();
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
                            PrintPop();
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
                            PrintPop();

                        }
                        Console.ReadKey();
                    }
                    else if (menuselect == "5")
                    {
                        Interract.sandwichDescription();
                        foreach (var popsoda in Sodapop)
                        {
                            Console.WriteLine(popsoda.description);
                        }
                    }







                }





            }



        }



    } 

}  