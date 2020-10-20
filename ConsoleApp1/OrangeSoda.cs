using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrangeSoda : Can
    {
        protected double cost = 0.06;
        public double Cost
        {
            get { return cost; }
        }
        public string name = "orange soda";
    }
}
