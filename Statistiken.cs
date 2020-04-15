using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitteQuizMaster
{
    [Serializable]
    class Statistiken   //Für den Tab Statistik
        //Vorbereitung um die Punkte zuzufügen, errechnen, anzeigen zu lassen
    {
        //TODO - liste Punktzahl/Highscore
        //TODO dies eliste soll die aktuellen punkzahl, datum und namen haben
        public int spielerPunkteZahl { get; set; }
        public int erreichbarePunktZahl { get; set; }
        public int punkte;    //spielerpunkte
        public int spielerPunkteZaehlerZwischenspeicher;
        public int maxpunkte;  //max erreichbare punkte
        public int fragenZaehlerZwischenspeicher;
        

        public string spielername { get; set; }
        public string zeitangabe { get; set; }
        public int spielpunkte { get; set; }

       
        private int spielpunktestand;

        public Statistiken(int spielerPunkte, int erreichbarePunkte,string p_spielername, string p_zeitangabe)//Konstruktor
        {
            spielerPunkteZahl = spielerPunkte;
            erreichbarePunktZahl = erreichbarePunkte;
            spielername = p_spielername;
            zeitangabe = p_zeitangabe;

           // this.zeitangabe = zeitangabe; vorerst rausgenommen

        }

       

        public Statistiken(int spielpunktestand)
        {
            this.spielpunktestand = spielpunktestand;
        }
        public string GibMirDieStatistikDaten() //Idee getter aus allen drei daten machen für die highscoresync
        {
            string aktuellePunkteQuiz = Convert.ToString(spielpunkte);
            string maxPunkteSpiel = Convert.ToString(erreichbarePunktZahl);
            string aktuellerSpielerNamen = spielername;
            string aktuelleZeitSpiel = Convert.ToString(zeitangabe);
            //Ausgabe der Liste mit Hilfe von Sync und dieser Methode
            return "Name: " + aktuellerSpielerNamen + " - Punkt(e): " +aktuellePunkteQuiz+" von: " + maxPunkteSpiel+ " - Datum: " + zeitangabe;
        }

        public Statistiken()
        {
        }

        public void PunktzahlPlus1()   //SpielerPunkte zählen
        {
          punkte =  punkte + 1;
        }
        public int GetPunkte()
        {
            spielerPunkteZaehlerZwischenspeicher = punkte;
            return spielerPunkteZaehlerZwischenspeicher;
        }
        

        public void FragenZaehlen()//Tab Quiz Rückgabe der Anzahl der Fragen
        {
            maxpunkte = maxpunkte + 1;
            
        }
        public int GetAnzahlFragen()    
        {
            fragenZaehlerZwischenspeicher = maxpunkte;
            return fragenZaehlerZwischenspeicher;
        }

      
     /*     public string GetSpielerDaten()      //gibt den Spielernamen zurück
        {
            return spielername;
        }*/

        //erreichtePunkte = new Statistiken();    //Objekt erstellt
        #region erstmal weg
        /*
                public void SetErreichtePunkte(int p_erreichtePunkte)
                {

                    erreichtePunkteZahl = p_erreichtePunkte;    //Wertzuweisung
                }

                public int GetErreichtePunkte()
                {

                    return erreichtePunkteZahl; //muss für Textbox ToString verwendet werden?
                }

                public void SetErreichbarePunkte(int p_erreichbarePunkte)
                {
                    erreichbarePunktZahl = p_erreichbarePunkte;
                }
                public int GetErreichbarePunkte()
                {
                    return erreichbarePunktZahl;
                }
                */
        #endregion

    }
}
