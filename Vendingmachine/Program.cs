using Microsoft.VisualBasic;
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
           
            
           
            
           
            //Lägger till artiklar till listan Coco
            
            

            ConsoleKeyInfo input;
            do
            {
                

                Console.WriteLine("|*HELLO WELCOME TO THE VENDINGMACHINE!*|");

                Console.WriteLine("|   What would you like to buy? |");
                Console.WriteLine("|        1. Sandwich            |");
                Console.WriteLine("|        2. Softdrink           |");
                Console.WriteLine("|        3. Candybar            |");
                Console.WriteLine("|        4. End program         |");
                Console.WriteLine("|  * Please make a selection *  |");

                input = Console.ReadKey();
                
                
                switch (input.KeyChar.ToString())
                {

                    
                    case "1":
                        Console.Clear();
                        Sandwich.PrintSandwich();

                       
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.Clear();
                        Popsoda.PrintPop();
                        break;

                    case "3":
                        Console.Clear();
                        Chocolate.PrintCoco();
                        break;
                       
                    case "4":

                       Environment.Exit(0);


                        break;
                    default:
                        break;

                }





            } while (input.KeyChar.ToString() != "E");





            Console.ReadKey();
        }



      


    }
}