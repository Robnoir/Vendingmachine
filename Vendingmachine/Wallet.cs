using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Wallet
    {
        public int Deposit { get; set; }
        public Wallet()
        {
            Deposit = 0;
        }
        public void Depositcoin(int money)
        {

            Console.WriteLine("Please deposit money ");
            //The only valid entries are 5, 10 ,25, 100
            switch (money)
            {
                case (5):
                    Deposit += 5;
                    break;
                case (10):
                    Deposit += 10;
                    break;
                case (25):
                    Deposit += 25;
                    break;
                case (100):
                    Deposit += 100;
                    break;

                default:
                    Console.WriteLine("Invalid Entry.");
                    break;



            }
        }

    }
}
