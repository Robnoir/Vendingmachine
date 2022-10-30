using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vendingmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Lägger till artiklar till listan Sandwichlist
            Sandwich.Sandwichlist.Add(new Sandwich("1.Philly steak sandwitch ", "Description: Beef and a lot of cheese", 50, "AA"));
            Sandwich.Sandwichlist.Add(new Sandwich("2.BLT ", "Description: Bacon,lettuce and Tomato", 45, "AB"));
            Sandwich.Sandwichlist.Add(new Sandwich("3.Ostmacka", "Description: Traditional Swedish booring cheese sandwich ", 78, "AC"));
            Sandwich.Sandwichlist.Add(new Sandwich("4.Mozarella in Carozza", "Description: Fried sandwich with delicious melted mozarella, It will make you say Mamma mia! ", 52, "AD"));



            //Lägger till artiklar till listan Sodapop
            Popsoda.Sodapop.Add(new Popsoda("1.Coca Cola ", "Description: Classic Coca Cola with a very very secret recipe", 60, "BA"));
            Popsoda.Sodapop.Add(new Popsoda("2.Sprite ", "Description: Every child under 7 years olds favourite drink with a taste of lemon and lime", 12, "BB"));
            Popsoda.Sodapop.Add(new Popsoda("3.Fanta ", "Description: Refreshing taste of orange but the color is yellow... but just in sweden!", 26, "BC"));
            Popsoda.Sodapop.Add(new Popsoda("4.Red Bull ", "Description: The Energy drink that promised you wings! Untill someone sued them.... The legend says that the taste is a blend of fruits ", 32, "BC"));
            Popsoda.Sodapop.Add(new Popsoda("5.Root Beer ", "Description: So delicious, so sweet, so magnificent Probably the best soda in the world (Pun intended)", 10, "BD"));



            //Lägger till artiklar till listan Coco
            Chocolate.Coco.Add(new Chocolate("1.Twix ", "Description: Two sticks of awesomeness, add a string between and you have nun-chucks ", 15, "CA"));
            Chocolate.Coco.Add(new Chocolate("2.Mars", "Description: The creamiest bar of them all but without the cream but it is made on planet earth until Elon gets on with it", 13, "CB"));
            Chocolate.Coco.Add(new Chocolate("3.Bounty", "Description: Lets get coconut flakes all over your mouth and find a flake one week later, the only bounty that should exist is on the makers head.", 240, "CC"));
            Chocolate.Coco.Add(new Chocolate("4.Snickers", "Description: The king of them all but it's comically easy to make it at home...", 23, "CD"));





            ConsoleKeyInfo input;
            do
            {
                

                Console.WriteLine("|*HELLO WELCOME TO THE VENDINGMACHINE!*|");

                Console.WriteLine("|   What would you like to buy? |");
                Console.WriteLine("|        1. Sandwich            |");
                Console.WriteLine("|        2. Softdrink           |");
                Console.WriteLine("|        3. Candybar            |");
                Console.WriteLine("|        4.Deposit money        |");
                Console.WriteLine("|  * Please make a selection *  |");

                input = Console.ReadKey();

                switch (input.KeyChar.ToString())
                {
                    case "1":
                        Console.Clear();
                        Sandwich.PrintSandwich();
                        Sandwich.Info();
                        break;

                    case "2":
                        Console.Clear();
                        Popsoda.PrintPop();
                        break;

                    case "3":
                        Console.Clear();
                        Chocolate.PrintCoco();
                        break;

                    default:
                        break;

                }

                
                
               

            } while (input.KeyChar.ToString() != "E");

         






            
                




            Console.ReadKey();
        }

        
        

        
    }
}