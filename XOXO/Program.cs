using System;

namespace XOXO_DESIMAYASARI
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3,3];
            char player = 'X';
            bool gameEnd = false;
            int BoxLeft = 8;

            //inisialisasi player
            Init(board);

            while(!gameEnd){
                Console.Clear();
                printBoard(board);

                Console.Write("Input row (0-2) ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input row (0-2) : ");
                int col = Convert.ToInt32(Console.ReadLine());
                BoxLeft = BoxLeft--;
                if(BoxLeft == 0)
                {
                    gameEnd = true;
                    Console.WriteLine(" ITS A DRAW");
                }

                board[row,col] = 'X';

                //cek kondisi menang/kalah
                if(player == board[0,0] && player == board[0,1] && player == board[0,2]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }
                if(player == board[1,0] && player == board[1,1] && player == board[1,2]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }
                if(player == board[2,0] && player == board[2,1] && player == board[2,2]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }
                if(player == board[0,0] && player == board[0,1] && player == board[0,2]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }
                if(player == board[0,1] && player == board[1,1] && player == board[2,1]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }if(player == board[0,2] && player == board[1,2] && player == board[2,2]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }
                if(player == board[0,0] && player == board[1,1] && player == board[2,2]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }
                if(player == board[0,2] && player == board[1,1] && player == board[2,0]){
                    Console.WriteLine("Player "+player+" memanggi!");
                    gameEnd = true;
                    Console.Read();
                }

                if(player == 'X'){
                    player = 'O';
                }else{
                    player = 'X';
                }
            }
        }


        //print board(cara programan)
       private static void printBoard(char[,] board)
        {   
            Console.WriteLine("  | 0 | 1 | 2 |");
            for(int row = 0; row < 3; row++)
            {  
               Console.Write(row + " | ");
               for(int coloumn = 0; coloumn < 3; coloumn++)
               {
                  Console.Write(board[row,coloumn]);
                  Console.Write(" | ");
               }
               Console.WriteLine();
            }   
        }
        private static void Init(char[,] board)
        {
           for(int row = 0; row < 3; row++)
            {  
              
               for(int coloumn = 0; coloumn < 3; coloumn++)
               {
                  board[row,coloumn] = ' ';
               }
               
            }   
        }
    }
}
