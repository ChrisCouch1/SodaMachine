using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Wallet
    {
        public List<Coin> coins;
        public Card card;

        public Wallet()
        {
            List<Coin> coins = new List<Coin>();
            card = new Card();

        }
               
    }
}
