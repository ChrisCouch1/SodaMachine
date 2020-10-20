using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cola : Can
    {
        protected double cost = 0.35;
        public double Cost
        {
            get { return cost; }
        }
        public string name = "cola";
    }
}
