using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literki
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                timer1.Stop();
                string result = "Twój wynik:\n" + correctLabel.Text + "\n" + missedLabel.Text + "\n" + accuracyLabel.Text + "\n\nCzy chcesz zagrać ponownie?";
                var yesno = MessageBox.Show(result, "Koniec gry!", MessageBoxButtons.YesNo);

                if (yesno == DialogResult.Yes)
                {
                    timer1.Interval = 800;
                    timer1.Start();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (timer1.Interval > 400) timer1.Interval -= 10;
                if (timer1.Interval > 250) timer1.Interval -= 7;
                if (timer1.Interval > 100) timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            correctLabel.Text = "Prawidłowych: " + stats.correct;
            missedLabel.Text = "Błędów: " + stats.missed;
            totalLabel.Text = "Wszystkich: "+ stats.total;
            accuracyLabel.Text = "Dokładność: " + stats.accuracy + "%";
        }
    }
}
