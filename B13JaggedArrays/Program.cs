using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B13JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "http://tomaszles.pl/wp-content/uploads/2023/05/volleyball_players.csv";

            WebClient wc = new WebClient();

            string data = wc.DownloadString(path);

            string[] separator = new string[1] { "\r\n" };
            string[] rows = data.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int numberOfRows = rows.Length;
            //int numberOfColumns = rows[0].Split(';');


            string[][] Table = new string[numberOfRows][];

            for( int i = 0; i < numberOfRows; i++)
                Table[i] = rows[i].Split(';');


            //foreach (var row in Table)
            //    Console.WriteLine(string.Join(" ", row);

            foreach (var row in Table) 
            {
                foreach (var cell in row)
                    Console.Write(cell + " ");
                Console.WriteLine();
            }

            //TODO HOMEWORK import as 2D 


            Console.ReadKey();

        }
    }
}
