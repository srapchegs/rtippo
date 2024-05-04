using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Remember_Objects
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
            List<Player> winnersGame = Game.Instance.ChooseWinnerOfAllRounds();
            if (winnersGame.Count > 1)
            {
                string s = "Победители игры: ";
                foreach (Player winner in winnersGame)
                {
                    s = s + winner.Name + ",";
                }
                textBox2.Text = s.Remove(s.Length - 1);
            }
            else
            {
                textBox2.Text = "Победитель игры: " + winnersGame[0].Name;
            }

            if (Game.Instance.Rounds.LastOrDefault().WinnerOfRound.ToString().Contains(","))
            {
                textBox1.Text = "Победители раунда: " + Game.Instance.Rounds.LastOrDefault().WinnerOfRound.ToString().Remove(Game.Instance.Rounds.LastOrDefault().WinnerOfRound.ToString().Length - 2);
            }
            else
            {
                textBox1.Text = "Победитель раунда: " + Game.Instance.Rounds.LastOrDefault().WinnerOfRound.ToString();
            }

            foreach (Player player in Game.Instance.Players)
            {
                dataGridView1.Rows.Add(player.Name, player.Score);
            }
        }

        private void startNewRoundBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game.Instance.StartNewRound();
        }

        private void CloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showMoves_Click(object sender, EventArgs e)
        {

        }
    }
}
