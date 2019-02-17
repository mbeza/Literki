using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Literki
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        bool isGame = false;
        public Form1()
        {
            InitializeComponent();
            numericInterval.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                timer1.Stop();

                string level = infoLabel.Text;
                infoLabel.Text = "KONIEC GRY!\n\nTwój wynik:" + level + "\nInterwał:" + timer1.Interval + "ms";
                isGame = false;
                startButton.Enabled = true;
                gameRB.Enabled = true;
                trainingRB.Enabled = true;

                if(gameRB.Checked) numericInterval.Enabled = false;
                else numericInterval.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGame)
            {
                if (listBox1.Items.Contains(e.KeyCode))
                {
                    listBox1.Items.Remove(e.KeyCode);
                    listBox1.Refresh();

                    if (gameRB.Checked)
                    {
                        if (timer1.Interval > 400) timer1.Interval -= 20;
                        else
                        {
                            if (timer1.Interval > 260) timer1.Interval -= 10;
                            else
                            {
                                if (timer1.Interval > 100) timer1.Interval -= 2;
                            }

                        }
                        Levels();
                    }

                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }

                UpdateStats();

            }
        }

        private void Counting()
        {
            infoLabel.Text = "\n\n3...";
            Application.DoEvents();
            Thread.Sleep(700);
            infoLabel.Text = "\n\n2...";
            Application.DoEvents();
            Thread.Sleep(700);
            infoLabel.Text = "\n\n1...";
            Application.DoEvents();
            Thread.Sleep(700);
            infoLabel.Text = "\n\nSTART!";
            Application.DoEvents();
            Thread.Sleep(500);
            if (trainingRB.Checked) infoLabel.Text = "\n\nTrening " + numericInterval.Value + "ms";
            else infoLabel.Text = "\n\nPoziom 1.";
            Application.DoEvents();

        }

        private void Levels()
        {
            switch (timer1.Interval)
            {

                case 700:
                    infoLabel.Text = "\n\nPoziom 2.";
                    break;
                case 600:
                    infoLabel.Text = "\n\nPoziom 3.";
                    break;
                case 500:
                    infoLabel.Text = "\n\nPoziom 4.";
                    break;
                case 400:
                    infoLabel.Text = "\n\nPoziom 5.";
                    break;
                case 350:
                    infoLabel.Text = "\n\nPoziom 6.";
                    break;
                case 300:
                    infoLabel.Text = "\n\nPoziom 7.";
                    break;
                case 250:
                    infoLabel.Text = "\n\nPoziom 8.";
                    break;
                case 200:
                    infoLabel.Text = "\n\nPoziom 9.";
                    break;
                case 150:
                    infoLabel.Text = "\n\nPoziom 10.";
                    break;
                case 130:
                    infoLabel.Text = "\n\nPoziom 11.";
                    break;
                case 110:
                    infoLabel.Text = "\n\nPoziom 12.";
                    break;
                case 90:
                    infoLabel.Text = "\n\nPoziom 13.";
                    break;
                case 70:
                    infoLabel.Text = "\n\nPoziom 14.";
                    break;
                case 50:
                    infoLabel.Text = "\n\nPoziom 15.";
                    break;

            }
        }

        private void UpdateStats()
        {
            difficultyProgressBar.Value = stats.accuracy;
            correctLabel.Text = "Prawidłowych: " + stats.correct;
            missedLabel.Text = "Błędów: " + stats.missed;
            totalLabel.Text = "Wszystkich: " + stats.total;
            accuracyLabel.Text = "Dokładność: " + stats.accuracy + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            if (trainingRB.Checked)
            {
                timer1.Interval = (int)numericInterval.Value;
            }
            else
            {
                timer1.Interval = 800;
            }
            stats.Default();
            UpdateStats();

            numericInterval.Enabled = false;
            gameRB.Enabled = false;
            trainingRB.Enabled = false;

            Counting();
            isGame = true;

            timer1.Start();

        }

        private void trainingRB_CheckedChanged(object sender, EventArgs e)
        {
            numericInterval.Enabled = true;
        }

        private void gameRB_CheckedChanged(object sender, EventArgs e)
        {
            numericInterval.Enabled = false;
        }
    }
}
