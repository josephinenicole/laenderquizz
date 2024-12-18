using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LaenderspielApp
{
    public partial class Hauptfenster : Form
    {
        static Random zufallsquelle = new Random();
        List<Land> alleLaender = new List<Land>();
        RadioButton[] radioButtonAntwort;
        Land richtig;
        int punkte;
        int aktuelleFrage = 0;
         

        public string spielmodus { get; private set; }

        private void buttonAnzeigeBesteErgebnisse_Click(object sender, EventArgs e)
        {
            AnzeigeBesteErgebnisse();
        }

        private void AnzeigeBesteErgebnisse()
        {
            List<HighscoreEintrag> besteErgebnisse = HoleBesteErgebnisse(10);

            foreach (HighscoreEintrag eintrag in besteErgebnisse)
            {
                listBoxBesteErgebnisse.Items.Add($"{eintrag.SpielerName} - Punktzahl: {eintrag.Punktzahl} - Datum: {eintrag.Datum}");
            }
        }

        // Definition der HighscoreEintrag-Klasse 
      

        public Hauptfenster()
        {
            InitializeComponent();

            // Initialisierung der RadioButtons
            radioButtonAntwort = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };


        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            // Lädt alle Länderdaten aus der Datenbank
            alleLaender = GetLänder("Hauptstadt", "Name", "Bilddatei");

            // HIGHSCORES LADEN, nur die höchsten sort by... odre order by
            LadenUndAnzeigenHighscores();
        }

        private void LadenUndAnzeigenHighscores()
        {
            // Lade die Highscores aus der Datenbank und sortiere sie nach Punktzahl absteigend
            List<HighscoreEintrag> highscores = HoleBesteErgebnisse(10);

            // Lösche alle vorhandenen Einträge in der ListBox
            listBoxBesteErgebnisse.Items.Clear();

            // Füge die Highscores der ListBox hinzu
            foreach (HighscoreEintrag eintrag in highscores)
            {
                // Formatierung des Highscore-Eintrags nach deinen Wünschen, z.B. Spielername und Punktzahl
                string highscoreText = $"{eintrag.SpielerName}: {eintrag.Punktzahl}";

                // Füge den formatierten Eintrag der ListBox hinzu
                listBoxBesteErgebnisse.Items.Add(highscoreText);
            }
        }

        private List<Land> GetLänder(params string[] kategorien)
        {
            List<Land> länder = new List<Land>();

            Datenbank.VerbindungOeffnen();

            // Baue die SELECT-Anweisung basierend auf den übergebenen Kategorien
            string kategorienString = string.Join(", ", kategorien);
            string query = $"SELECT *, {kategorienString} AS KategorieWert FROM Länder";

            using (MySqlCommand cmd = Datenbank.BefehlErstellen(query))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Land land = new Land(
                            Convert.ToInt32(reader["ID"]),
                            reader["Name"].ToString(),
                            reader["Hauptstadt"].ToString(),
                            reader["Bilddatei"].ToString()
                        );

                        // Setze die Werte der ausgewählten Kategorien
                        foreach (string kategorie in kategorien)
                        {
                            land.KategorieWert = reader[kategorie].ToString();
                        }

                        länder.Add(land);
                    }
                }
            }
            Datenbank.VerbindungSchliessen();
            return länder;
        }



        private void NaechsteFrage()
        {
            aktuelleFrage++;
            labelFortschritt.Text = "" + aktuelleFrage + " von 10";
            // 4 Länder per Zufall auswählen
            List<Land> auswahl = new List<Land>();
            while (auswahl.Count < 4)
            {
                Land l = alleLaender[zufallsquelle.Next(alleLaender.Count)];
                if (!auswahl.Contains(l))
                {
                    auswahl.Add(l);
                }
            }

            richtig = auswahl[zufallsquelle.Next(4)];

            if (spielmodus == "Flagge")
            {
                // Flagge des richtigen Landes anzeigen
                pictureBoxFlaggen.BackgroundImage = Properties.Resources.ResourceManager.GetObject(richtig.Bilddatei) as Image;

                // Alle 4 ausgewählten Flaggen in die Antwort-Komponenten installieren
                for (int i = 0; i < 4; ++i)
                {
                    radioButtonAntwort[i].Text = auswahl[i].Name;
                    radioButtonAntwort[i].Tag = auswahl[i]; // Hier die Information, ob die Antwort richtig ist, als Tag setzen
                }
            }
            else if (spielmodus == "Ländername")
            {
                // Name des richtigen Landes anzeigen
                labelFragen.Text = $"Was ist die Hauptstadt\nvon {richtig.Name}?";

                // Alle 4 ausgewählten Namen in die Antwort-Komponenten installieren
                for (int i = 0; i < 4; ++i)
                {
                    radioButtonAntwort[i].Text = auswahl[i].Hauptstadt;
                    radioButtonAntwort[i].Tag = auswahl[i]; // Hier die Information, ob die Antwort richtig ist, als Tag setzen
                }
            }
            else if (spielmodus == "Hauptstadt")
            {
                
                // Frage nach der Hauptstadt eines zufälligen Landes anzeigen
                Land frageLand = alleLaender[zufallsquelle.Next(alleLaender.Count)];
                labelFragen.Text = $"Von welchem Land ist\n {richtig.Hauptstadt} die Hauptstadt?";

                // Alle 4 ausgewählten Hauptstädte in die Antwort-Komponenten installieren
                for (int i = 0; i < 4; ++i)
                {
                    radioButtonAntwort[i].Text = auswahl[i].Name;
                    radioButtonAntwort[i].Tag = auswahl[i]; // Hier die Information, ob die Antwort richtig ist, als Tag setzen
                }
            }
        }




        private void NutzerAntwortGewaehlt(object sender, EventArgs e)
        {
            // den angekreuzten Radiobutton finden
            RadioButton antwortKomponente = null;
            foreach(RadioButton b in  radioButtonAntwort)
            {
                if(b.Checked)
                {
                    antwortKomponente =b;
                    break;
                }
            }
            if(antwortKomponente == null)
            {
                return;
            }

            //Schauen, welches Land mit diesem Radiobutton assoziiert war
            Land antwort = antwortKomponente.Tag as Land;

            if (antwort == richtig)
            {
                ++punkte;
                labelPunktestand.Text = "" + punkte + " Punkte";
                labelFeedbackAntwort.Text = "Richtig!";
            }
            else
            {
                labelFeedbackAntwort.Text = "Falsch!";
            }

            if (aktuelleFrage < 10) // TODO 10 anstatt 3
            {
                // Wenn es nicht die letzte Frage ist, geht der Spieler zur nächsten Frage
                NaechsteFrage();
            }
            else
            {
                // Wenn es die letzte Frage ist, endet das Quiz oder zeigt den Endbildschirm
               
                BeendeQuiz();
            }
        }

        private void BeendeQuiz()
        {
            // Hier werden Aktionen implementiert, die nach dem Quiz durchgeführt werden sollen
            // Zum Beispiel: Anzeige der Endpunktzahl, Speicherung des Highscores, etc.
            MessageBox.Show($"Quiz beendet! Punktzahl: {punkte}");
        }

        private void buttonSpielStart_Click(object sender, EventArgs e)
        {
            int index = comboBoxThemen.SelectedIndex;
            if (index<0 || index>=comboBoxThemen.Items.Count)
            {
                comboBoxThemen.Focus();
                return;
            }
            spielmodus = comboBoxThemen.Items[index] as string;
            if(spielmodus=="Flagge")
            {
                pictureBoxFlaggen.Visible = true;
                labelFragen.Visible = false;
            } else
            {
                pictureBoxFlaggen.Visible = false;
                labelFragen.Visible = true;
            }
            // Das Quiz beginnt mit der ersten Frage
            aktuelleFrage = 0;
            punkte = 0;
            NaechsteFrage();
        }

        public void SpeichereHighscore(string spielerName, int punktzahl)
        {
            Datenbank.VerbindungOeffnen();

            string query = "INSERT INTO Highscore (SpielerName, Punktzahl, Datum) VALUES (@SpielerName, @Punktzahl, @Datum)";
            using (MySqlCommand cmd = Datenbank.BefehlErstellen(query))
            {
                cmd.Parameters.AddWithValue("@SpielerName", spielerName);
                cmd.Parameters.AddWithValue("@Punktzahl", punktzahl);
                cmd.Parameters.AddWithValue("@Datum", DateTime.Now);

                cmd.ExecuteNonQuery();
            }

            Datenbank.VerbindungSchliessen();
        }

        public List<HighscoreEintrag> HoleBesteErgebnisse(int anzahl)
        {
            Datenbank.VerbindungOeffnen();

            List<HighscoreEintrag> highscores = new List<HighscoreEintrag>();
            string query = "SELECT ID, SpielerName, Punktzahl, Datum FROM Highscore ORDER BY Punktzahl DESC, Datum ASC LIMIT @Anzahl";

            using (MySqlCommand cmd = Datenbank.BefehlErstellen(query))
            {
                cmd.Parameters.AddWithValue("@Anzahl", anzahl);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64("ID");
                        string spielerName = reader.GetString("SpielerName");
                        int punktzahl = reader.GetInt32("Punktzahl");
                        DateTime datum = reader.GetDateTime("Datum");

                        HighscoreEintrag eintrag = new HighscoreEintrag(id,spielerName, punktzahl, datum);
                        highscores.Add(eintrag);
                    }
                }
            }

            Datenbank.VerbindungSchliessen();
            return highscores;
        }

   
        private void AnzeigeAktualisieren()
        {
            // Hier ggf. zusätzliche Anzeigeaktualisierungen hinzufügen
        }

        private void listBoxSpielergebnis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFlaggen_Click(object sender, EventArgs e)
        {

        }
    }

}
