using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


/* AUFGABENLISTE: */

// TODO - Statistiken: speicher den namen sobald er eingegeben wurde + speicher die punkte und das datum in die highscoreliste
// ggf neuen button erstellen oder wenn Spiel zuende ist, wechsel zur statistik seite


// TODO - Fehler auffangen, wenn man in der Liste oder beim Start nichts ausgewählt hat - wichtig
// TODO - Serialisierung und Deserialissierungs-Methoden: Pfad noch mit Openfield ändern und in einer anderen KLasse auslagern
// TODO - FrageEditor: Vermeidung eines Leerenstrings, Doppelte Fragestellung
// TODO - Frageeditor: Texteingaben flexibel gestalten? - muss nicht zwingend
// TODO - Statt direkt in der Liste Random machen (wegen Endlosschleife und doppelte Fragenausgabe- 
// TODO - Allgemein: Zum Schluss überflüssige Codes /Kommentare löschen und die Fehlerabfangenssachen coden


namespace LitteQuizMaster
{

    public partial class Form1 : Form

    {
      
        Statistiken spielerStatistiken = new Statistiken(); //spielerpunkte Statistik
                                                            //  Statistiken fragenStatistiken = new Statistiken();  //Aktuelle Frageanzahl Statistik
       
        Frage aktuelleFrage = new Frage();
        Random zufall = new Random();       //Zufallszahl
        StartSeite willkommensTextStartSeite = new StartSeite();
        Kommentare kommentare = new Kommentare();
        

       
        
        private List<Frage> listeFragen = new List<Frage>();   //Fragenliste für die Fragen erstellt
        private List<Statistiken> highscore = new List<Statistiken>();


        public Form1()      //Konstruktor
        {
            InitializeComponent();
            Deserialisierung();
        }
       


