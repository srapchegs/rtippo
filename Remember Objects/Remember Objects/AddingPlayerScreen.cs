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
    public partial class AddingPlayerScreen : Form
    {
        private int playerCount;
        public AddingPlayerScreen(int playerCount)
        {
            InitializeComponent();
            this.playerCount = playerCount;
            InitializePlayerTextBoxes();
        }

        private void InitializePlayerTextBoxes()
        {
            int count = 1;
            for (int i = 0; i < playerCount; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + i.ToString();
                count = count * 2;
                textBox.Location = new System.Drawing.Point(500, 100 + count * 30);
                textBox.Size = new System.Drawing.Size(300, 40);
                textBox.Font = new System.Drawing.Font("Candara", 25.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                textBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
                Controls.Add(textBox);
                count = count / 2;
                count++;
            }
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            HashSet<string> names = new HashSet<string>();
            bool hasError = false;

            for (int i = 0; i < playerCount; i++)
            {
                TextBox textBox = Controls["textBox" + i.ToString()] as TextBox;
                if (textBox != null)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                        break;
                    }

                    if (!names.Add(textBox.Text))
                    {
                        MessageBox.Show("Имена игроков должны быть уникальными.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                        break;
                    }
                }
            }

            if (!hasError)
            {
                for (int i = 0; i < playerCount; i++)
                {
                    TextBox textBox = Controls["textBox" + i.ToString()] as TextBox;
                    if (textBox != null)
                    {
                        Player player = new Player { Name = textBox.Text };
                        Game.Instance.AddPlayer(player);
                    }
                }

                this.Hide();
                SetSequenceScreen form3 = new SetSequenceScreen();
                form3.ShowDialog();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {}
    }
}
