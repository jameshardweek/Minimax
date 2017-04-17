using System;
using System.Collections.Generic;

namespace Minimax
{
    class Program
    {
        static void Main()
        {
            
        }
    }

    class Player
    {
        public char counter;
        public char opponentCounter;

        public bool Win(char[] Board, char counter)
        {
            if (
                (Board[0] == counter && Board[1] == counter && Board[2] == counter) ||
                (Board[3] == counter && Board[4] == counter && Board[5] == counter) ||
                (Board[6] == counter && Board[7] == counter && Board[8] == counter) ||
                (Board[0] == counter && Board[3] == counter && Board[6] == counter) ||
                (Board[1] == counter && Board[4] == counter && Board[7] == counter) ||
                (Board[2] == counter && Board[5] == counter && Board[8] == counter) ||
                (Board[0] == counter && Board[4] == counter && Board[8] == counter) ||
                (Board[2] == counter && Board[4] == counter && Board[6] == counter)
            )
                return true;
            else
                return false;
        }

    }

    class AIPlayer : Player
    {
        public int Minimax(char[] Board, char counter)
        {
            int[] availableMoves = getAvailableMoves(Board);
            if (Win(Board, this.counter))
                return 10;
            else if (Win(Board, this.opponentCounter))
                return -10;
            else if (availableMoves.Length == 0)
                return 0;
            List<int> moves = new List<int>();
            for (int i = 0; i < availableMoves.Length; i++)
            {
                
            }
        }

        public int[] getAvailableMoves(char[] Board)
        {
            List<int> moves = new List<int>();
            for (int i = 0; i < 9; i++)
                if (Board[i] == '-')
                    moves.Add(i);
            return moves.ToArray();
        }
    }

    class HumanPlayer : Player
    {
        
    }
}
