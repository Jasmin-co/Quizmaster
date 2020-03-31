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
        private int spielerPunkteZahl { get; set; }
        private int erreichbarePunktZahl { get; set; }
        private int punkte;    //spielerpunkte
        private int spielerPunkteZaehlerZwischenspeicher;
        private int maxpunkte;  //max erreichbare punkte
        private int fragenZaehlerZwischenspeicher;

        private string spielername { get; set; }
        private DateTime zeitangabe { get; set; }
        public Statistiken spielpunkte { get; private set; }

        private List<Statistiken> highscore = new List<Statistiken>();


        public Statistiken(int spielerPunkte, int erreichbarePunkte,string spielername)//Konstruktor
        {
            this.spielerPunkteZahl = spielerPunkte;
            this.erreichbarePunktZahl = erreichbarePunkte;
            this.spielername = spielername;
           // this.zeitangabe = zeitangabe; vorerst rausgenommen

        }

        public Statistiken()
        {
        }

        public void PunktzahlPlus1()   //SpielerPunkte zählen
        {
          punkte =  punkte + 1;
        }
        public int getPunkte()
        {
            spielerPunkteZaehlerZwischenspeicher = punkte;
            return spielerPunkteZaehlerZwischenspeicher;
        }
      

        public void FragenZaehlen()//Tab Quiz Rückgabe der Anzahl der Fragen
        {
            maxpunkte = maxpunkte + 1;
            
        }
        public int getAnzahlFragen()    
        {
            fragenZaehlerZwischenspeicher = maxpunkte;
            return fragenZaehlerZwischenspeicher;
        }

        

        public void setStatistikSachen(Statistiken spielerPunkte, Statistiken spielername)
        {/*in meine liste eingefügt*/
            //spielerPunkte = spielpunkte;    //Versuch Verbindung von spielpunkte zu spielerpunkte zu erstellen
           
            highscore.Clear();
            highscore.Add(spielerPunkte);
            highscore.Add(spielername);
          //  highscore.Add(zeitangabe);
        }
        public List<Statistiken> GetStatistikSachen()
        {
            return highscore;
        }

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
