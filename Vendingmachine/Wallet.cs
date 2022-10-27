using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendingmachine
{
    internal class Wallet
    {
        public int Moneytotal { get; set; }
        public Wallet()
        {
            Moneytotal = 0;
        }
        public void Depositcoin(int money)
        {
            //The only valid entries are 5, 10 ,25, 100
            switch (money)
            {
                case (5):
                    Moneytotal += 5;
                    break;
                case (10):
                    Moneytotal += 10;
                    break;
                case (25):
                    Moneytotal += 25;
                    break;
                case (100):
                    Moneytotal += 100;
                    break;

                default:
                    Console.WriteLine("Invalid Entry.");
                    break;



            }
        }

    }
}
