using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02CustomClasses
{
    //this is definition of calculator (its not object just template)

    internal class Calculator
    {
        public int CalculateSum(int a, int b)
        {
            int c = a+ b;

            return c;
        }
        public int CalculateDiffrence(int a, int b)
        {
            int c = a - b;

            return c;
        }

    }
}
