using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SodaMachine
    {
        public List<Coin> register = new List<Coin>();
        public List<Can> inventory = new List<Can>();
    public bool CheckIfMoneyReceivedIsEnough(double amountPassedIn, double costSoda)
    {if (amountPassedIn < costSoda)
            {
                return false;

            }
            else
            {
                return true;

            }

    }
        public double CovertListOfCoinsToDouble(List<Coin> coins)
        {
            double listOfCoinsValue = 0;
            foreach(Coin item in coins)
            {
                listOfCoinsValue += item.Value;

            }
            return listOfCoinsValue;
        }
    }
}
