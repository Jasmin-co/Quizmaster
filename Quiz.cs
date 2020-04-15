using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitteQuizMaster
{
   class Quiz
    {
        /* Random bogosort = new Random(DateTime.Now.Millisecond); //Pseudozufalssgenerator
         List<Frage> hilfslisteZufallsausgabe = new List<Frage>(); //Liste um die Fragen zu mischen*/
        Random fragenmischen = new Random();
        
      /*  public void Erstelle2Liste()
        {
            List<Frage> zweiteListe = new List<Frage>();
            zweiteListe.AddRange(fragen);
            
        }*/
        //TODO - Diese Liste muss die Fragen der Hauptliste bekommen

        public void MischeFragenListe(List<Frage> fragen)
        {
            Random zufallsgenerator = new Random(DateTime.Now.Millisecond);

            for(int i=0; i < fragen.Count; i++)
            {
                int zufallsPosition = zufallsgenerator.Next(0, fragen.Count);
                Frage zwischengespeichert = fragen[i];
                fragen[i] = fragen[zufallsPosition];
                fragen[zufallsPosition] = zwischengespeichert;
            }
        }

        
        
        
        
















        //TODOhier ist noch nichts



        /* private List<Fragen> fragen = new List<Fragen>();

         public void NeueFragenErstellen(string p_frage) //Fragen kreieren
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
    }

}
