using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Ricu_Racu
{
    public partial class Form2 : Form
    {
        private readonly int blockSkaits;
        private readonly int playerSkaits;
        private const int blockGar = 50;
        private const int blockAug = 50;
        private Random random = new Random();
        public int[] seciba = Enumerable.Range(0, 50).ToArray();
        public int nr = 0;
        private int reizes = 0;
        private int punkti;
        private DataTable currentJautajums;
        private HashSet<long> usedQuestionIds = new HashSet<long>();


        public Form2()
        {
            InitializeComponent();
            playerSkaits = 0;
            blockSkaits = 0;
            imgTimer = new Timer();
            imgTimer.Tick += imgTimer_Tick;
            winBlock.SendToBack();
            this.FormClosed += Form2_FormClosed;
        }

        public Form2(int izvPlayerSkaits, int izvBlockSkaits) : this()
        {
            blockSkaits = izvBlockSkaits;
            playerSkaits = izvPlayerSkaits;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            double space = 4;
            var rand = new Random();
            LoadNextJautajums();

            if (blockSkaits == 10 && playerSkaits == 1)
            {
                this.Size = new Size(685, 440);
                winBlock.Location = new Point(605, 82);
                red.Location = new Point(11, 82);
                spawnRed.Location = new Point(11, 82);
                dice.Location = new Point(450, 220);
                jautajums.Location = new Point(88, 200);
                atbildeBut1.Location = new Point(65, 255);
                atbildeBut2.Location = new Point(224, 255);
                atbildeBut3.Location = new Point(146, 319);

                for (int i = 0; i < blockSkaits; i++)  //green ludo line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 82);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }
            if (blockSkaits == 20 && playerSkaits == 1)
            {
                this.Size = new Size(1225, 480);
                winBlock.Location = new Point(1145, 82);
                dice.Location = new Point(880, 233);
                jautajums.Location = new Point(480, 202);
                atbildeBut1.Location = new Point(450, 281);
                atbildeBut2.Location = new Point(621, 281);
                atbildeBut3.Location = new Point(535, 353);
                red.Location = new Point(11, 82);
                spawnRed.Location = new Point(11, 82);

                for (int i = 0; i < blockSkaits; i++) //red ludo line
                {

                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 82);
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
        protected override bool ProcessDialogKey(Keys keyData)
        {
            var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
            if (keys.Contains(keyData))
                return true;
            else
                return base.ProcessDialogKey(keyData);
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

        private void atbildeBut1_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut1.Text))
            {

            }
        }

        private void atbildeBut2_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut2.Text))
            {

            }
        }

        private void atbildeBut3_Click(object sender, EventArgs e)
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

        private void imgTimer_Tick(object sender, EventArgs e)
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
            else if (blockSkaits == 10)
            {
                if (punkti > 0 && red.Left < 685)
                {
                    imgTimer.Interval = 500;
                    red.Left = red.Left + 54;
                    punkti--;
                }
                else if (red.Left > 600)
                {
                    red.Location = new Point(605, 82);
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
                }
            }
            else if (blockSkaits == 20)
                {
                    if (punkti > 0 && red.Left < 1260)
                    {
                        imgTimer.Interval = 500;
                        red.Left = red.Left + 54;
                        punkti--;

                    }
                    else if (punkti == 0 && red.Left > 1140)
                    {
                        red.Location = new Point(1145, 82);
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
                    }

                }
            }
        private void dice_Click(object sender, EventArgs e)
        {
            imgTimer.Interval = 100;
            reizes = 0;
            imgTimer.Start();
            dice.Enabled = false;
            dice.Visible = true;
        }
        private void EnableDiceButton()
        {
            dice.Enabled = true;
        }       
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}