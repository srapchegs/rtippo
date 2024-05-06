using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember_Objects
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Sequence { get; set; }

        public Player()
        {
            Score = 0;
            Sequence = 0;
        }

    }
}
