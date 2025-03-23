using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Ricu_Racu
{
    public partial class Form3 : Form
    {
        private readonly int blockSkaits;
        private readonly int playerSkaits;
        private const int blockGar = 50;
        private const int blockAug = 50;
        private Random random = new Random();
        public int[] seciba = Enumerable.Range(0, 50).ToArray();
        public int nr = 0;
        private int reizes = 0;
        private int speletajs = 1;
        private int punkti;
        private DataTable currentJautajums;
        private HashSet<long> usedQuestionIds = new HashSet<long>();
        public Form3()
        {
            InitializeComponent();
            playerSkaits = 0;
            blockSkaits = 0;
            imgTimer = new Timer();
            imgTimer.Tick += imgTimer_Tick_1;
            winBlock.SendToBack();
            winBlock2.SendToBack();
            red.BringToFront();
            green.BringToFront();
            this.FormClosed += Form3_FormClosed;
        }

        public Form3(int izvPlayerSkaits, int izvBlockSkaits) : this()
        {
            blockSkaits = izvBlockSkaits;
            playerSkaits = izvPlayerSkaits;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            double space = 4;
            var rand = new Random();
            LoadNextJautajums();

            if (blockSkaits == 10 && playerSkaits == 2)
            {
                this.Size = new Size(690, 470);
                winBlock.Location = new Point(605, 47);
                winBlock2.Location = new Point(11, 120);
                red.Location = new Point(11, 47);
                spawnRed.Location = new Point(11, 47);
                green.Location = new Point(605, 120);
                spawnGreen.Location = new Point(605, 120);
                dice.Location = new Point(450, 240);


                for (int i = 0; i < blockSkaits; i++)  //green ludo line
                {

                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 47);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);

                }
                for (int i = 0; i < blockSkaits; i++)  //red ludo line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 120);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }

            if (blockSkaits == 20 && playerSkaits == 2)
            {
                this.Size = new Size(1235, 500);
                winBlock.Location = new Point(1145, 47);
                winBlock2.Location = new Point(11, 120);
                green.Location = new Point(1145, 82);
                dice.Location = new Point(880, 263);
                jautajums.Location = new Point(480, 232);
                atbildeBut1.Location = new Point(450, 301);
                atbildeBut2.Location = new Point(621, 301);
                atbildeBut3.Location = new Point(535, 373);
                spawnGreen.Visible = true;
                red.Location = new Point(11, 47);
                spawnRed.Location = new Point(11, 47);
                green.Location = new Point(1145, 120);
                spawnGreen.Location = new Point(1145, 120);

                for (int i = 0; i < blockSkaits; i++)  //green ludo line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 47);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }

                    for (int i = 0; i < blockSkaits; i++)  //red ludo line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 120);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }
        }
        private void LoadNextJautajums()
        {
            do
            {
                currentJautajums = DatabaseManager.GetRandomJautajums();
            } while (usedQuestionIds.Contains((long)currentJautajums.Rows[0]["JautajumiId"]) && usedQuestionIds.Count < 50);

            if (currentJautajums.Rows.Count > 0)
            {
                long questionId = (long)currentJautajums.Rows[0]["JautajumiId"];
                usedQuestionIds.Add(questionId);

                jautajums.Text = currentJautajums.Rows[0]["JautajumiText"].ToString();
                atbildeBut1.Text = currentJautajums.Rows[0]["AtbildesText"].ToString();
                atbildeBut2.Text = currentJautajums.Rows[1]["AtbildesText"].ToString();
                atbildeBut3.Text = currentJautajums.Rows[2]["AtbildesText"].ToString();
            }
        }
        private void JauktPogas()
        {
            var rand = new Random();

            Point originalPosition1 = atbildeBut1.Location;
            Point originalPosition2 = atbildeBut2.Location;
            Point originalPosition3 = atbildeBut3.Location;

            Point[] positions = { originalPosition1, originalPosition2, originalPosition3 };
            positions = positions.OrderBy(x => rand.Next()).ToArray();

            atbildeBut1.Location = positions[0];
            atbildeBut2.Location = positions[1];
            atbildeBut3.Location = positions[2];
        }

        private void NakJaut()
        {
            LoadNextJautajums();
            JauktPogas();
            EnableDiceButton();
        }

        private void atbildeBut1_Click_1(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut1.Text))
            {

            }
        }
        private void atbildeBut2_Click_1(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut2.Text))
            {

            }
        }
        private void atbildeBut3_Click_1(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut3.Text))
            {

            }
        }
        private bool ParbAtbild(string izvAtb)
        {
            if (dice.Visible == false)
            {
                foreach (DataRow row in currentJautajums.Rows)
                {
                    if (row["AtbildesText"].ToString() == izvAtb && Convert.ToBoolean(row["IsCorrect"]))
                    {
                        MessageBox.Show("Pareiza atbilde! Tagad vari mest kauliņu uzspiežot uz tā");
                        dice.Visible = true;
                        return true;
                    }
                }
                MessageBox.Show("Nepareiza atbilde! Mēģini vēlreiz");
                return false;
            }
            return false;
        }

        private void imgTimer_Tick_1(object sender, EventArgs e)
        {
            if (reizes < 10)
            {
                punkti = random.Next(6) + 1;
                switch (punkti)
                {
                    case 1: dice.Image = Properties.Resources.dice1; break;
                    case 2: dice.Image = Properties.Resources.dice2; break;
                    case 3: dice.Image = Properties.Resources.dice3; break;
                    case 4: dice.Image = Properties.Resources.dice4; break;
                    case 5: dice.Image = Properties.Resources.dice5; break;
                    case 6: dice.Image = Properties.Resources.dice6; break;
                }
                reizes++;
            }
            else if (speletajs == 1 && blockSkaits == 10)
            {
                if (punkti > 0 && red.Left < 690)
                {
                    imgTimer.Interval = 500;
                    red.Left = red.Left + 54;
                    punkti--;
                }
                else if (punkti > 0 && red.Left > 600)
                {
                    red.Left = red.Left - 54;
                    punkti--;
                }
                else if (punkti == 0 && red.Left > 600)
                {
                    red.Location = new Point(605, 47);
                    imgTimer.Stop();
                    PictureBox winner = red;
                    this.Hide();
                    Form4 beigas = new Form4(winner.Name);
                    beigas.Show();
                    return;
                }
                else
                {
                    imgTimer.Stop();
                    NakJaut();
                    dice.Visible = false;
                    speletajs = 2;
                }
            }
            else if (speletajs == 2 && blockSkaits == 10)
            {
                if (punkti > 0 && green.Left > 1)
                {
                    imgTimer.Interval = 500;
                    green.Left = green.Left - 54;
                    punkti--;
                }
                else if (punkti > 0 && green.Left < 1)
                {
                    green.Left = green.Left + 54;
                    punkti--;
                }
                else if (punkti == 0 && green.Left < 6 || green.Left == 11)
                {
                    green.Location = new Point(11, 120);
                    imgTimer.Stop();
                    PictureBox winner = green;
                    this.Hide();
                    Form4 beigas = new Form4(winner.Name);
                    beigas.Show();
                    return;
                }
                else
                {
                    imgTimer.Stop();
                    NakJaut();
                    dice.Visible = false;
                    speletajs = 1;
                }
            }
            else if (speletajs == 1 && blockSkaits == 20)
            {
                if (punkti > 0 && red.Left < 1260)
                {
                    imgTimer.Interval = 500;
                    red.Left = red.Left + 54;
                    punkti--;
                }
                else if (punkti > 0 && red.Left > 1145)
                {
                    red.Left = red.Left - 54;
                    punkti--;
                }
                else if (punkti == 0 && red.Left > 1140)
                {
                    red.Location = new Point(1145, 47);
                    imgTimer.Stop();
                    PictureBox winner = red;
                    this.Hide();
                    Form4 beigas = new Form4(winner.Name);
                    beigas.Show();
                    return;
                }
                else
                {
                    imgTimer.Stop();
                    NakJaut();
                    dice.Visible = false;
                    speletajs = 2;
                }
            }
            else if (speletajs == 2 && blockSkaits == 20)
            {
                if (punkti > 0 && green.Left > 1)
                {
                    imgTimer.Interval = 500;
                    green.Left = green.Left - 54;
                    punkti--;
                }
                else if (punkti > 0 && green.Left < 1)
                {
                    green.Left = green.Left + 54;
                    punkti--;
                }
                else if (punkti == 0 && green.Left < 6 || green.Left == 11)
                {
                    green.Location = new Point(11, 120);
                    imgTimer.Stop();
                    PictureBox winner = green;
                    this.Hide();
                    Form4 beigas = new Form4(winner.Name);
                    beigas.Show();
                    return;
                }
                else
                {
                    imgTimer.Stop();
                    NakJaut();
                    dice.Visible = false;
                    speletajs = 1;
                }
            }
        }
        private void dice_Click_1(object sender, EventArgs e)
        {
            imgTimer.Interval = 100;
            reizes = 0;
            imgTimer.Start();
            dice.Enabled = false;
            dice.Visible = true;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
            if (keys.Contains(keyData))
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }

        private void EnableDiceButton()
        {
            dice.Enabled = true;
        }
        
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}