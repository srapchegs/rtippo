using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember_Objects
{
    public partial class Form3 : Form
    {
        private int currentPlayerIndex;
        private List<int> generatedNumbers;

        public Form3()
        {
            InitializeComponent();
            currentPlayerIndex = 0;
            generatedNumbers = new List<int>();
            dataGridView1.Rows.Clear();
            foreach (Player player in Game.Instance.Players)
            {
                dataGridView1.Rows.Add(player.Name, player.Sequence);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, Game.Instance.Players.Count + 1);
            } while (generatedNumbers.Contains(randomNumber));

            generatedNumbers.Add(randomNumber);

            Game.Instance.Players[currentPlayerIndex].Sequence = randomNumber;

            dataGridView1.Rows[currentPlayerIndex].Cells["SequenceColumn"].Value = randomNumber;

            currentPlayerIndex++;

            if (currentPlayerIndex >= Game.Instance.Players.Count)
            {
                currentPlayerIndex = 0;
                generatedNumbers.Clear();
            }
            CheckHideRandomButton();

        }
        private void CheckHideRandomButton()
        {
            int playersWithoutSequence = 0;
            foreach (Player player in Game.Instance.Players)
            {
                if (player.Sequence == 0)
                {
                    playersWithoutSequence++;
                }
            }

            if (playersWithoutSequence == 0)
            {
                randomButton.Visible = false;
                continueButton.Visible = true;

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                string playerName = dataGridView1.Rows[i].Cells["NameColumn"].Value.ToString();
                int sequence = Convert.ToInt32(dataGridView1.Rows[i].Cells["SequenceColumn"].Value);

                Player player = Game.Instance.Players.Find(p => p.Name == playerName);

                player.Sequence = sequence;
            }
            List<Player> sortedPlayers = Game.Instance.Players.OrderBy(p => p.Sequence).ToList();

            dataGridView1.Rows.Clear();

            foreach (Player player in sortedPlayers)
            {
                dataGridView1.Rows.Add(player.Name, player.Sequence);
            }
            Game.Instance.Players.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string name = row.Cells["NameColumn"].Value?.ToString();
                int sequence = Convert.ToInt32(row.Cells["SequenceColumn"].Value);
                Player player = new Player { Name = name, Sequence = sequence };
                Game.Instance.Players.Add(player);
            }
            Game.Instance.Players.RemoveAll(p => p.Sequence == 0);
            MessageBox.Show("Очередь расставлена");
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
