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
        private const int blockGar = 50; // Set your desired width
        private const int blockAug = 50; // Set your desired height
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int izvBlockSkaits) : this()
        {
            blockSkaits = izvBlockSkaits;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            double space = 4;

            for (int i = 0; i < blockSkaits; i++)
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
