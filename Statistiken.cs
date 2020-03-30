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
        private int erreichtePunkteZahl;
        private int erreichbarePunktZahl;
        private int punkte;
        private string name;
        private DateTime datumUhrzeit;

        
        
      


       //erreichtePunkte = new Statistiken();    //Objekt erstellt


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
    }
}
