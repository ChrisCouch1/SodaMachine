using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            Customer customer = new Customer();
            SodaMachine sodaMachine = new SodaMachine();
            string userInput1;


            do
            {
                int userInput = UserInterface.IntroductionSelection();
                if (userInput == 1)
                {
                    customer.GetCoinsForPayment(0.60);
                    sodaMachine.Transaction(customer.coinsForPayment, 0.60, "root beer");
                    sodaMachine.DispenseSoda("root beer");
                    customer.backpack.cans.Add(sodaMachine.canInBin);

                }
                else if (userInput == 2)
                {
                    customer.GetCoinsForPayment(0.06);
                    sodaMachine.Transaction(customer.coinsForPayment, 0.06, "orange soda");
                    sodaMachine.DispenseSoda("orange soda");
                    customer.backpack.cans.Add(sodaMachine.canInBin);
                }
                else if (userInput == 3)
                {
                    customer.GetCoinsForPayment(0.35);
                    sodaMachine.Transaction(customer.coinsForPayment, 0.35, "cola");
                    sodaMachine.DispenseSoda("cola");
                    customer.backpack.cans.Add(sodaMachine.canInBin);
                }
                Console.WriteLine("Would you like another? Y or N");
                userInput1 = Console.ReadLine();
            }
            while (userInput1 == "Y");
        }
    }
}
