using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;
        public Simulation()
        {
            SodaMachine sodaMachine = new SodaMachine();
            Customer customer = new Customer();
        }
        public void CustomerTakesChange()
        {
           customer.wallet.coins.AddRange(sodaMachine.changeDispense);
        }
        public void CustomerTakesSoda()
        {
            customer.backpack.cans.Add(sodaMachine.canInBin);
        }

       
        
    }
}
