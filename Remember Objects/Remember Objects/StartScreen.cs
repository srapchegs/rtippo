using System;
using System.Windows.Forms;

namespace Remember_Objects
{
    public partial class StartScreen : Form
    {
        public StartScreen() => InitializeComponent();

        private void createGameButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(countPlayerTextBox.Text) && int.TryParse(countPlayerTextBox.Text, out int playerCount))
            {
                Hide();
                new AddingPlayerScreen(playerCount).ShowDialog();
            }
            else
            {
                MessageBox.Show("Введите корректные значения.");
            }
        }
    }
}
