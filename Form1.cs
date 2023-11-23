using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricu_Racu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fons.SendToBack();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void onePlay_Click(object sender, EventArgs e)
        {
            if (choose2.Visible == true)
            {
                choose1.Visible = false;
            }

            if (but10t.Visible == true)
            {
                but10.Visible = false;
            }

            if (but20t.Visible == true)
            {
                but20.Visible = false;
            }

            if (but40t.Visible == true)
            {
                but40.Visible = false;
            }

            if (but50t.Visible == true)
            {
                but50.Visible = false;
            }

            if (fons2.Visible == true)
            {
                fons.Visible = false;
            }

            else
            {
                choose1.Visible = true;
                but10.Visible = true;
                but20.Visible = true;
                but40.Visible = true;
                but50.Visible = true;
                fons.Visible = true;
            }
        }

        private void twoPlay_Click(object sender, EventArgs e)
        {
            if (choose1.Visible == true)
            {
                choose2.Visible = false;
            }

            if (but10.Visible == true)
            {
                but10t.Visible = false;
            }

            if (but20.Visible == true)
            {
                but20t.Visible = false;
            }

            if (but40.Visible == true)
            {
                but40t.Visible = false;
            }

            if (but50.Visible == true)
            {
                but50t.Visible = false;
            }

            if (fons.Visible == true)
            {
                fons2.Visible = false;
            }

            else
            {
                choose2.Visible = true;
                but10t.Visible = true;
                but20t.Visible = true;
                but40t.Visible = true;
                but50t.Visible = true;
                fons2.Visible = true;
            }
        }

        private void choose1_Click(object sender, EventArgs e)
        {

        }

        private void but10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2();
            spele.Show();
        }

        private void but20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2();
            spele.Show();
        }

        private void but40_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2();
            spele.Show();
        }

        private void but50_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2();
            spele.Show();
        }

        private void but10t_Click(object sender, EventArgs e)
        {

        }

        private void but20t_Click(object sender, EventArgs e)
        {

        }

        private void but40t_Click(object sender, EventArgs e)
        {

        }

        private void but50t_Click(object sender, EventArgs e)
        {

        }

        private void fons_Click(object sender, EventArgs e)
        {

        }
    }
}
