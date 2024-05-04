using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember_Objects
{
    public class Round
    {
        public int RoundNumber { get; set; }
        public string WinnerOfRound { get; set; }
        public List<Move> Moves { get; set; }
        public List<Player> Players { get; set; }

        public Round(int roundNumber, string winnerOfRound)
        {
            RoundNumber = roundNumber;
            Moves = new List<Move>();
            Players = new List<Player>();
            WinnerOfRound = winnerOfRound;
        }

        public void AddMove(Move move)
        {
            Moves.Add(move);
        }
       
    }
}