        public void Serialisierung()
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
        private void RadioButtonQuizLeeren() {
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
            //Deserialisierung();
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
        #region FrageAnzeige - wir derzeit nicht benutzt
        /* Methode: Anzeigen der Frage und den dazugehörigen Antworten Antworten */

        /*  private void FrageAnzeigen(Frage frage) // für Button Next beim Tab Quiz 
           {

               lblFragestellung.Text = frage.GetFrageText();
               lblMoeglicheAntwort1.Text = frage.GetAntworten()[0].antwortText;
               lblMoeglicheAntwort2.Text = frage.GetAntworten()[1].antwortText;
               lblMoeglicheAntwort3.Text = frage.GetAntworten()[2].antwortText;
               lblMoeglicheAntwort4.Text = frage.GetAntworten()[3].antwortText;
               lblMoeglicheAntwort5.Text = frage.GetAntworten()[4].antwortText;
               aktuelleFrage = frage;
           }*/
        #endregion


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
                
                  // punktezaehlen = punktezaehlen+1;   //Zählt Punkte, wenn richtig (für Statistik)
                    spielerStatistiken.PunktzahlPlus1();
                    
                    MessageBox.Show("Korrekt." + "\nDeine Punkte: " + spielerStatistiken.GetPunkte() +" von " +spielerStatistiken.GetAnzahlFragen() + " Punkte(n)");

                    if ( spielerStatistiken.GetAnzahlFragen() <1) {

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

                    if (spielerStatistiken.GetAnzahlFragen() < 1) //Anzahl der Fragen festlegen
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
        }

        private void btnCloseEditor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseQuiz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseStatistik_Click(object sender, EventArgs e)
        {
            Close();
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

                spielerStatistiken.FragenZaehlen();  //Counter Anzahl der Frage Statistik

                aktuelleFrage.SetAntworten(spielStart.GetAntworten()[0], spielStart.GetAntworten()[1],
                spielStart.GetAntworten()[2], spielStart.GetAntworten()[3], spielStart.GetAntworten()[4]);

                //Vermerk: radioButton1.Checked = spielStart.GetAntworten()[0].istRichtig;
                //somit zeigt es den richtigen Wert an

                GuiSynch();
            
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
                  
            Deserialisierung();
         
            FrageHolenQuiz();

        }

        private void tabNeueFragen_Click(object sender, EventArgs e)
        {
            //kann das weg?
        }

        private void btnNeuFrageEditor_Click(object sender, EventArgs e)
        {
            /*Felder für eine neue Frage leeren*/
            FelderFragenEditorLeeren();
            GuiSynch();
        }
      

     



        Statistiken SpielerDatenSpeichern() /* Für den Highscore, anlegen neue Spielerdaten + gibt diese zurück*/
        {
            Statistiken neueSpielerDaten = new Statistiken();


            int spielpunktestand = Convert.ToInt32(lblDeinePunkteAnzeige.Text);
            int maxpunkte = Convert.ToInt32(lblAnzeigeErreichbarePunkte.Text);
            string neuername = txtStatistikNameEintragen.Text;
            string spielzeit = DateTime.Now.ToShortDateString();
            
                

        
       
            Statistiken Statistik = new Statistiken();//Objekt erstellen und mit objekt.variable = ... befüllen
            Statistik.spielpunkte = spielpunktestand;
            Statistik.erreichbarePunktZahl = maxpunkte;
            Statistik.spielername = neuername;
            Statistik.zeitangabe = spielzeit; 

            highscore.Add(Statistik);       //Objekt Statistik wird der Listre Highscore hinzugefügt

            //  lblTextfeld.Text =Convert.ToString(Statistik.erreichbarePunktZahl)+Convert.ToString(Statistik.spielername); //Testausgabe
            lblTextfeld.Text = Convert.ToString(spielzeit);
            
                //TODO -Punktestand , MaxPunkte, Datum*/

                return Statistik;
           
        }
       
        private void SynHighscoreliste()        //Syncronisation der Higscoreliste Tab Statistik
        {
            lstHighscoreListeStatistiken.Items.Clear();  //Eingabefeld geleert wird

            for (int i = 0; i < highscore.Count; i++)  //geht die Liste anhand des Index durch
            {
                lstHighscoreListeStatistiken.Items.Add(highscore[i].GibMirDieStatistikDaten());//alle daten abändern sodass ich die pubkte habe
                //GetSpielerDaten gibt den spielernamen zurück er soll aber punkte, namen und datum zurückgeben

            }
        }
        private void btnStatistikNamenEintragen_Click(object sender, EventArgs e) // Namen in der Highscoreliste anzeigen
        {
            Statistiken statistikneuername = SpielerDatenSpeichern();
            

          //  highscore.Add(statistikneuername);
          //  listeSpielerStatistikListe.Add(SpielerDatenSpeichern());
            

            
            
            
            
         
            SynHighscoreliste();
            // Serialisierung FrageAntwort oder Extra 
       
        }

        

        #region Nächste-Frage-Button
        /*
        private void btnNext_Click(object sender, EventArgs e)
        {
            RadioButtonQuizLeeren();
            FrageHolenQuiz();
          string frage = txtNeueFrage.Text;

            Frage neueFrage = FrageSpeichern();
            listeFragen.Add(neueFrage);

        }
        */
        #endregion

        private void btnQuizStopp_Click(object sender, EventArgs e) //Testbutton
        {

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBegruessungsTextTitelStartSeite.Text = willkommensTextStartSeite.GetBegruessungsTextTitelStartSeite();
            lblBegruessungsText.Text = willkommensTextStartSeite.GetBegruessungsTextStartSeite();
            lblStartSeiteSchlussSatz.Text = willkommensTextStartSeite.GetSchlussSatzStartSeite();
            lblDatumUhrzeitStartSeite.Text = Convert.ToString(DateTime.Now);
            lblKommentareTitelAnzeige.Text = kommentare.GetKommentarTextAufforderung();
        }

        private void btnZurQuizSeite_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabQuiz);
        }

        private void btnZurFragenEditorSeite_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabNeueFragen);
        }

        private void btnZurStatistikenSeite_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabStatistik);
        }

        private void btnZurKommentarSeite_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabKommentarSeite);
        }

        private void lblDatumUhrzeit_Click(object sender, EventArgs e)
        {
            /* Anzeige Datum und Uhrzeit */
        }

        private void btnQuizGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabStartSeite);
        }

        private void btnStartSeiteClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
