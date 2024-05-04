using System;
using System.Windows.Forms;

namespace Remember_Objects
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void createGameButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(countPlayerTextBox.Text) && int.TryParse(countPlayerTextBox.Text, out int playerCount))
            {
                Hide();
                new Form2(playerCount).ShowDialog();
            }
            else
            {
                MessageBox.Show("Введите корректные значения.");
            }
        }
    }
}
