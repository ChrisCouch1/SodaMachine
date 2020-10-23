using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dime : Coin
    {
        protected double value = 0.10;
        public double Value
        {
            get { return value; }
        }
        public string name = "dime";
        public Dime()
        {

        }

    }
}
