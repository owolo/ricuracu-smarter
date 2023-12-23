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
    public partial class Form4 : Form
    {
        private readonly string winner;
        public Form4()
        {
            InitializeComponent();
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
            text.Text = $"{winner} spēlētājs uzvarēja šo! \r\nTagad gan skaidrs kurš ir gudrāks :)";

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
    }
}
