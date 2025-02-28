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
        //private bool irIzm5050 = false;
        //private bool irSkipJaut = false;
        private Random random = new Random();
        public int[] seciba = Enumerable.Range(0, 50).ToArray();
        public int nr = 0;
        private int reizes = 0;
        private int punkti;
        private List<int> usedQuestionIndices = new List<int>();
        private long currentGameSessionId;
        private DataTable currentJautajums;

        string[] jautajumi = new string[] {
            "Cik krāsu ir varavīksnē?", "Kur atrodas Bigbens?", "Kur atrodas Eifeļa tornis?", "Kur atrodas Pizas tornis?", "Kur atrodas Gīzas Lielās piramīdas?", "Kur atrodas Lielais Ķīnas mūris?", "Kur atrodas Zelta vārtu tilts?", "Kura ir ASV galvaspilsēta?", "Kur atrodas Lielais Barjerrifs?", "Kāda ir filma par parku ar dinozauriem?", "Vai cūciņai Pepai ir brāļi un māsas?", "Kurš ir Simbas tētis?", "Vai ziloņiem ir astes?", "Kāds ir lielākais putns?", "Kur dzīvo Vinnijs Pūks?", "Kura oga, pēc mītiem, uzlabo redzi?", "Kāds ir kovboja vārds filmā 'Toy Story'?", "Kāds ir lielākais dzīvnieks?", "Kāds ir garākais dzīvnieks?", "Ko mēra termometrs?", "No kā tiek izgatavotas olimpiskās medaļas?", "Ko bites ražo?", "Kā sauc olas dzelteno daļu?", "Kādā krāsā ir spināti?", "Kur dzīvo Ziemassvētku vecītis?", "Kādā krāsā ir plankumi uz bizbizmārītes?", "Cik kāju ir zirneklim?", "Cik gadu gadsimtā?", "Cik dzīvību ir kaķiem?", "Kur atrodas Ventas rumba?", "Kāds ir vienīgais pāra pirmskaitlis?", "Cik malu ir piecstūrim?", "Cik malu ir septiņstūrim?", "Cik malu ir desmitstūrim?", "Kura ir Austrālijas galvaspilsēta?", "Kā cilvēki sauc 3.1415?", "Cik mēnešu ir vienā gadā?", "Cik ir 22 + 13?", "Kā sauc 90 grādu leņķi?", "Kā sauc 190 grādu leņķi?", "Ko nozīmē romiešu cipars 'V'?", "Ko nozīmē romiešu cipars 'X'?", "Ko nozīmē romiešu cipars 'C'?", "Cik stundas ir dienā?", "Cik minūtes ir vienā stundā?", "Cik ir 5*5?", "Ja Jūs dubultojat 100, kas Jums sanāk?", "Cik kaulu ir cilvēka ķermenī?", "Cik dienu ir gadā?", "Cik dienu ir garajā gadā?"
            };
        string[] atbildes1 = new string[] {
            "7", "Londonā", "Parīzē", "Itālijā", "Ēģiptē", "Pekinā", "Sanfrancisko", "Vašingtona", "Austrālijā", "Jūras laikmeta parks", "Jā", "Mufasa", "Jā", "Strauss", "Simts akru mežs", "Mellenes", "Vudijs", "Zilais valis", "Žirafe", "Temperatūru", "Dārgmetāliem", "Medu", "Dzeltenums", "Zaļš", "Ziemeļpolā", "Melni", "8", "100 gadi", "9", "Kuldīgā", "2", "5", "7", "10", "Sidneja", "Pi", "12", "35", "Taisns leņķis", "Izstiepts leņķis", "5", "10", "100", "24", "60", "25", "200", "206", "365", "366"
            };
        string[] atbildes2 = new string[] {
            "6", "Dublinā", "Las Vegas", "Moldovā", "Amerikā", "Indijā", "Latvijā", "Rīga", "Indonēzijā", "Rozā pantera", "Nē", "Dumbo", "Nē", "Pīle", "Rīgas ZOO", "Zemenes", "Bembijs", "Zilonis", "Garnele", "Spiedienu", "Plastmasa", "Pienu", "Siers", "Zils", "Dienvidpolā", "Sarkani", "6", "10 gadi", "8", "Rīgā", "4", "10", "8", "12", "Melburna", "Pica", "13", "25", "Šaurs leņķis", "Lielais leņķis", "1", "15", "500", "12", "30", "20", "300", "205", "367", "368"
            };
        string[] atbildes3 = new string[] {
            "8", "Romā", "Berlīnē", "Vienā", "Meksikā", "Japānā", "Lietuvā", "Tallina", "Nīderlandē", "Titaniks", "Neviens nezina", "Mikipele", "Varbūt", "Gailis", "Okeānā", "Ķirbji", "Sūklis Bobs", "Suns", "Simtkājis", "Ph līmeni", "Koka", "Kvasu", "Brūnums", "Sarkans", "Austrumpolā", "Brūni", "4", "1000 gadu", "10", "Kārsavā", "8", "12", "14", "20", "Kanbera", "Eur", "11", "45", "90° leņķis", "180° leņķis", "200", "70", "50", "48", "80", "30", "400", "203", "350", "390"
            };

        Dictionary<string, string> atbildes = new Dictionary<string, string>() {
            {"Cik krāsu ir varavīksnē?","7"},
            {"Kur atrodas Bigbens?","Londonā"},
            {"Kur atrodas Eifeļa tornis?","Parīzē"},
            {"Kur atrodas Pizas tornis?","Itālijā"},
            {"Kur atrodas Gīzas Lielās piramīdas?","Ēģiptē"},
            {"Kur atrodas Lielais Ķīnas mūris?","Pekinā"},
            {"Kur atrodas Zelta vārtu tilts?","Sanfrancisko"},
            {"Kura ir ASV galvaspilsēta?","Vašingtona"},
            {"Kur atrodas Lielais Barjerrifs?","Austrālijā"},
            {"Kāda ir filma par parku ar dinozauriem?","Jūras laikmeta parks"},
            {"Vai cūciņai Pepai ir brāļi un māsas?","Jā"},
            {"Kurš ir Simbas tētis?","Mufasa"},
            {"Vai ziloņiem ir astes?","Jā"},
            {"Kāds ir lielākais putns?","Strauss"},
            {"Kur dzīvo Vinnijs Pūks?","Simts akru mežs"},
            {"Kura oga, pēc mītiem, uzlabo redzi?","Mellenes"},
            {"Kāds ir kovboja vārds filmā 'Toy Story'?","Vudijs"},
            {"Kāds ir lielākais dzīvnieks?","Zilais valis"},
            {"Kāds ir garākais dzīvnieks?","Žirafe"},
            {"Ko mēra termometrs?","Temperatūru"},
            {"No kā tiek izgatavotas olimpiskās medaļas?","Dārgmetāliem"},
            {"Ko bites ražo?","Medu"},
            {"Kā sauc olas dzelteno daļu?","Dzeltenums"},
            {"Kādā krāsā ir spināti?","Zaļš"},
            {"Kur dzīvo Ziemassvētku vecītis?","Ziemeļpolā"},
            {"Kādā krāsā ir plankumi uz bizbizmārītes?","Melni"},
            {"Cik kāju ir zirneklim?","8"},
            {"Cik gadu gadsimtā?","100 gadi"},
            {"Cik dzīvību ir kaķiem?","9"},
            {"Kura ir Austrālijas galvaspilsēta?","Kanbera"},
            {"Kāds ir vienīgais pāra pirmskaitlis?","2"},
            {"Cik malu ir piecstūrim?","5"},
            {"Cik malu ir septiņstūrim?","7"},
            {"Cik malu ir desmitstūrim?","10"},
            {"Kur atrodas Ventas rumba?","Kuldīgā"},
            {"Kā cilvēki sauc 3.1415?","Pi"},
            {"Cik mēnešu ir vienā gadā?","12"},
            {"Cik ir 22 + 13?","35"},
            {"Kā sauc 90 grādu leņķi?","Taisns leņķis"},
            {"Kā sauc 190 grādu leņķi?","Izstiepts leņķis"},
            {"Ko nozīmē romiešu cipars 'V'?","5"},
            {"Ko nozīmē romiešu cipars 'X'?","10"},
            {"Ko nozīmē romiešu cipars 'C'?","100"},
            {"Cik stundas ir dienā?","24"},
            {"Cik minūtes ir vienā stundā?","60"},
            {"Cik ir 5*5?","25"},
            {"Ja Jūs dubultojat 100, kas Jums sanāk?","200"},
            {"Cik kaulu ir cilvēka ķermenī?","206"},
            {"Cik dienu ir gadā?","365"},
            {"Cik dienu ir garajā gadā?","366"}
            };


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
            currentGameSessionId = DatabaseManager.CreateGameSession(playerSkaits, blockSkaits);
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
            currentJautajums = DatabaseManager.GetRandomJautajums();
            if (currentJautajums.Rows.Count > 0)
            {
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
                if (punkti > 0 && red.Left < 605)
                {
                    imgTimer.Interval = 500;
                    red.Left = red.Left + 54;
                    punkti--;
                }
                if (punkti == 0)
                {
                    DatabaseManager.UpdateGameProgress(currentGameSessionId, 1, red.Left);
                    if (red.Left >= 605)
                    {
                        DatabaseManager.EndGameSession(currentGameSessionId);
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
                    if (punkti == 0)
                    DatabaseManager.UpdateGameProgress(currentGameSessionId, 1, red.Left);
                    if (red.Left >= 1140)
                    {
                        DatabaseManager.EndGameSession(currentGameSessionId);
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