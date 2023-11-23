using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricu_Racu
{
    public partial class Form2 : Form
    {
        private int blockSkaits;
        private int playerSkaits;
        private const int blockGar = 50;
        private const int blockAug = 50;
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

            if (blockSkaits == 10 && playerSkaits == 1)
            {
                this.Size = new Size(690, 550);

                for (int i = 0; i < blockSkaits; i++)  //for green piece line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = ((int)(65 + i * (blockGar + space)));
                    block.Location = new Point(xP, 82);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }

            if (blockSkaits == 10 && playerSkaits == 2)
            {
                this.Size = new Size(690, 550);

                for (int i = 0; i < blockSkaits; i++)  //for green piece line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = ((int)(65 + i * (blockGar + space)));
                    block.Location = new Point(xP, 47);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
                for (int i = 0; i < blockSkaits; i++) //for red piece line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = ((int)(65 + i * (blockGar + space)));
                    block.Location = new Point(xP, 138);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }

            if (blockSkaits == 20 && playerSkaits == 1)
            {
                this.Size = new Size(1230, 580);
                pictureBox2.Location = new Point(1145, 82);
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
                skipJaut.Location = new Point(455, 501);
                izm5050.Location = new Point(628, 501);

                for (int i = 0; i < blockSkaits; i++) //for green piece line
                {

                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = ((int)(65 + i * (blockGar + space)));
                    block.Location = new Point(xP, 82);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }

            if (blockSkaits == 20 && playerSkaits == 2)
            {
                this.Size = new Size(1377, 663);

                for (int i = 0; i < blockSkaits; i++) //for green piece line
                {

                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = ((int)(65 + i * (blockGar + space)));
                    block.Location = new Point(xP, 147);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
                for (int i = 0; i < blockSkaits; i++) //for red piece line
                {
                    Label block = new Label();
                    block.Size = new Size(blockGar, blockAug);
                    block.Text = $"";
                    int xP = ((int)(65 + i * (blockGar + space)));
                    block.Location = new Point(xP, 138);
                    block.BackColor = Color.Silver;
                    block.BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(block);
                }
            }
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
