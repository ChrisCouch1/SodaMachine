using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SodaMachine
    {
        public List<Coin> register;
        public List<Can> inventory;
        public List<Coin> changeDispense;
        public Can canInBin;

        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            for (int i = 0; i <= 20; i++)
            {
                register.Add(new Quarter());
            }
            for (int i = 0; i <= 10; i++)
            {
                register.Add(new Dime());
            }
            for (int i = 0; i <= 20; i++)
            {
                register.Add(new Nickel());
            }
            for (int i = 0; i <= 50; i++)
            {
                register.Add(new Penny());
            }
            for (int i = 0; i <= 15; i++)
            {
                inventory.Add(new RootBeer());
            }
            for (int i = 0; i <= 15; i++)
            {
                inventory.Add(new OrangeSoda());
            }
            for (int i = 0; i <= 15; i++)
            {
                inventory.Add(new Cola());
            }
        }
        public void Transaction(List<Coin> coins, double costSoda, string canName)
        {
            //determines the amount based on the coin objects
            double amountPassedIn = UserInterface.CovertListOfCoinsToDouble(coins);

            if (amountPassedIn < costSoda)
            {
                Console.WriteLine("Invalid Tender. Returning payment...");
            }
            else if (amountPassedIn == costSoda) 
            {
                //accept money into register
                register.AddRange(coins);

                //dispense soda
                DispenseSoda(canName);
            }
            else if(amountPassedIn > costSoda)
            {
                //accept money into register
                register.AddRange(coins);
                //dispense soda
                DispenseSoda(canName);
                //return change (change = amountPassedIn - costSoda)
                double change = CalculateChange(amountPassedIn, costSoda);
                changeDispense = MakeDispenseChangeList(change);
            }
        }
        public double CalculateChange(double amountPassedIn, double costSoda)
        {
            double change = amountPassedIn - costSoda;
            return change;

        }

        public void DispenseSoda(string canName)
        {
            foreach(Can item in inventory)
            {
                if(canName == item.name)
                {
                    inventory.Remove(item);
                    canInBin = item;
                }
            }
        }
        public List<Coin> MakeDispenseChangeList(double change)
        {
            double changeReturned = 0;
            while(change > 0)
            {
                if(change >= 0.25)
                {
                    foreach(Coin item in register)
                    {
                        if(item.Value == 0.25)
                        {
                            changeReturned += item.Value;
                            register.Remove(item);
                            changeDispense.Add(item);                    
                        }
                    }
                }
                else if(change >= 0.10)
                {
                    foreach(Coin item in register)
                    {
                        if(item.Value == 0.10)
                        {
                            changeReturned += item.Value;
                            register.Remove(item);
                            changeDispense.Add(item);
                        }
                    }
                }
                else if(change >= 0.05)
                {
                    foreach(Coin item in register)
                    {
                        if(item.Value == 0.05)
                        {
                            changeReturned += item.Value;
                            register.Remove(item);
                            changeDispense.Add(item);
                        }
                    }
                }
                else if(change >= 0.01)
                {
                    foreach(Coin item in register)
                    {
                        if(item.Value == 0.01)
                        {
                            changeReturned += item.Value;
                            register.Remove(item);
                            changeDispense.Add(item);
                        }
                    }
                }
            }
            Console.WriteLine($"Returning {changeReturned} in change.");
            return changeDispense;
        }

        
    }
}
