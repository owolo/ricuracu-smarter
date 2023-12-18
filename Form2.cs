using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

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
        public int piemeri = 0;
        public static int punkti = 0;
        public int[] seciba = Enumerable.Range(0, 50).ToArray();

        //private readonly string[] diceImg = { "dice1.png", "dice2.png", "dice3.png", "dice4.png", "dice5.png", "dice6.png" };

        string[] jautajumi = new string[] {
            "Cik krāsu ir varavīksnē?", "Kur atrodas Bigbens?", "Kur atrodas Eifeļa tornis?", "Kur atrodas Pizas tornis?", "Kur atrodas Gīzas Lielās piramīdas?", "Kur atrodas Lielais Ķīnas mūris?", "Kur atrodas Zelta vārtu tilts?", "Kura ir ASV galvaspilsēta?", "Kur atrodas Lielais Barjerrifs?", "Kāda ir filma par parku ar dinozauriem?", "Vai cūciņai Pepai ir brāļi un māsas?", "Kurš ir Simbas tētis?", "Vai ziloņiem ir astes?", "Kāds ir lielākais putns?", "Kur dzīvo Vinnijs Pūks?", "Kura oga, pēc mītiem, uzlabo redzi?", "Kāds ir kovboja vārds filmā 'Rotaļlietu stāsts'?", "Kāds ir lielākais dzīvnieks?", "Kāds ir garākais dzīvnieks?", "Ko mēra termometrs?", "No kā tiek izgatavotas olimpiskās medaļas?", "Ko bites ražo?", "Kā sauc olas dzelteno daļu?", "Kādā krāsā ir spināti?", "Kur dzīvo Ziemassvētku vecītis?", "Kādā krāsā ir plankumi uz bizbizmārītes?", "Cik kāju ir zirneklim?", "Cik gadu gadsimtā?", "Cik dzīvību ir kaķiem?", "Kur atrodas Ventas rumba?", "Kāds ir vienīgais pāra pirmskaitlis?", "Cik malu ir piecstūrim?", "Cik malu ir septiņstūrim?", "Cik malu ir desmitstūrim?", "Kura ir Austrālijas galvaspilsēta?", "Kā cilvēki sauc 3.1415?", "Cik mēnešu ir vienā gadā?", "Cik ir 22 + 13?", "Kā sauc 90 grādu leņķi?", "Kā sauc 190 grādu lenķi?", "Ko nozīmē romiešu cipars 'V'?", "Ko nozīmē romiešu cipars 'X'?", "Ko nozīmē romiešu cipars 'C'?", "Cik stundas ir dienā?", "Cik minūtes ir vienā stundā?", "Cik ir 5*5?", "Ja Jūs dubultojat 100, kas Jums sanāk?", "Cik kaulu ir cilvēka ķermenī?", "Cik dienu ir gadā?", "Cik dienu ir garajā gadā?"
            };
        string[] atbildes1 = new string[] {
            "7", "Londonā", "Parīzē", "Itālijā", "Ēģiptē", "Pekinā", "Sanfrancisko", "Vašingtona", "Austrālijā", "Juras laikmeta parks", "Jā", "Mufasa", "Jā", "Strauss", "Simts akru mežs", "Mellenes", "Vudijs", "Zilais valis", "Žirafe", "Temperatūru", "Dārgmetāliem", "Medu", "Dzeltenums", "Zaļš", "Ziemeļpolā", "Melni", "8", "100 gadi", "9", "Kuldīgā", "2", "5", "7", "10", "Sidneja", "Pi", "12", "35", "Taisns lenķis", "Izstiepts lenķis", "5", "10", "100", "24", "60", "25", "200", "206", "365", "366"
            };
        string[] atbildes2 = new string[] {
            "6", "Dublinā", "Las Vegas", "Moldovā", "Amerikā", "Indijā", "Latvijā", "Rīga", "Indonezijā", "Rozā pantera", "Nē", "Dumbo", "Nē", "Pīle", "Rīgas ZOO", "Zemenes", "Bembijs", "Zilonis", "Garnele", "Spiedienu", "Plastmasa", "Pienu", "Siers", "Zili", "Dienvidpolā", "Sarkani", "6", "10 gadi", "8", "Rīgā", "4", "10", "8", "12", "Melburna", "Pica", "13", "25", "Šaurs lenķis", "Lielais lenķis", "1", "15", "1000", "12", "30", "20", "300", "205", "367", "368"
            };
        string[] atbildes3 = new string[] {
            "8", "Romā", "Berlīnē", "Vienā", "Meksikā", "Japānā", "Lietuvā", "Tallina", "Niderlandē", "Titaniks", "Neviens nezina", "Mikipele", "Varbūt", "Gailis", "Okeanā", "Ķirbji", "Sūklisbobs", "Suns", "Simtkājis", "Ph līmeni", "Koka", "Kvasu", "Brūnums", "Sarkans", "Austrumpolā", "Brūni", "4", "1000 gadu", "10", "Kārsavā", "8", "12", "14", "20", "Kanbera", "Eur", "12", "35", "90° lenķis", "180° lenķis", "200", "70", "50", "48", "80", "30", "400", "203", "350", "390"
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
            {"Kāda ir filma par parku ar dinozauriem?","Juras laikmeta parks"},
            {"Vai cūciņai Pepai ir brāļi un māsas?","Jā"},
            {"Kurš ir Simbas tētis?","Mufasa"},
            {"Vai ziloņiem ir astes?","Jā"},
            {"Kāds ir lielākais putns?","Strauss"},
            {"Kur dzīvo Vinnijs Pūks?","Simts akru mežs"},
            {"Kura oga, pēc mītiem, uzlabo redzi?","Mellenes"},
            {"Kāds ir kovboja vārds filmā 'Rotaļlietu stāsts'?","Vudijs"},
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
            {"Kā sauc 90 grādu leņķi?","Taisns lenķis"},
            {"Kā sauc 190 grādu lenķi?","Izstiepts lenķis"},
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
            piemeri = 0;
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
            var rand = new Random();
            //dice.Visible = false;
            ShuffleQuestionsAndAnswers();
            //usedQuestionIndices.Clear();

            if (blockSkaits == 10 && playerSkaits == 1)
            {
                this.Size = new Size(650, 500);
                green.Visible = false;
                spawnGreen.Visible = false;
                red.Location = new Point(11, 82);
                spawnRed.Location = new Point(11, 82);
                dice.Location = new Point(450, 250);

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
                if (!atmetKIr)
                {
                    PictureBox atmetK = new PictureBox
                    {
                        Size = new Size(blockGar, blockAug),
                        Image = atmetKImage,
                        BackColor = Color.Silver,
                    };
                    int yPosition = 82;
                    int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));

                    atmetK.Location = new Point(xPosition, yPosition);

                    this.Controls.Add(atmetK);
                    atmetK.BringToFront();
                    atmetK.BorderStyle = BorderStyle.FixedSingle;
                    atmetKIr = true;
                }
            }
            if (blockSkaits == 20 && playerSkaits == 1)
            {
                this.Size = new Size(1180, 530);
                green.Location = new Point(1145, 82);
                spawnGreen.BackColor = Color.Silver;
                dice.Location = new Point(880, 283);
                jautajums.Location = new Point(480, 222);
                //time.Location = new Point(780, 222);
                atbildeBut1.Location = new Point(450, 301);
                atbildeBut2.Location = new Point(621, 301);
                atbildeBut3.Location = new Point(450, 393);
                //skipJaut.Location = new Point(455, 490);
                //izm5050.Location = new Point(628, 490);
                red.Location = new Point(11, 82);
                spawnRed.Location = new Point(11, 82);
                green.Visible = false;
                spawnGreen.Visible = false;

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
                if (!atmetKIr)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        PictureBox atmetK = new PictureBox
                        {
                            Size = new Size(blockGar, blockAug),
                            Image = atmetKImage,
                            BackColor = Color.Silver,
                        };
                        int yPosition = 82;
                        int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));

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
                this.Size = new Size(690, 500);
                red.Location = new Point(11, 47);
                spawnRed.Location = new Point(11, 47);
                green.Location = new Point(605, 120);
                spawnGreen.Location = new Point(605, 120);
                dice.Location = new Point(450, 260);


                for (int i = 0; i < blockSkaits; i++) //green ludo line
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
                        int yPosition = 47;
                        int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));

                        atmetL.Location = new Point(xPosition, yPosition);

                        this.Controls.Add(atmetL);
                        atmetL.BringToFront();
                        atmetL.BorderStyle = BorderStyle.FixedSingle;
                        atmetLIr = true;
                    }

                }
                for (int i = 0; i < blockSkaits; i++) //red ludo line
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
                        int yPosition = 120;
                        int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));

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
                this.Size = new Size(1235, 530);
                green.Location = new Point(1145, 82);
                spawnGreen.BackColor = Color.Silver;
                dice.Location = new Point(880, 283);
                jautajums.Location = new Point(480, 222);
                //time.Location = new Point(780, 222);
                atbildeBut1.Location = new Point(450, 321);
                atbildeBut2.Location = new Point(621, 321);
                atbildeBut3.Location = new Point(450, 413);
                //skipJaut.Location = new Point(455, 490);
                //izm5050.Location = new Point(628, 490);
                spawnGreen.Visible = false;
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
                if (!atmetLIr)
                {
                    PictureBox atmetL = new PictureBox
                    {
                        Size = new Size(blockGar, blockAug),
                        Image = atmetLImage,
                        BackColor = Color.Silver,
                    };
                    int yPosition = 47;
                    int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));

                    atmetL.Location = new Point(xPosition, yPosition);

                    this.Controls.Add(atmetL);
                    atmetL.BringToFront();
                    atmetL.BorderStyle = BorderStyle.FixedSingle;
                    atmetLIr = true;
                }

                for (int i = 0; i < blockSkaits; i++) //red ludo line
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
                    int yPosition = 120;
                    int xPosition = (int)(65 + random.Next(0, blockSkaits) * (blockGar + space));

                    atmetK.Location = new Point(xPosition, yPosition);

                    this.Controls.Add(atmetK);
                    atmetK.BringToFront();
                    atmetK.BorderStyle = BorderStyle.FixedSingle;
                    atmetKIr = true;
                }
            }
        }
        private void ShuffleArrays()
        {
            var rand = new Random();

            for (int i = seciba.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                int temp = seciba[i];
                seciba[i] = seciba[x];
                seciba[x] = temp;
            }

            Sajaukt(atbildes1);
            Sajaukt2(atbildes2);
            Sajaukt3(atbildes3);
            Sajaukt4(jautajumi);
        }

        private void Sajaukt(string[] array)
        {
            var rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string temp = array[i];
                array[i] = array[x];
                array[x] = temp;
            }
        }
        private void Sajaukt2(string[] array)
        {
            var rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string temp = array[i];
                array[i] = array[x];
                array[x] = temp;
            }
        }
        private void Sajaukt3(string[] array)
        {
            var rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string temp = array[i];
                array[i] = array[x];
                array[x] = temp;
            }
        }
        private void Sajaukt4(string[] array)
        {
            var rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string temp = array[i];
                array[i] = array[x];
                array[x] = temp;
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

        List<int> usedQuestionIndices = new List<int>();

        private void ShuffleQuestionsAndAnswers()
        {
            {
                ShuffleArrays();
                jautajums.Text = jautajumi[seciba[piemeri]];
                atbildeBut1.Text = atbildes1[seciba[piemeri]];
                atbildeBut2.Text = atbildes2[seciba[piemeri]];
                atbildeBut3.Text = atbildes3[seciba[piemeri]];
            }

            atbildeBut1.Click -= atbildeBut1_Click;
            atbildeBut2.Click -= atbildeBut2_Click;
            atbildeBut3.Click -= atbildeBut3_Click;

            atbildeBut1.Click += atbildeBut1_Click;
            atbildeBut2.Click += atbildeBut2_Click;
            atbildeBut3.Click += atbildeBut3_Click;
        }

        private void NakJaut()
        {
            if (usedQuestionIndices.Count >= seciba.Length)
            {
                MessageBox.Show("Visi jautajumi jau uzdoti!");
                this.Hide();
                Form3 beigas = new Form3();
                beigas.Show();
                return;
            }

            ShuffleQuestionsAndAnswers();
            JauktPogas();
        }

        private void atbildeBut1_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut1.Text))
            {
                MessageBox.Show("Uzspiests 1!");
                NakJaut();
            }
        }

        private void atbildeBut2_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut2.Text))
            {
                MessageBox.Show("Uzspiests 2!");
                NakJaut();
            }
        }

        private void atbildeBut3_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut3.Text))
            {
                MessageBox.Show("Uzspiests 3!");
                NakJaut();
            }
        }
        private bool ParbAtbild(string izvAtb)
        {
            int shuffledIndex = seciba[piemeri];
            string shuffledQuestion = jautajumi[shuffledIndex];

            if (atbildes.ContainsKey(shuffledQuestion))
            {
                string correctAnswer = atbildes[shuffledQuestion];

                string shuffledAnswer1 = atbildes1[shuffledIndex];
                string shuffledAnswer2 = atbildes2[shuffledIndex];
                string shuffledAnswer3 = atbildes3[shuffledIndex];

                if (izvAtb == shuffledAnswer1 || izvAtb == shuffledAnswer2 || izvAtb == shuffledAnswer3)
                {
                    MessageBox.Show($"Shuffled Question: {shuffledQuestion}");
                    MessageBox.Show($"Selected Answer: {izvAtb}");
                    MessageBox.Show($"Correct Answer: {correctAnswer}");

                    if (izvAtb == correctAnswer)
                    {
                        MessageBox.Show("Correct Answer!");
                        return true;
                    }
                }
                MessageBox.Show("Incorrect Answer!");
                return false;
            }
            return false;
        }
    }
}
