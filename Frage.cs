using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LitteQuizMaster
{
    [Serializable]
    class Frage
    {
        //Klasse um Fragen und deren Antworten zu holen usw
        private string frageText;   //Deklaration eines Feldes
        private List<Antwort> antworten = new List<Antwort>();  //Erstellung einer Liste für Antworten

        #region FKT
        /* public void Frage(string frage) // Funktion: Zuweisung der Frage(gleiche wie setter)
         {
             this.frage = frage;
         }*/
        #endregion
        public void SetFrage(string p_frage)        //setzt die Frage
        {
            frageText = p_frage;
        }
        public string GetFrageText()                //gibt die Frage zurück
        {
            return frageText;
        }
       
        public void SetAntworten(Antwort p_a1, Antwort p_a2, Antwort p_a3, Antwort p_a4, Antwort p_a5)
        {
            antworten.Clear(); //vor erstellen der neuen Antworten, werden die alten gelöscht

            //5 neue Antworten
            antworten.Add(p_a1);
            antworten.Add(p_a2);
            antworten.Add(p_a3);
            antworten.Add(p_a4);
            antworten.Add(p_a5);
        }
        
        public List<Antwort> GetAntworten()    //Rückgabe der Liste antwort
        {     
            return antworten;
         }

        #region keine Ahnung ob das weg kann

        // bool antwortRichtig = true;

        /*   public void NeueFragenErstellen(string p_frage) //Fragen kreieren/erstellen
           {
               Fragen eineNeueFrage = new Fragen();
               eineNeueFrage.setFrage(p_frage);

               //In der Liste namens fragen, die neue Fragen speichern

               fragen.Add(eineNeueFrage);
           }
           public List<Fragen> getListFragen() //um die Liste der Fragen abzufragen
           {
               return fragen;
           }*/
        #endregion


        // SetlistFragen und GetListFragen?
        /* public List<Frage> GetListFragen()
         {
             return fragen;
         }*/
       /* public void loeschenEinerFrage()
        {//5.3
            
                    //Datenbestand in der Liste gelöschen: ... .RemoveAt(Index);
        }*/
    }
}
