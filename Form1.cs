using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


/* AUFGABENLISTE: */

// TODO - Fehler auffangen, wenn man in der Liste oder beim Start nichts ausgewählt hat - wichtig
// TODO - Serialisierung und Deserialissierungs-Methoden: Pfad noch mit Openfield ändern und in einer anderen Klasse auslagern
// TODO - FrageEditor: Vermeidung eines Leerenstrings, Doppelte Fragestellung

// TODO - Statt direkt in der Liste Random machen (wegen Endlosschleife und doppelte Fragenausgabe- 
// TODO - Allgemein: Zum Schluss überflüssige Codes /Kommentare löschen und die Fehlerabfangenssachen coden




namespace LitteQuizMaster
{


    public partial class Form1 : Form

    {
      
        Statistiken spielerStatistiken = new Statistiken(); //spielerpunkte statistik
                                                            //  Statistiken fragenStatistiken = new Statistiken();  //Aktuelle Frageanzahl statistik
       
        Frage aktuelleFrage = new Frage();
        Random zufall = new Random();       //Zufallszahl
        StartSeite willkommensTextStartSeite = new StartSeite();
    


        private List<Frage> listeFragen = new List<Frage>();   //Fragenliste für die Fragen erstellt
        private List<Statistiken> listehighscore = new List<Statistiken>();
     
      

        public Form1()      //Konstruktor
        {
            InitializeComponent();
            Deserialisierung();
            DeserialisierungHighscoreliste();
          //  DeserialisierungKommentarliste();
        }

        /***********************************************************************************************************************/


        /****** TAB STARTSEITE - Willkommensgruesse und Menüauswahl - TAB STARTSEITE - Willkommensgruesse und Menüauswahl *****/

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBegruessungsTextTitelStartSeite.Text = willkommensTextStartSeite.GetBegruessungsTextTitelStartSeite();
            lblBegruessungsText.Text = willkommensTextStartSeite.GetBegruessungsTextStartSeite();
            lblStartSeiteSchlussSatz.Text = willkommensTextStartSeite.GetSchlussSatzStartSeite();
            lblDatumUhrzeitStartSeite.Text = "Seit " + Convert.ToString(DateTime.Now) + " online ";
         
        }

        /* Startseite: Menueauswahl */
        private void btnZurQuizSeite_Click(object sender, EventArgs e)
        {

            SpielfeldLeeren();
            RadioButtonQuizLeeren();
            tabControl1.SelectTab(tabQuiz);
            GuiSynch();
        }
        public void SpielfeldLeeren()
        {

            /*Bei erneuten Buttonklick auf Quiz, soll ein neues Spiel starten */
            lblFragestellung.Text = "";
            lblMoeglicheAntwort1.Text = "";
            lblMoeglicheAntwort2.Text = "";
            lblMoeglicheAntwort3.Text = "";
            lblMoeglicheAntwort4.Text = "";
            lblMoeglicheAntwort5.Text = "";

            /*Spielstaende werden mit der If-Anweisung auf Null gesetzt*/
            if (spielerStatistiken.GetPunkte() > 0 || spielerStatistiken.GetAnzahlFragen() > 0)
            {
                spielerStatistiken.punkte = 0;
                spielerStatistiken.maxpunkte = 0;
            }

            RadioButtonQuizLeeren();

            GuiSynch();
        }

