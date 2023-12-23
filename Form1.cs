using System;
using System.Windows.Forms;

namespace Ricu_Racu
{
    public partial class Form1 : Form
    {
        private bool menuVisible = false;
        public Form1()
        {
            InitializeComponent();
            fons.SendToBack();
            fons2.SendToBack();
        }

        int playerSkaits;

        private void onePlay_Click(object sender, EventArgs e)
        {
            playerSkaits = 1;
            if (menuVisible == false)
            {
                ShowMenu();
            }
            else
            {
                HideMenu();
            }
        }

        private void twoPlay_Click(object sender, EventArgs e)
        {
            playerSkaits = 2;

            if (menuVisible == false)
            {
                ShowMenu2();
            }
            else
            {
                HideMenu2();
            }
        }

        private void but10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2(playerSkaits, 10);
            spele.Show();
        }

        private void but20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spele = new Form2(playerSkaits, 20);
            spele.Show();
        }

        private void but10t_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form3 spele = new Form3(playerSkaits, 10);
                spele.Show();
        }

        private void but20t_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 spele = new Form3(playerSkaits, 20);
            spele.Show();
        }

        private void ShowMenu()
        {
            choose1.Visible = true;
            choose2.Visible = false;
            but10.Visible = true;
            but20.Visible = true;
            but10t.Visible = false;
            but20t.Visible = false;
            fons.Visible = true;
            fons2.Visible = false;
            menuVisible = true;
        }

        private void HideMenu()
        {
            choose1.Visible = false;
            choose2.Visible = false;
            but10.Visible = false;
            but20.Visible = false;
            but10t.Visible = false;
            but20t.Visible = false;
            fons.Visible = false;
            fons2.Visible = false;
            menuVisible = false;
        }
        private void ShowMenu2()
        {
            choose1.Visible = false;
            choose2.Visible = true;
            but10.Visible = false;
            but20.Visible = false;
            but10t.Visible = true;
            but20t.Visible = true;
            fons.Visible = false;
            fons2.Visible = true;
            menuVisible = true;
        }

        private void HideMenu2()
        {
            choose1.Visible = false;
            choose2.Visible = false;
            but10.Visible = false;
            but20.Visible = false;
            but10t.Visible = false;
            but20t.Visible = false;
            fons.Visible = false;
            fons2.Visible = false;
            menuVisible = false;
        }
    }
}
