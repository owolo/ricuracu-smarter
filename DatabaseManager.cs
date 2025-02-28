using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Ricu_Racu
{
    public class DatabaseManager
    {
        private static string dbPath = "RicuRacu.sqlite";
        private static string connectionString = $"Data Source={dbPath};Version=3;";
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("12345678901234567890123456789012"); //32 bytes
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456"); //16 bytes


        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createJautTable = @"
                    CREATE TABLE IF NOT EXISTS Jautajumi (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        JautajumiText TEXT NOT NULL
                    )";

                string createAtbildTable = @"
                    CREATE TABLE IF NOT EXISTS Atbildes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        JautajumiId INTEGER,
                        AtbildesText TEXT NOT NULL,
                        IsCorrect INTEGER NOT NULL,
                        FOREIGN KEY (JautajumiId) REFERENCES Jautajumi(Id)
                    )";

                string createPlayersTable = @"
                    CREATE TABLE IF NOT EXISTS Players (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL
                    )";

                ExecuteNonQuery(createJautTable);
                ExecuteNonQuery(createAtbildTable);
                ExecuteNonQuery(createPlayersTable);

                InsertInitialJautajumi();
            }
        }

        private static void ExecuteNonQuery(string sql)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void InsertInitialJautajumi()
        {
            string[] jautajumi = {
        "Cik krāsu ir varavīksnē?", "Kur atrodas Bigbens?", "Kur atrodas Eifeļa tornis?", "Kur atrodas Pizas tornis?", "Kur atrodas Gīzas Lielās piramīdas?", "Kur atrodas Lielais Ķīnas mūris?", "Kur atrodas Zelta vārtu tilts?", "Kura ir ASV galvaspilsēta?", "Kur atrodas Lielais Barjerrifs?", "Kāda ir filma par parku ar dinozauriem?", "Vai cūciņai Pepai ir brāļi un māsas?", "Kurš ir Simbas tētis?", "Vai ziloņiem ir astes?", "Kāds ir lielākais putns?", "Kur dzīvo Vinnijs Pūks?", "Kura oga, pēc mītiem, uzlabo redzi?", "Kāds ir kovboja vārds filmā 'Toy Story'?", "Kāds ir lielākais dzīvnieks?", "Kāds ir garākais dzīvnieks?", "Ko mēra termometrs?", "No kā tiek izgatavotas olimpiskās medaļas?", "Ko bites ražo?", "Kā sauc olas dzelteno daļu?", "Kādā krāsā ir spināti?", "Kur dzīvo Ziemassvētku vecītis?", "Kādā krāsā ir plankumi uz bizbizmārītes?", "Cik kāju ir zirneklim?", "Cik gadu gadsimtā?", "Cik dzīvību ir kaķiem?", "Kur atrodas Ventas rumba?", "Kāds ir vienīgais pāra pirmskaitlis?", "Cik malu ir piecstūrim?", "Cik malu ir septiņstūrim?", "Cik malu ir desmitstūrim?", "Kura ir Austrālijas galvaspilsēta?", "Kā cilvēki sauc 3.1415?", "Cik mēnešu ir vienā gadā?", "Cik ir 22 + 13?", "Kā sauc 90 grādu leņķi?", "Kā sauc 180 grādu lenķi?", "Ko nozīmē romiešu cipars 'V'?", "Ko nozīmē romiešu cipars 'X'?", "Ko nozīmē romiešu cipars 'C'?", "Cik stundas ir dienā?", "Cik minūtes ir vienā stundā?", "Cik ir 5*5?", "Ja Jūs dubultojat 100, kas Jums sanāk?", "Cik kaulu ir cilvēka ķermenī?", "Cik dienu ir gadā?", "Cik dienu ir garajā gadā?"
        };

            string[][] atbildes = {
        new[] { "7", "6", "8" },
        new[] { "Londonā", "Parīzē", "Romā" },
        new[] { "Parīzē", "Londonā", "Berlīnē" },
        new[] { "Itālijā", "Spānijā", "Francijā" },
        new[] { "Ēģiptē", "Grieķijā", "Turcijā" },
        new[] { "Ķīnā", "Japānā", "Korejā" },
        new[] { "Sanfrancisko", "Ņujorkā", "Losandželosā" },
        new[] { "Vašingtona", "Ņujorka", "Losandželosa" },
        new[] { "Austrālijā", "Havaju salās", "Karību jūrā" },
        new[] { "Juras laikmeta parks", "Dinozauru sala", "Aizvēsturiskais parks" },
        new[] { "Jā", "Nē", "Tikai māsa" },
        new[] { "Mufasa", "Skars", "Rafiki" },
        new[] { "Jā", "Nē", "Tikai mazuļiem" },
        new[] { "Strauss", "Ērglis", "Pingvīns" },
        new[] { "Simtjūdžu mežā", "Brīnumzemē", "Nārnijā" },
        new[] { "Mellenes", "Zemenes", "Avenes" },
        new[] { "Vudijs", "Bazs", "Endijs" },
        new[] { "Zilais valis", "Ziloņi", "Žirafe" },
        new[] { "Žirafe", "Zilais valis", "Anakonda" },
        new[] { "Temperatūru", "Spiedienu", "Ātrumu" },
        new[] { "Metāla", "Plastmasas", "Koka" },
        new[] { "Medu", "Vasku", "Ziedu putekšņus" },
        new[] { "Dzeltenums", "Baltums", "Čaumala" },
        new[] { "Zaļi", "Sarkani", "Dzelteni" },
        new[] { "Ziemeļpolā", "Lapzemē", "Grenlandē" },
        new[] { "Melni", "Sarkani", "Zili" },
        new[] { "8", "6", "10" },
        new[] { "100", "50", "1000" },
        new[] { "9", "7", "3" },
        new[] { "Kuldīgā", "Ventspilī", "Liepājā" },
        new[] { "2", "1", "0" },
        new[] { "5", "4", "6" },
        new[] { "7", "6", "8" },
        new[] { "10", "8", "12" },
        new[] { "Kanbera", "Sidneja", "Melburna" },
        new[] { "Pī", "Fī", "Tau" },
        new[] { "12", "10", "14" },
        new[] { "35", "34", "36" },
        new[] { "Taisnais leņķis", "Šaurais leņķis", "Platais leņķis" },
        new[] { "Izstieptais leņķis", "Platais leņķis", "Pilns leņķis" },
        new[] { "5", "10", "50" },
        new[] { "10", "9", "11" },
        new[] { "100", "50", "500" },
        new[] { "24", "12", "36" },
        new[] { "60", "30", "100" },
        new[] { "25", "20", "30" },
        new[] { "200", "1000", "20" },
        new[] { "206", "300", "150" },
        new[] { "365", "360", "370" },
        new[] { "366", "367", "365" }
    };

            bool[][] correctAtbildes = {
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false },
        new[] { true, false, false }
    };

            var indices = Enumerable.Range(0, jautajumi.Length).ToList();
            var rng = new Random();
            int n = indices.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = indices[k];
                indices[k] = indices[n];
                indices[n] = value;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (int i in indices)
                    {
                        string insertJautajums = "INSERT INTO Jautajumi (JautajumiText) VALUES (@JautajumiText)";
                        using (var command = new SQLiteCommand(insertJautajums, connection))
                        {
                            command.Parameters.AddWithValue("@JautajumiText", jautajumi[i]);
                            command.ExecuteNonQuery();
                        }

                        long jautajumiId;
                        using (var cmd = new SQLiteCommand("SELECT last_insert_rowid();", connection))
                        {
                            jautajumiId = (long)cmd.ExecuteScalar();
                        }

                        var answerIndices = new List<int> { 0, 1, 2 };
                        for (int j = answerIndices.Count - 1; j > 0; j--)
                        {
                            int k = rng.Next(j + 1);
                            int temp = answerIndices[j];
                            answerIndices[j] = answerIndices[k];
                            answerIndices[k] = temp;
                        }
                    }
                }
            }
        }

        public static void InsertAtbilde(int jautajumiId, string atbildeText, bool isCorrect)
        {
            string encryptedAtbilde = Encrypt(atbildeText);

            string insertAtbilde = "INSERT INTO Atbildes (JautajumiId, AtbildesText, IsCorrect) VALUES (@JautajumiId, @AtbildesText, @IsCorrect)";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(insertAtbilde, connection))
                {
                    command.Parameters.AddWithValue("@JautajumiId", jautajumiId);
                    command.Parameters.AddWithValue("@AtbildesText", encryptedAtbilde);
                    command.Parameters.AddWithValue("@IsCorrect", isCorrect ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.GenerateIV();
                byte[] iv = aesAlg.IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(iv, 0, iv.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static System.Data.DataTable GetRandomJautajums()
        {
            string query = @"SELECT j.Id AS JautajumiId, j.JautajumiText, a.Id AS AtbildesId, a.AtbildesText, a.IsCorrect
                             FROM Jautajumi j
                             JOIN Atbildes a ON j.Id = a.JautajumiId
                             WHERE j.Id IN (SELECT Id FROM Jautajumi ORDER BY RANDOM() LIMIT 1)
                             ORDER BY RANDOM()";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        var dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);

                        foreach (System.Data.DataRow row in dataTable.Rows)
                        {
                            string encryptedText = row["AtbildesText"].ToString();
                            row["AtbildesText"] = encryptedText.StartsWith("/") || encryptedText.EndsWith("=") ? Decrypt(encryptedText) : encryptedText;

                        }

                        return dataTable;
                    }
                }
            }
        }
        private static string Decrypt(string cipherText)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;

                byte[] iv = new byte[16];
                Array.Copy(fullCipher, iv, iv.Length);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(fullCipher, iv.Length, fullCipher.Length - iv.Length))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
