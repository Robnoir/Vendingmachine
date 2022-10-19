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
            Console.WriteLine("Hello! Welcome to the Vendingmachine!");


           
             
            Console.WriteLine(" ");

            //Lägger till artiklar till listan Sandwichlist
            Sandwich.Sandwichlist.Add(new Sandwich("1.Philly steak sandwitch ", "Description: Beef and a lot of cheese", 50));
            Sandwich.Sandwichlist.Add(new Sandwich("2.BLT ", "Description: Bacon,lettuce and Tomato", 45));
            Sandwich.Sandwichlist.Add(new Sandwich("3.Ostmacka", "Description: Traditional Swedish booring cheese sandwitch ", 78));
            Sandwich.Sandwichlist.Add(new Sandwich("4.Mozarella in Carozza", "Description: Fried sandwich with delicious melted mozarella, It will make you say Mamma mia! ", 52));


            

            //Lägger till artiklar till listan Sodapop
            Popsoda.Sodapop.Add(new Popsoda("Coca Cola ", "Description: Classic Coca Cola with a very very secret recipe", 60));
            Popsoda.Sodapop.Add(new Popsoda("Sprite ", "Description: Every child under 7 years olds favourite drink with a taste of lemon and lime", 12));
            Popsoda.Sodapop.Add(new Popsoda("Fanta ", "Description: Refreshing taste of orange but the color is yellow... but just in sweden!", 26));
            Popsoda.Sodapop.Add(new Popsoda("Red Bull ", "Description: The Energy drink that promised you wings! Untill someone sued them.... The legend says that the taste is a blend of fruits ", 32));
            Popsoda.Sodapop.Add(new Popsoda("Root Beer ", "Description: So delicious, so sweet, so magnificent Probably the best soda in the world (Pun intended)", 10));


            
            //Lägger till artiklar till listan Coco
            Chocolate.Coco.Add(new Chocolate("Twix ", "Description: Two sticks of awesomeness, add a string between and you have nun-chucks ", 15));
            Chocolate.Coco.Add(new Chocolate("Mars", "Description: The creamiest bar of them all but without the cream but it is made on planet earth until Elon gets on with it", 13));
            Chocolate.Coco.Add(new Chocolate("Bounty", "Description: Lets get coconut flakes all over your mouth and find a flake one week later, the only bounty that should exist is on the makers head.", 240));
            Chocolate.Coco.Add(new Chocolate("Snickers", "Description: The king of them all but it's comically easy to make it at home...", 23));

            //||ANROPAR METODEN SANDWICH||
            PrintSandwich();
          
            Console.ReadKey();
        }

        public static void PrintSandwich()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu: ");
            foreach (Sandwich sandwichlist in Sandwich.Sandwichlist)
            {
                
                Console.WriteLine("|{0}| {1},  ||Price: {2}||", sandwichlist.name, sandwichlist.description, sandwichlist.price);
            }
        }
        public static void PrintCoco()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu: ");
            foreach (Sandwich sandwichlist in Sandwich.Sandwichlist)
            {

                Console.WriteLine("|{0}| {1},  ||Price: {2}||", sandwichlist.name, sandwichlist.description, sandwichlist.price);
            }
        }

        public static void PrintPop()
        {
            //Skriva ut innehållet från den statiska listan inuti klassen Person
            Console.WriteLine("Here is the Sandwich menu: ");
            foreach (Sandwich sandwichlist in Sandwich.Sandwichlist)
            {

                Console.WriteLine("|{0}| {1},  ||Price: {2}||", sandwichlist.name, sandwichlist.description, sandwichlist.price);
            }
        }
    }
}