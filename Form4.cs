using System;
using System.Windows.Forms;

namespace Ricu_Racu
{
    public partial class Form4 : Form
    {
        private readonly string winner;
        public Form4()
        {
            InitializeComponent();
            this.FormClosed += Form4_FormClosed;
        }
        public Form4(string winner) : this()
        {
            if (winner == "red")
            {
                winner = "Sarkanais";
            }
            else
            {
                winner = "Zaļais";
            }
            this.winner = winner;
            Uzvaretajs();
        }

        private void Uzvaretajs()
        {
            text.Text = $"{winner} spēlētājs uzvarēja šo spēli! \r\nTagad gan skaidrs kurš ir gudrāks :)";

        }

        private void toStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }
    }
}
