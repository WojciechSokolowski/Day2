using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14ListOfLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<List<string>> ListOfLists = new List<List<string>>();

            //we dont have multi-dimensional lists!

            List<List<List<List<string>>>> ListOfListOfListOfListOfStrings = new List<List<List<List<string>>>>();

            ListOfLists.Add(new List<string>());
            ListOfLists[0].Add("A");
            ListOfLists[0].Add("B");

            ListOfLists.Add(new List<string>());
            ListOfLists[1].Add("C");
            ListOfLists[1].Add("D");
            ListOfLists[1].Add("E");

            ListOfLists.Add(new List<string>());
            ListOfLists[2].Add("F");
            ListOfLists[2].Add("G");

            foreach (var row in ListOfLists)
            {
                Console.WriteLine(string.Join(" ", row));

            }


            Console.ReadKey();
        }
    }
}
