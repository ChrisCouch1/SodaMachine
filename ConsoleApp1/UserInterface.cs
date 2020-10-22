using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class UserInterface
    {
        public static double CovertListOfCoinsToDouble(List<Coin> coins)
        {
            double listOfCoinsValue = 0;
            foreach (Coin item in coins)
            {
                listOfCoinsValue += item.Value;

            }
            Console.WriteLine($"There is {listOfCoinsValue}.");
            return listOfCoinsValue;
        }
    }
}

