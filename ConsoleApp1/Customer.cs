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
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Quarter());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Dime());
            wallet.coins.Add(new Nickel());
            wallet.coins.Add(new Nickel());
            wallet.coins.Add(new Nickel());
            wallet.coins.Add(new Nickel());
            wallet.coins.Add(new Nickel());
            wallet.coins.Add(new Penny());
            wallet.coins.Add(new Penny());
            wallet.coins.Add(new Penny());
            wallet.coins.Add(new Penny());
            wallet.coins.Add(new Penny());
            backpack = new Backpack();
        }
        

    }
    

}
