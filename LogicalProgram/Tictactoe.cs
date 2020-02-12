using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Tictactoe
    {
        public static String[] board = new String[9];

        public void Tic()
        {
            //String[] board = new String[9];
            String trun = "X";
            String winner = null;
            //opulateEmptyBorad();
            Console.WriteLine("welcome to 2 player");
            Console.WriteLine("");
            PrintBord();
            Console.WriteLine("X wil play first Enter a slot number to places x in");

            int n = Convert.ToInt32(Console.ReadLine());
            while (winner == null)
            {
                if ((n > 0 && n < 9))
                {

                    board[n - 1] = trun;
                }
                    if (trun.Equals("X"))
                    {
                        trun = "0";

                    }
                    else
                    {
                        trun = "X";

                    }
                    PrintBord();
                    winner = Checkwinner();
               //

               //lse
               //
                 // Console.WriteLine("slot already taken:reenter the slot number");
                    
               //
            }
        }
        
        public static String Checkwinner()
        {
            for (int a = 0; a <= 8; a++)
            {
                String line = null;
                switch (a)
                {
                    case 0:
                        line = board[0] + board[1] + board[2];
                        break;
                    case 1:
                        line = board[3] + board[4] + board[5];
                        break;
                    case 2:
                        line = board[6] + board[7] + board[8];
                        break;
                    case 3:
                        line = board[0] + board[3] + board[6];
                        break;
                    case 4:
                        line = board[1] + board[4] + board[7];
                        break;
                    case 5:
                        line = board[2] + board[5] + board[8];
                        break;
                    case 6:
                        line = board[0] + board[4] + board[8];
                        break;
                    case 7:
                        line = board[2] + board[4] + board[6];
                        break;
                }
                if (line.Equals("XXX"))
                {
                    return "X";
                }
                else
                {
                    return "O";
                }

            }
            return null;
        }
  public    static void PrintBord()
        {
            Console.Write("---|---|---");
            Console.Write("|" + board[0] + "|" + board[1] + "|" + board[2] + "|");
            Console.Write("---|---|---");
            Console.Write("|" + board[3] + "|" + board[4] + "|" + board[5] + "|");
            Console.Write("---|---|---");
            Console.Write("|" + board[6] + "|" + board[7] + "|" + board[8] + "|");
        }
      /*static void populateEmptyBorad()
        {
            for (int a = 0; a < 9; a++)
            {
           if( board[a].Equals(board[a + 1]))
                {
                    Console.WriteLine("_");
                }
            }
        }*/
    }
}
