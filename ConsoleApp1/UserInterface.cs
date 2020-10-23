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
        public static int IntroductionSelection()
        {
            Console.WriteLine("Welcome to a SodaFunk Soda Machine\n\n\nWhich soda would you like?\n1 for Rootbeer $0.60\n2 for Orange Soda $0.06\n3 for Cola $0.35");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
        
    }
}

