using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02CustomClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This is variable and this variable refers to new object
            Calculator c = new Calculator();

            // c is only the handle (grip) to object 


            // Webclient wc = new WebClien();

            Calculator c1; // what is it? This is only variable 
                           //
            //only 'new' keyword creates object in memory

            new Calculator(); //usually we dont use it

            Calculator c2;

            // later...
            c2 = new Calculator();

            int g = c.CalculateSum(3, 4);
            int g1 = c.CalculateDiffrence(4, 3);

            Console.WriteLine(g);
            Console.WriteLine(g1);



            C04EX_Calculator c04 = new C04EX_Calculator();

            double? res1 = c04.PerformOperation(2, 3,'+');
            double? res2 = c04.PerformOperation("1222-4");

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();



        }
    }
}
