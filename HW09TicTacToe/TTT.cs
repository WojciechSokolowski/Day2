using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09TicTacToe
{
    internal class TTT
    {
        private char[,] board;
        private char currentPlayer;
        private bool gameEnded;

        public TTT()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            gameEnded = false;

            InitializeBoard();
        }

        public void Game()
        {
            while (!gameEnded)
            {
                DisplayBoard();
                HandlePlayerMove();
                CheckGameStatus();
                SwitchPlayers();

            }
        }


        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine("   0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        private void HandlePlayerMove()
        {
            bool validMove = false;
            int i, j;
            Console.WriteLine($"Player {currentPlayer}'s turn");

            do
            {
                Console.WriteLine("Enter row 0-2");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter column 0-2");
                j = Convert.ToInt32(Console.ReadLine());

                if (i >= 0 && j >= 0 && i < 3 && j < 3 && board[i, j] == '-')
                {
                    board[i, j] = currentPlayer;
                    validMove = true;
                }
                else
                    Console.WriteLine("invalid move, try again");
            }
            while (!validMove);
        }

        private void CheckGameStatus()
        {
            if (CheckForWin())
            {
                DisplayBoard();
                Console.WriteLine($"Player {currentPlayer} won");
                gameEnded = true;
            }
            else if (CheckForDraw())
            {
                DisplayBoard();
                Console.WriteLine("It's a draw");
                gameEnded = true;
            }
        }

        private bool CheckForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == currentPlayer) && (board[i, 1] == currentPlayer) && (board[i, 2] == currentPlayer))
                    return true;
                if ((board[0, i] == currentPlayer) && (board[1, i] == currentPlayer) && (board[2, i] == currentPlayer))
                    return true;
            }
            if ((board[0, 0] == currentPlayer) && (board[1, 1] == currentPlayer) && (board[2, 2] == currentPlayer))
                return true;
            if ((board[0, 2] == currentPlayer) && (board[1, 1] == currentPlayer) && (board[2, 0] == currentPlayer))
                return true;
            return false; 

        }

        private bool CheckForDraw()
        {
            for(int i = 0; i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                        return false;
                }
            }
            return true;
        }

        private void SwitchPlayers ()
        {
            if (currentPlayer == 'X')
                currentPlayer = 'O';
            else
                currentPlayer = 'X';
        }




    }


}
