using System;
using System.Collections.Generic;
using System.Text;

namespace PAT.Lab
{
    public class Utils
    {
        public static bool firstWinSecond(int p1, int p2, int[] position, int[] board) {
            int player1Sum = position[1];
            int player2Sum = position[3];
            for (int i = 0; i < board.Length; i += 4) {
                if (board[i] == p1) {
                    player1Sum += board[i + 1];
                } else if (board[i] == p2) {
                    player2Sum += board[i + 1];
                }
            }

        }
        
    }
}
