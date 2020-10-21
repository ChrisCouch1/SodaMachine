using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public Wallet wallet;
        public Backpack backpack;

        public Customer()
        {
            wallet = new Wallet();
            for (int i = 0; i <= 14; i++)
            {
                wallet.coins.Add(new Quarter());
            }
            for (int i = 0; i <= 9; i++)
            {
                wallet.coins.Add(new Dime());
            }
            for (int i = 0; i <= 10; i++)
            {
                wallet.coins.Add(new Nickel());
            }
            for (int i = 0; i <= 10; i++)
            {
                wallet.coins.Add(new Penny());
            }
            backpack = new Backpack();
        }
        


        }


    }
}
    
