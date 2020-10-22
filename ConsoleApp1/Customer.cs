using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public Wallet wallet;
        public Backpack backpack;
        public List<Coin> coinsForPayment;

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
        public List<Coin> GetCoinsForPayment(double payment)
        {
            while (payment > 0)
            {
                if (payment >= 0.25)
                {
                    foreach (Coin coin in wallet.coins)
                    {
                        if (coin.Value == 0.25)
                        {
                            wallet.coins.Remove(coin);
                            coinsForPayment.Add(coin);
                        }
                    }
                }
                else if (payment >= 0.10)
                {
                    foreach (Coin coin in wallet.coins)
                    {
                        if (coin.Value == 0.10)
                        {
                            wallet.coins.Remove(coin);
                            coinsForPayment.Add(coin);
                        }
                    }
                }
                else if (payment >= 0.05)
                {
                    foreach (Coin coin in wallet.coins)
                    {
                        if (coin.Value == 0.05)
                        {
                            wallet.coins.Remove(coin);
                            coinsForPayment.Add(coin);
                        }
                    }
                }
                else if (payment >= 0.01)
                {
                    foreach (Coin coin in wallet.coins)
                    {
                        if (coin.Value == 0.01)
                        {
                            wallet.coins.Remove(coin);
                            coinsForPayment.Add(coin);
                        }
                    }
                }
            }
            return coinsForPayment;
        }
        


    }
}
    
