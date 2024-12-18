using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZufallAuswahl
{
    public partial class Form1 : Form
    {
        static Random zufallsquelle = new Random();
        List<Land> alleLaender = new List<Land>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO Liste der Länder aus der DB / Datei laden
            for(int i=0;i<100;++i)
            {
                alleLaender.Add(new Land("Land " + i, "Hauptstadt " + i, "Bilddatei" + i + ".png"));
            }
        }

        Land richtig = null;
        private void button1_Click(object sender, EventArgs e)
        {
            // 4 Länder per Zufall auswählen
            List<Land> auswahl = new List<Land>();
            while(auswahl.Count<4)
            {
                Land l = alleLaender[zufallsquelle.Next(alleLaender.Count)];
                if(auswahl.Contains(l))
                {
                    continue;
                }
                auswahl.Add(l);
            }
            richtig = auswahl[zufallsquelle.Next(4)];
            //TODO Flagge des richtigen landes anzeigen
            //TODO Alle 4 ausgeählte Länder in die Antwort-Komponenten installieren
            for (int i = 0; i < 4; ++i) {
                buttonAntwort1.Text = auswahl[i].Hauptstadt;
                //In jeder Auswahl-komponente wird in der Variable Tag das Land gespeichert, das mit dieser Komponente assoziiert ist
                buttonAntwort1.Tag = auswahl[i];
            }
        }
        int punkte = 0;
        private void nutzerAntwortGewaehlt(object sender, EventArgs e)
        {
            //TODO die Komponente bekommen, die der Nutzer ausgewählt hat
            Button antwortKomponente = buttonAntwort1;
            // Aus dieser Komponente das darauf installierte Land bekommen
            Land antwort = antwortKomponente.Tag as Land;
            if(antwort==richtig)
            {
                ++punkte;
            }
        }
    }
}
