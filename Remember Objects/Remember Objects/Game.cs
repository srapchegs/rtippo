using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Remember_Objects
{
    public class Game
    {
        private static Game instance;
        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }

        public int TimerSeconds { get; set; }
        public List<Player> Players { get; set; }
        public List<Round> Rounds { get; set; }
        public List<Move> Moves { get; set; }
        public List<string> AllItems { get; }
        public List<string> SelectedItemsTable { get; set; }
        private Game()
        {
            Players = new List<Player>();
            Rounds = new List<Round>();
            AllItems = new Item().Items;
            Moves = new List<Move>();
            SelectedItemsTable = new List<string>();
        }
        public void StartNewRound()
        {
            SelectRandomItems();
            Moves.Clear();
            int roundNumber = this.Rounds.LastOrDefault()?.RoundNumber ?? 1;
            Round round = new Round(roundNumber++, "");
            Rounds.Add(round);
            round.Players.AddRange(this.Players);
            ItemScreen form5 = new ItemScreen(round);
            form5.Show();
        }
        public void SelectRandomItems()
        {
            Random random = new Random();
            SelectedItemsTable = AllItems.OrderBy(x => random.Next()).Take(20).ToList();
        }

        public void MakeMove(Player player, List<string> selectedItems)
        {
            Moves.Add(new Move(player, selectedItems));
            player.Sequence++;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public List<Player> ChooseWinners()
        {
            Dictionary<Player, int> playerMatches = new Dictionary<Player, int>();

            foreach (Player player in Players)
            {
                playerMatches.Add(player, 0);
            }
            int maxMatches = 0;
            foreach (Move move in Moves)
            {
                int matches = move.SelectedItemsPlayer.Count(selectedItem => SelectedItemsTable.Contains(selectedItem));
                playerMatches[move.Player] += matches;
                if (matches > maxMatches)
                {
                    maxMatches = matches;
                }
            }
            List<Player> winners = playerMatches.Where(x => x.Value == maxMatches).Select(x => x.Key).ToList();
            if (winners.Count > 1)
            {
                Round lastRound = Rounds.LastOrDefault();
                foreach (Player winner in winners)
                {
                    winner.Score++;
                    lastRound.WinnerOfRound += winner.Name + ", ";
                }
            }
            else
            {
                winners[0].Score++;
                Round lastRound = Rounds.LastOrDefault();
                lastRound.WinnerOfRound = winners[0].Name;
            }
            return winners;
        }

        public List<Player> ChooseWinnerOfAllRounds()
        {
            Dictionary<Player, int> playerScores = new Dictionary<Player, int>();

            foreach (Player player in Players)
            {
                playerScores.Add(player, 0);
            }
            foreach (Round round in Rounds)
            {
                foreach (Player player in round.Players)
                {
                    playerScores[player] += player.Score;
                }
            }
            int maxScore = playerScores.Max(x => x.Value);
            List<Player> winners = playerScores.Where(x => x.Value == maxScore).Select(x => x.Key).ToList();
            return winners;
        }

    }
}
