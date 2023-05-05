using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C02CustomClasses
{
    internal class C04EX_Calculator
    {
        public double? PerformOperation(int a, int b, char symbol)
        {
            double? result = 0;
            if (symbol == '+')
                result = a + b;
            else if (symbol == '-')
                result = a - b;
            else if (symbol == '*')
                result = a * b;
            else if (symbol == '/')
                result = a / b;

            if (result != null)
                return result;
            else
                throw new Exception("cannot calculate the result");
        }

        public double? PerformOperation(string equation)
        {


            double? result;
            int signindex = -1;
            int index = 0;
            while (index < equation.Length)
            {
                char sing = Convert.ToChar(equation.Substring(index, 1));
                if (sing == '+')
                {
                    signindex = index;
                    break;
                }
                else if (sing == '-')
                {
                    signindex = index;
                    break;
                }
                else if (sing == '*')
                {
                    signindex = index;
                    break;
                }
                else if (sing == '/')
                {
                    signindex = index;
                    break;
                }
                else
                    index += 1;
            }
            if (signindex >= 0)
            {
                int a = Convert.ToInt32(equation.Substring(0, signindex));
                int b = Convert.ToInt32(equation.Substring(signindex + 1, equation.Length - signindex - 1));
                char symbol = Convert.ToChar(equation.Substring(signindex, 1));
                return PerformOperation(a, b, symbol);
            }
            else
                throw new Exception("cannot calculate the result");
        }

    }
}
