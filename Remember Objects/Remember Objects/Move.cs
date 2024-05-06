using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember_Objects
{
    public class Move
    {
        public Player Player { get; set; }
        public List<string> SelectedItemsPlayer { get; set; }

        public Move(Player player, List<string> selectedItemsPlayer)
        {
            Player = player;
            SelectedItemsPlayer = selectedItemsPlayer;
        }
    }
}