        private void btnZurFragenEditorSeite_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabNeueFragen);
            DeserialisierungHighscoreliste();
        }

        private void btnZurStatistikenSeite_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabStatistik);
            DeserialisierungHighscoreliste();
        }

     


        private void btnStartSeiteClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /***********************************************************************************************************************/

     


        /*** TAB QUIZ - Frage und Antwort Spiel - TAB QUIZ - Frage und Antwort Spiel - TAB QUIZ - Frage und Antwort Spiel ****/
        private void btnAntwortSetzen_Click(object sender, EventArgs e)/* Tab Quiz */
        {
            
            bool richtigBeantwortet = false;

            Deserialisierung();
            if (radioButton1.Checked)
            {     
                    richtigBeantwortet = aktuelleFrage.GetAntworten()[0].istRichtig;
                
            }
            else if (radioButton2.Checked)
            {
                    richtigBeantwortet = aktuelleFrage.GetAntworten()[1].istRichtig;
            }
            else if (radioButton3.Checked)
            {
                    richtigBeantwortet = aktuelleFrage.GetAntworten()[2].istRichtig;
            }
            else if (radioButton4.Checked)
            {
                    richtigBeantwortet = aktuelleFrage.GetAntworten()[3].istRichtig;
            }
            else if (radioButton5.Checked)
            {
                    richtigBeantwortet = aktuelleFrage.GetAntworten()[4].istRichtig;
            }
            else
            {
                /* wenn nichts ausgewählt  wird*/
                MessageBox.Show("Nichts ausgewählt.");
                return;
            }
                     
                if (richtigBeantwortet)
                {
                /* Werte von der Klasse Statistiken müssen übergeben werden */
                
                  // punktezaehlen = punktezaehlen+1;   //Zählt Punkte, wenn richtig (für statistik)
                    spielerStatistiken.PunktzahlPlus1();
                    
                    MessageBox.Show("Korrekt." + "\nDeine Punkte: " + spielerStatistiken.GetPunkte() +" von " +spielerStatistiken.GetAnzahlFragen() + " Punkte(n)");

                    if ( spielerStatistiken.GetAnzahlFragen() <  listeFragen.Count) {       //Überprüfung ob die max Anzahl an Fragen gestellt wurde

                        FrageHolenQuiz();
                        RadioButtonQuizLeeren();
                    }
                    else
                    {
                    MessageBox.Show("Spiel ist zu Ende");
                    tabControl1.SelectTab(tabStatistik);
                    lblDeinePunkteAnzeige.Text = Convert.ToString(spielerStatistiken.GetPunkte());
                    lblAnzeigeErreichbarePunkte.Text = Convert.ToString(spielerStatistiken.GetAnzahlFragen());
                       
                }
                
                }
                else
                {
                 
                    MessageBox.Show("Leider Falsch.\n Deine Punkte: " + spielerStatistiken.GetPunkte() +" von " + spielerStatistiken.GetAnzahlFragen() +" Punkte(n)" );

                    if (spielerStatistiken.GetAnzahlFragen() < listeFragen.Count) //Anzahl der Fragen festlegen
                    {
                        FrageHolenQuiz();
                        GuiSynch();
                        RadioButtonQuizLeeren();
                    }
                    else
                    {
                    MessageBox.Show("Spiel ist zu Ende");
                    tabControl1.SelectTab(tabStatistik);
                    lblDeinePunkteAnzeige.Text = Convert.ToString(spielerStatistiken.GetPunkte());
                    lblAnzeigeErreichbarePunkte.Text = Convert.ToString(spielerStatistiken.GetAnzahlFragen());

                }
            }       
          
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Deserialisierung();

            FrageHolenQuiz();

        }

        #region Button Laden rausgenommen
        /*  private void btnLaden_Click(object sender, EventArgs e)
          {//TODO ladeprobleme , speichert eine datei liest sie jedoch nicht
            //  FrageImEditorAnzeigen();
              Deserialisierung();
             // GuiSynch();


          }*/
        #endregion

        private void FrageHolenQuiz()
        {
            
                Frage spielStart = listeFragen[zufall.Next(0, listeFragen.Count-1)];
            
                lblFragestellung.Text = spielStart.GetFrageText();
                lblMoeglicheAntwort1.Text = spielStart.GetAntworten()[0].antwortText;
                lblMoeglicheAntwort2.Text = spielStart.GetAntworten()[1].antwortText;
                lblMoeglicheAntwort3.Text = spielStart.GetAntworten()[2].antwortText;
                lblMoeglicheAntwort4.Text = spielStart.GetAntworten()[3].antwortText;
                lblMoeglicheAntwort5.Text = spielStart.GetAntworten()[4].antwortText;

                spielerStatistiken.FragenZaehlen();  //Counter Anzahl der Frage statistik

                aktuelleFrage.SetAntworten(spielStart.GetAntworten()[0], spielStart.GetAntworten()[1],
                spielStart.GetAntworten()[2], spielStart.GetAntworten()[3], spielStart.GetAntworten()[4]);

                //Vermerk: radioButton1.Checked = spielStart.GetAntworten()[0].istRichtig;
                //somit zeigt es den richtigen Wert an

                GuiSynch();
            
            
        }

        private void btnQuizStopp_Click(object sender, EventArgs e) //Sobald stopp geklickt wurde, soll das Spiel zuende sein
        {
            /* Dazu wird benötigt:
             * Variable die weiß wie viele Fragen noch in der Liste sind(gestellt werden)  listeFragen.Count
             * aktuellen Punktestand
             * - Spielerpunkte die er bereits gespielt hat: Methode GetPunkte  oder statistik.spielpunkte
             * Maxpunkte die er hätte erreichen können Anzahl der Fragen
             * Übergang zur "Beendigungsfunktion des Spiel
             * spieler spielt 5 Fragen
             *  spielerpunkte 5 , theor. würde das Spiel solange laufen wie die Anzahl der Fragen ist.
             *  23 - 5 = 18 Punkte die noch hätten erreicht werden können
             *  also irgendwie sowas spielerStatistiken.GetAnzahlFragen() =  listeFragen.Count ?
                 */
                 if(spielerStatistiken.GetAnzahlFragen() < listeFragen.Count)
            {
                //addiere den Rest der "Fragen hätten noch getsellt werden können" dazu, sodass die maximal Frageanzahl erreicht ist und das Spiel endet

                int anzahlDerFragenInDerListe = listeFragen.Count;        //Wertübergabe Anzahl der Fragen in der Liste
                int stoppErreichtePunkte = spielerStatistiken.GetPunkte();      //Wertübergabe die aktuell erspielten Punkte

                int nichtgestellteFragen =(anzahlDerFragenInDerListe - stoppErreichtePunkte);

                MessageBox.Show("Spiel ist zu Ende");
                tabControl1.SelectTab(tabStatistik);
                lblDeinePunkteAnzeige.Text = Convert.ToString(spielerStatistiken.GetPunkte());
                lblAnzeigeErreichbarePunkte.Text = Convert.ToString(spielerStatistiken.GetAnzahlFragen()+ (nichtgestellteFragen -1));
                //Ist zwar nicht so schön, aber es funktioniert
            }
                 
           

        }
      
  

        private void btnCloseQuiz_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnQuizGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabStartSeite);
        }


        /***********************************************************************************************************************/

        /**** TAB Statistiken - Highscoreliste - Tab Statistiken - Highscoreliste - TAB Statistiken - Highscoreliste ****/

        Statistiken SpielerDatenSpeichern() /* Für den Highscore, anlegen neue Spielerdaten + gibt diese zurück*/
        {
            Statistiken neueSpielerDaten = new Statistiken();


            int spielpunktestand = Convert.ToInt32(lblDeinePunkteAnzeige.Text);
            int maxpunkte = Convert.ToInt32(lblAnzeigeErreichbarePunkte.Text);
            string neuername = txtStatistikNameEintragen.Text;
            string spielzeit = DateTime.Now.ToShortDateString();


            Statistiken statistik = new Statistiken();//Objekt erstellen und mit objekt.variable = ... befüllen
            statistik.spielpunkte = spielpunktestand;
            statistik.erreichbarePunktZahl = maxpunkte;
            statistik.spielername = neuername;
            statistik.zeitangabe = spielzeit;

            listehighscore.Add(statistik);       //Objekt statistik wird der Listre Highscore hinzugefügt

            return statistik;


        }

        private void SynHighscoreliste()        //Syncronisation der Higscoreliste Tab statistik
        {
            lstHighscoreListeStatistiken.Items.Clear();

            for (int i = 0; i < listehighscore.Count; i++)
            {
                lstHighscoreListeStatistiken.Items.Add(listehighscore[i].GetHoleSpielDatenHighscore());

                //GetSpielerDaten gibt den spielernamen zurück er soll aber punkte, namen und datum zurückgeben

            }
        }
        private void btnStatistikNamenEintragen_Click(object sender, EventArgs e) // Namen in der Highscoreliste anzeigen
        {
            Statistiken statistikneuername = SpielerDatenSpeichern();

            SerialisierungHighscoreliste();
            SynHighscoreliste();
            txtStatistikNameEintragen.Text = "";

        }

        private void btnStatistikEintragLoeschen_Click(object sender, EventArgs e)
        {
            /*Aus der Highscoreliste Beitrag entfernen */
            listehighscore.RemoveAt(lstHighscoreListeStatistiken.SelectedIndex);
            SerialisierungHighscoreliste();
            SynHighscoreliste();
        }

     
        private void btnStatistikGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabStartSeite);
        }
    
        private void btnNochlSpielenStatistik_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabQuiz);
            SpielfeldLeeren();
        }

        private void btnCloseStatistik_Click(object sender, EventArgs e)
        {
            Close();
        }


        /***************************************************************************************************************************/

        /*** TAB FRAGENEDITOR - Frage und Antwort - TAB FRAGENEDITOR - Frage und Antwort - TAB FRAGENEDITOR - Frage und Antwort ***/
        private void btnSpeicherFrage_Click(object sender, EventArgs e)
        {
            string frage = txtNeueFrage.Text;

            Frage neueFrage = FrageSpeichern();
            listeFragen.Add(neueFrage);


            //TODO Leere String abfangen

            Serialisierung();
            GuiSynch();
            FelderFragenEditorLeeren();
        }

        private void FelderFragenEditorLeeren() /* Methode: Felder leeren um einen neuen Eintrag machen zu können */
        {
            txtNeueFrage.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
        }
        private void RadioButtonQuizLeeren()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void GuiSynch()  /* Methode: GUI Synchronisation*/
        {
            lstFragenliste.Items.Clear();  //Eingabefeld geleert wird

            for (int i = 0; i < listeFragen.Count; i++)  //geht die Liste anhand des Index durch
            {
                lstFragenliste.Items.Add(listeFragen[i].GetFrageText());
            }
        }

        private void btnUeberarbeiten_Click(object sender, EventArgs e) /* Tab Frageneditor */
        {

            Frage frageAntwortueberschreiben = listeFragen[lstFragenliste.SelectedIndex];
            frageAntwortueberschreiben.SetFrage(txtNeueFrage.Text);

            /* Vermerk: mit set arbeiten, um die Liste für diesen Index zu überschreiben */
            frageAntwortueberschreiben.SetAntworten(new Antwort(radioButton6.Checked, textBox1.Text),
                                        new Antwort(radioButton7.Checked, textBox2.Text),
                                        new Antwort(radioButton8.Checked, textBox3.Text),
                                        new Antwort(radioButton9.Checked, textBox4.Text),
                                        new Antwort(radioButton10.Checked, textBox5.Text)
                                         );
            //indexFrageliste = listeFragen.Count;    //Soll herausfinden, wieviele Fragen in der Liste sind

            Serialisierung();
            GuiSynch();
            FelderFragenEditorLeeren();


        }

        Frage FrageSpeichern() /* Anlegen einer neuen Frage mit Antworten und welche wahr ist + gibt diese zurück*/
        {
            Frage frage = new Frage();

            /* Text v. d. Frage + die dazugehörigen 5 Antworten(text + bool)*/
            string neueFrageText = txtNeueFrage.Text;
            frage.SetFrage(neueFrageText);

            frage.SetAntworten(
                new Antwort(radioButton6.Checked, textBox1.Text),
                new Antwort(radioButton7.Checked, textBox2.Text),
                new Antwort(radioButton8.Checked, textBox3.Text),
                new Antwort(radioButton9.Checked, textBox4.Text),
                new Antwort(radioButton10.Checked, textBox5.Text)
                );

            return frage;
        }

        private void FrageImEditorAnzeigen()  /* Funktion Anzeigen im Frageneditor */
        {
            Frage frageBearbeiten = listeFragen[lstFragenliste.SelectedIndex]; //aus der Liste den ausgewählten Index nehmen

            txtNeueFrage.Text = frageBearbeiten.GetFrageText();
            textBox1.Text = frageBearbeiten.GetAntworten()[0].antwortText;
            textBox2.Text = frageBearbeiten.GetAntworten()[1].antwortText;
            textBox3.Text = frageBearbeiten.GetAntworten()[2].antwortText;
            textBox4.Text = frageBearbeiten.GetAntworten()[3].antwortText;
            textBox5.Text = frageBearbeiten.GetAntworten()[4].antwortText;

            /*Zeigt an welche Antwort als die richtige abgespeichert wurde*/
            radioButton6.Checked = frageBearbeiten.GetAntworten()[0].istRichtig;
            radioButton7.Checked = frageBearbeiten.GetAntworten()[1].istRichtig;
            radioButton8.Checked = frageBearbeiten.GetAntworten()[2].istRichtig;
            radioButton9.Checked = frageBearbeiten.GetAntworten()[3].istRichtig;
            radioButton10.Checked = frageBearbeiten.GetAntworten()[4].istRichtig;
        }
        private void btnEdit_Click(object sender, EventArgs e)  /* Tab FragenEditor */
        {
            FrageImEditorAnzeigen();
        }

        private void btnFrageLöschern_Click(object sender, EventArgs e)
        {
            listeFragen.RemoveAt(lstFragenliste.SelectedIndex);

            GuiSynch();
            Serialisierung();
        }
        private void btnNeuFrageEditor_Click(object sender, EventArgs e)
        {
            /*Felder für eine neue Frage leeren*/
            FelderFragenEditorLeeren();
            GuiSynch();
        }
        private void btnFragenEditorGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabStartSeite);
        }
        private void btnCloseEditor_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        /***********************************************************************************************************************/


        /*SERIALOSIERUNG & DESERIALISIERUNG - soll später noch in eine andere Klasse ausgelagert werden - SERIALOSIERUNG & DESERIALISIERUNG */

        /* Serialisierung und Deserialisierung für die Frage und Antwortliste*/
        public void Serialisierung()//diese muss noch in die Klasse DeSerialisierung ausgelagert werden !!!
        {

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(@"C:\Users\black\source\repos\FrageAntwort.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(stream, listeFragen);
            stream.Close();

        }

        public void Deserialisierung()
        {
            FileStream stream = new FileStream(@"C:\Users\black\source\repos\FrageAntwort.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            listeFragen = (List<Frage>)binaryFormatter.Deserialize(stream);

            GuiSynch();
        }

        /* Serialisierung und Deserialisierung für die Highscoreliste (Statistik) */
        public void SerialisierungHighscoreliste()//funkt. nicht
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(@"C:\Users\black\source\repos\Highscoreliste.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(stream, listehighscore);
            stream.Close();
        }
        public void DeserialisierungHighscoreliste()
        {
            FileStream streamHighscore = new FileStream(@"C:\Users\black\source\repos\Highscoreliste.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatterHighscore = new BinaryFormatter();
            listehighscore = (List<Statistiken>)binaryFormatterHighscore.Deserialize(streamHighscore);
            SynHighscoreliste();

        }


        /*Bauecke*/




    }

}
