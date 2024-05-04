using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Remember_Objects
{
    public partial class Form5 : Form
    {
        private int timerSeconds;
        private Round round;

        public Form5(Round round)
        {
            InitializeComponent();
            this.round = round;

            timerSeconds = Game.Instance.TimerSeconds;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += TimerUI_Tick;
            timer.Start();
            Item item = new Item();
            DisplaySelectedItems();
        }
        private void DisplaySelectedItems()
        {
            int i = 2;
            foreach (string item in Game.Instance.SelectedItemsTable)
            {
                string imagePath = "C:\\Users\\sraperanosan\\source\\repos\\Remember Objects\\Remember Objects\\items\\" + item + ".png";
                PictureBox pictureBox = Controls.Find("pictureBox" + (i), true).FirstOrDefault() as PictureBox;
                pictureBox.Image = Image.FromFile(imagePath);
                i++;
            }
        }

        private void TimerUI_Tick(object sender, EventArgs e)
        {
            timerSeconds--;
            label1.Text = TimeSpan.FromSeconds(timerSeconds).ToString(@"mm\:ss");

            if (timerSeconds <= 0)
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                this.Hide();
                Form6 form6 = new Form6();
                form6.Show();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {

        }
    }
}
