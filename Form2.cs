using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ricu_Racu
{
    public partial class Form2 : Form
    {
        private readonly int blockSkaits;
        private readonly int playerSkaits;
        private const int blockGar = 50;
        private const int blockAug = 50;
        //private bool irIzm5050 = false;
        //private bool irSkipJaut = false;
        private Random random = new Random();

        public Form2()
        {
            InitializeComponent();
            playerSkaits = 0;
            blockSkaits = 0;
        }

        public Form2(int izvPlayerSkaits, int izvBlockSkaits) : this()
        {
            blockSkaits = izvBlockSkaits;
            playerSkaits = izvPlayerSkaits;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            double space = 4;
            bool atmetLIr = false;
            bool atmetKIr = false;
            Image atmetLImage = Image.FromFile("arrow right.png");
            Image atmetKImage = Image.FromFile("arrow left.png");

            if (blockSkaits == 10 && playerSkaits == 1)
            {
                this.Size = new Size(650, 550);
                green.Visible = false;
                spawnGreen.Visible = false;
                red.Location = new Point(11, 82);
                spawnRed.Location = new Point(11, 82);

                for (int i = 0; i < blockSkaits; i++)  //for green piece line
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
                if (!atmetKIr)
                {
                    PictureBox atmetK = new PictureBox
                    {
                        Size = new Size(blockGar, blockAug),
                        Image = atmetKImage,
                        BackColor = Color.Silver,
                    };
                    int yPosition = 82;  // Random position between the two lines
                    int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

                    atmetK.Location = new Point(xPosition, yPosition);

                    this.Controls.Add(atmetK);
                    atmetK.BringToFront();
                    atmetK.BorderStyle = BorderStyle.FixedSingle;
                    atmetKIr = true;
                }
            }
            if (blockSkaits == 20 && playerSkaits == 1)
            {
                this.Size = new Size(1200, 580);
                green.Location = new Point(1145, 82);
                spawnGreen.BackColor = Color.Silver;
                pictureBox1.Location = new Point(960, 283);
                jautajums.Location = new Point(480, 222);
                time.Location = new Point(780, 222);
                atbilde1.Location = new Point(495, 290);
                atbilde2.Location = new Point(666, 290);
                atbilde3.Location = new Point(495, 381);
                atbilde4.Location = new Point(666, 381);
                atbildeBut1.Location = new Point(450, 321);
                atbildeBut2.Location = new Point(621, 321);
                atbildeBut3.Location = new Point(450, 413);
                atbildeBut4.Location = new Point(621, 413);
                skipJaut.Location = new Point(455, 490);
                izm5050.Location = new Point(628, 490);
                red.Location = new Point(11, 82);
                spawnRed.Location = new Point(11, 82);
                green.Visible = false;
                spawnGreen.Visible = false;

                for (int i = 0; i < blockSkaits; i++) //for red piece line
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
                if (!atmetKIr)
                {
                    for (int i = 0; i < 3; i++) {
                        PictureBox atmetK = new PictureBox
                        {
                            Size = new Size(blockGar, blockAug),
                            Image = atmetKImage,
                            BackColor = Color.Silver,
                        };
                        int yPosition = 82;  // Random position between the two lines
                        int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

                        atmetK.Location = new Point(xPosition, yPosition);

                        this.Controls.Add(atmetK);
                        atmetK.BringToFront();
                        atmetK.BorderStyle = BorderStyle.FixedSingle;
                        atmetKIr = true;
                    }
                }
            }
            if (blockSkaits == 10 && playerSkaits == 2)
            {
                this.Size = new Size(690, 550);
                red.Location = new Point(11, 47);
                spawnRed.Location = new Point(11, 47);
                green.Location = new Point(605, 120);
                spawnGreen.Location = new Point(605, 120);


                for (int i = 0; i < blockSkaits; i++) //for green piece line
                {

                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 47);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);

                    if (!atmetLIr)
                    {
                        PictureBox atmetL = new PictureBox
                        {
                            Size = new Size(blockGar, blockAug),
                            Image = atmetLImage,
                            BackColor = Color.Silver,
                        };
                        int yPosition = 47;  // Random position between the two lines
                        int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

                        atmetL.Location = new Point(xPosition, yPosition);

                        this.Controls.Add(atmetL);
                        atmetL.BringToFront();
                        atmetL.BorderStyle = BorderStyle.FixedSingle;
                        atmetLIr = true;
                    }

                }
                for (int i = 0; i < blockSkaits; i++) //for red piece line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = (int)(65 + i * (blockGar + space));
                    block.Location = new Point(xP, 120);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);

                    if (!atmetKIr)
                    {
                        PictureBox atmetK = new PictureBox
                        {
                            Size = new Size(blockGar, blockAug),
                            Image = atmetKImage,    
                            BackColor = Color.Silver,
                        };
                        int yPosition = 120;  // Random position between the two lines
                        int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

                        atmetK.Location = new Point(xPosition, yPosition);

                        this.Controls.Add(atmetK);
                        atmetK.BringToFront();
                        atmetK.BorderStyle = BorderStyle.FixedSingle;
                        atmetKIr = true;
                    }
                }
            }
            if (blockSkaits == 20 && playerSkaits == 2)
            {
                this.Size = new Size(1235, 580);
                green.Location = new Point(1145, 82);
                spawnGreen.BackColor = Color.Silver;
                pictureBox1.Location = new Point(960, 283);
                jautajums.Location = new Point(480, 222);
                time.Location = new Point(780, 222);
                atbilde1.Location = new Point(495, 290);
                atbilde2.Location = new Point(666, 290);
                atbilde3.Location = new Point(495, 381);
                atbilde4.Location = new Point(666, 381);
                atbildeBut1.Location = new Point(450, 321);
                atbildeBut2.Location = new Point(621, 321);
                atbildeBut3.Location = new Point(450, 413);
                atbildeBut4.Location = new Point(621, 413);
                skipJaut.Location = new Point(455, 490);
                izm5050.Location = new Point(628, 490);
                spawnGreen.Visible = false;
                red.Location = new Point(11, 47);
                spawnRed.Location = new Point(11, 47);
                green.Location = new Point(1145, 120);
                spawnGreen.Location = new Point(1145, 120);

                for (int i = 0; i < blockSkaits; i++)  //for green piece line
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
                if (!atmetLIr)
                {
                    PictureBox atmetL = new PictureBox
                    {
                        Size = new Size(blockGar, blockAug),
                        Image = atmetLImage,
                        BackColor = Color.Silver,
                    };
                    int yPosition = 47;  // Random position between the two lines
                    int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

                    atmetL.Location = new Point(xPosition, yPosition);

                    this.Controls.Add(atmetL);
                    atmetL.BringToFront();
                    atmetL.BorderStyle = BorderStyle.FixedSingle;
                    atmetLIr = true;
                }

                for (int i = 0; i < blockSkaits; i++) //for red piece line
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
                if (!atmetKIr)
                {
                    PictureBox atmetK = new PictureBox
                    {
                        Size = new Size(blockGar, blockAug),
                        Image = atmetKImage,
                        BackColor = Color.Silver,
                    };
                    int yPosition = 120;  // Random position between the two lines
                    int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

                    atmetK.Location = new Point(xPosition, yPosition);

                    this.Controls.Add(atmetK);
                    atmetK.BringToFront();
                    atmetK.BorderStyle = BorderStyle.FixedSingle;
                    atmetKIr = true;
                }
            }

        }
        private void SpawnPowerUp()
        {
            Image atmetImage = Image.FromFile("question.png");
            double space = 4;

            PictureBox powerUp = new PictureBox
            {
                Size = new Size(blockGar, blockAug),
                Image = atmetImage,
                BackColor = Color.Silver,
            };
            int yPosition = 47;  // Random position between the two lines
            int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));  // Random block on x-axis

            powerUp.Location = new Point(xPosition, yPosition);

            this.Controls.Add(powerUp);
            powerUp.BringToFront();
        }

        private void jautajums_Click(object sender, EventArgs e)
        {

        }

        private void atbilde2_Click(object sender, EventArgs e)
        {

        }

        private void atbildeBut1_Click(object sender, EventArgs e)
        {
            
        }

        private void atbildeBut2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void izm5050_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 beigas = new Form3();
            beigas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
