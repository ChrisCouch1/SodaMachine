using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RootBeer : Can
    {
        protected double cost = 0.60;
        public double Cost
        {
            get { return cost; }
        }
        public string name = "root beer";

    }
}
