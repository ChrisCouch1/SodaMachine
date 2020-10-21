using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;
        public Simulation(SodaMachine sodaMachine, Customer customer)
        {
            this.sodaMachine = new SodaMachine();
            this.customer = new Customer();

        }
        
        
    }
}
