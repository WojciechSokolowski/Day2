using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TTT game = new TTT();
            game.Game();

            Console.ReadKey();
        }
    }
}
