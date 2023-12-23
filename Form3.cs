using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Ricu_Racu
{
    public partial class Form3 : Form
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
        private int speletajs = 1;
        private int punkti;
        private List<int> usedQuestionIndices = new List<int>();

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


        public Form3()
        {
            InitializeComponent();
            playerSkaits = 0;
            blockSkaits = 0;
            imgTimer = new Timer();
            imgTimer.Tick += imgTimer_Tick;
        }

        public Form3(int izvPlayerSkaits, int izvBlockSkaits) : this()
        {
            blockSkaits = izvBlockSkaits;
            playerSkaits = izvPlayerSkaits;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            double space = 4;
            //bool atmetLIr = false;
            //bool atmetKIr = false;
            //Image atmetLImage = Image.FromFile("arrow right.png");
            //Image atmetKImage = Image.FromFile("arrow left.png");
            var rand = new Random();
            ShuffleQuestionsAndAnswers();

            if (blockSkaits == 10 && playerSkaits == 2)
            {
                this.Size = new Size(690, 500);
                winBlock.Location = new Point(605, 47);
                winBlock2.Location = new Point(11, 120);
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

                    /*if (!atmetLIr)
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
                    }*/

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

                    /*if (!atmetKIr)
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
                    }*/
                }
            }

            if (blockSkaits == 20 && playerSkaits == 2)
            {
                this.Size = new Size(1235, 530);
                winBlock.Location = new Point(1145, 47);
                winBlock2.Location = new Point(11, 120);
                green.Location = new Point(1145, 82);
                spawnGreen.BackColor = Color.Silver;
                dice.Location = new Point(880, 283);
                jautajums.Location = new Point(480, 222);
                //time.Location = new Point(780, 222);
                atbildeBut1.Location = new Point(450, 321);
                atbildeBut2.Location = new Point(621, 321);
                atbildeBut3.Location = new Point(535, 393);
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
                /*if (!atmetLIr)
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
                }*/

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
                /*if (!atmetKIr)
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
                }*/
            }
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
        private void Sajaukt2(string[] atbildes1)
        {
            var rand = new Random();
            for (int i = atbildes1.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string sec = atbildes1[i];
                atbildes1[i] = atbildes1[x];
                atbildes1[x] = sec;
            }
        }
        private void Sajaukt3(string[] atbildes2)
        {
            var rand = new Random();
            for (int i = atbildes2.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string sec = atbildes2[i];
                atbildes2[i] = atbildes2[x];
                atbildes2[x] = sec;
            }
        }
        private void Sajaukt4(string[] atbildes3)
        {
            var rand = new Random();
            for (int i = atbildes3.Length - 1; i > 0; i--)
            {
                int x = rand.Next(0, i + 1);
                string sec = atbildes3[i];
                atbildes3[i] = atbildes3[x];
                atbildes3[x] = sec;
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

        //List<int> usedQuestionIndices = new List<int>();

        private void ShuffleQuestionsAndAnswers()
        {
            var rand = new Random();

            int unusedQuestionIndex;
            do
            {
                unusedQuestionIndex = rand.Next(0, jautajumi.Length);
            } while (usedQuestionIndices.Contains(unusedQuestionIndex));

            usedQuestionIndices.Add(unusedQuestionIndex);

            seciba[nr] = unusedQuestionIndex;

            jautajums.Text = jautajumi[unusedQuestionIndex];
            atbildeBut1.Text = atbildes1[unusedQuestionIndex];
            atbildeBut2.Text = atbildes2[unusedQuestionIndex];
            atbildeBut3.Text = atbildes3[unusedQuestionIndex];


            atbildeBut1.Click -= atbildeBut1_Click;
            atbildeBut2.Click -= atbildeBut2_Click;
            atbildeBut3.Click -= atbildeBut3_Click;

            atbildeBut1.Click += atbildeBut1_Click;
            atbildeBut2.Click += atbildeBut2_Click;
            atbildeBut3.Click += atbildeBut3_Click;
        }

        private void NakJaut()
        {
            if (usedQuestionIndices.Count == jautajumi.Length)
            {
                MessageBox.Show("Visi jautajumi jau uzdoti!");
                this.Hide();
                Form4 beigas = new Form4();
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
                //MessageBox.Show("Uzspiests 1!");
                //NakJaut();
            }
        }

        private void atbildeBut2_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut2.Text))
            {
                //MessageBox.Show("Uzspiests 2!");
                //NakJaut();
            }
        }

        private void atbildeBut3_Click(object sender, EventArgs e)
        {
            if (ParbAtbild(atbildeBut3.Text))
            {
                //MessageBox.Show("Uzspiests 3!");
                //NakJaut();
            }
        }
        private bool ParbAtbild(string izvAtb)
        {
            string shuffledQuestion = jautajumi[seciba[nr]];

            if (atbildes.TryGetValue(shuffledQuestion, out string correctAnswer))
            {
                MessageBox.Show($"Shuffled Question: {shuffledQuestion}");
                MessageBox.Show($"Selected Answer: {izvAtb}");
                MessageBox.Show($"Correct Answer: {correctAnswer}");

                if (izvAtb == correctAnswer)
                {
                    MessageBox.Show("Correct Answer!");
                    dice.Visible = true;
                    return true;
                }
            }
            MessageBox.Show("Incorrect Answer!");
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
            else if (speletajs == 1)
            {
                if (punkti > 0 && red.Left < 685)
                {
                    red.Left = red.Left + 54;
                    punkti--;
                }
                else if (punkti == 0 && red.Left > 600)
                {
                    winBlock.SendToBack();
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
            else if (speletajs == 2)
            {
                if (punkti > 0 && green.Right < 685)
                {
                    green.Left = green.Right + 54;
                    punkti--;
                }
                else if (punkti == 0 && green.Right > 600)
                {
                    winBlock2.SendToBack();
                    green.Location = new Point(605, 82);
                    imgTimer.Stop();
                    PictureBox winner = green;
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
            reizes = 0;
            imgTimer.Start();
        }
    }
}