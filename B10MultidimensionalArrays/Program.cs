using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] singleDimensionArray = new string[3];
            string[,] twoDimensionArray = new string[4, 2]; //total 8 elements

            string[,,] threeDimensionArray = new string[2, 3, 2];

            threeDimensionArray[0, 0, 0] = "a";
            threeDimensionArray[0, 0, 1] = "b";
            int length = threeDimensionArray.Length; //2*3*4==12

            int firstDimentsionSize = threeDimensionArray.GetLength(1); //3

            twoDimensionArray[0, 0] = "A";
            twoDimensionArray[1, 0] = "B";
            twoDimensionArray[2, 0] = "C";
            twoDimensionArray[3, 0] = "D";

            twoDimensionArray[0, 1] = "E";
            twoDimensionArray[1, 1] = "F";
            twoDimensionArray[2, 1] = "G";
            twoDimensionArray[3, 1] = "H";

            Console.WriteLine("--- row wise ---");

            for (int i = 0; i < twoDimensionArray.GetLength(0); i++)
            {

                for (int j = 0; j < twoDimensionArray.GetLength(1); j++)
                    Console.Write(twoDimensionArray[i, j] + " ");
                Console.WriteLine();

            }

            Console.WriteLine("case 2: --- column wise ---");
            for (int i = 0; i < twoDimensionArray.GetLength(1); i++)
            {

                for (int j = 0; j < twoDimensionArray.GetLength(0); j++)
                    Console.Write(twoDimensionArray[j, i] + " ");
                Console.WriteLine();

            }





            Console.ReadKey();

        }
    }
}
