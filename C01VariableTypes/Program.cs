using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C01VariableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            char b = 'a';
            string c = "Hello"; // assing value by a copy ! exeption
            double d = 5.6;
            bool e = false;

            // in C# we have 2 types of data:
            // classes and structures
            //string is class others are structers

            WebClient wc = new WebClient(); 

            StringBuilder sb = new StringBuilder("very long string");

            //difference : classes and structures

            //usually classes are more complex

            // classes are reference types ( reference ) 
            // structures are value types  ( copy )

            int a1 = a;  // i create copy of 6
                         // 

            StringBuilder sb2 = sb; // i dont create new object but assign only reference

            DateTime dt = new DateTime(2023,5,5);
            DateTime dt2 = dt; // copy (because structure)

            // keyword new usualy used on classes;



        }
    }
}
