using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Timers;

namespace Remember_Objects
{
    public partial class Form6 : Form
    {
        private int currentPlayerIndex;
        private int buttonClickCount = 0;

        public Form6()
        {
            InitializeComponent();
            currentPlayerIndex = 0;
            DisplayPlayerInfo();
            DisplayItems();
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedItemsCount = checkedListBox1.CheckedItems.Count;
            if (selectedItemsCount >= Game.Instance.SelectedItemsTable.Count && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void switchPlayerButton_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            List<string> selectedItems = new List<string>();
            foreach (var index in checkedListBox1.CheckedIndices)
            {
                selectedItems.Add(checkedListBox1.Items[(int)index].ToString());
            }
            Player currentPlayer = Game.Instance.Players[currentPlayerIndex];
            Game.Instance.MakeMove(currentPlayer, selectedItems);
            currentPlayerIndex = (currentPlayerIndex + 1) % Game.Instance.Players.Count;
            if (Game.Instance.Players.Count == buttonClickCount)
            {
                switchPlayerButton.Enabled = false;
                List <Player> winners = Game.Instance.ChooseWinners();
                this.Hide();
                Form7 form7 = new Form7();
                form7.Show();
            }
            DisplayPlayerInfo();
            DisplayItems();
        }


        private void DisplayPlayerInfo()
        {
            Player currentPlayer = Game.Instance.Players[currentPlayerIndex];
            playerLabel.Text = "Ходит: " + currentPlayer.Name;
        }

        private void DisplayItems()
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(Game.Instance.AllItems.ToArray());
        }
    }
}
