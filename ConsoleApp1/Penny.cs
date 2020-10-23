using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Penny : Coin
    {
        protected double value = 0.01;
        public double Value
        {
            get { return value; }
        }
        public string name = "penny";
        public Penny()
        {

        }

    }
}
