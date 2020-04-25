using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitteQuizMaster
{
    [Serializable]
    class Statistiken   //Für den Tab Statistik

    {
        //TODO - liste Punktzahl/Highscore
     
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

        }

        public Statistiken(int spielpunktestand)
        {
            this.spielpunktestand = spielpunktestand;
        }
        public string GetHoleSpielDatenHighscore() //Idee getter aus allen drei daten machen für die highscoresync
        {
            string aktuellePunkteQuiz = Convert.ToString(spielpunkte);
            string maxPunkteSpiel = Convert.ToString(erreichbarePunktZahl);
            string aktuellerSpielerNamen = spielername;
            string aktuelleZeitSpiel = Convert.ToString(zeitangabe);
            //Ausgabe der Liste mit Hilfe von Sync und dieser Methode
            return " " + aktuellerSpielerNamen + " - Punkt(e): " +aktuellePunkteQuiz+" von: " + maxPunkteSpiel+ " -  " + zeitangabe;
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

       }
}
