using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitteQuizMaster
{[Serializable]
    class Kommentare
    {
        string kommentarAufforderungsText;
        string kommentarText;
      
        public Kommentare(string p_kommentiere) //fuer die Aufforderung
        {
            kommentarAufforderungsText = p_kommentiere;
        }
        public Kommentare()
        {
            SetKommentarTextAufforderung();
        }
     
        public void SetKommentarTextAufforderung()  //Schreibaufforderung
        {
            kommentarAufforderungsText = "Hinterlasse hier Dein Feedback, damit ich den Little Quizmaster weiter verbessern kann";
        }

        public string GetKommentarTextAufforderung()    //gibt die Schreibaufforderung im Label zurück
        {
            return kommentarAufforderungsText;
        }

        public void SetKommentarliste(string p_kommentarText)
        {
            kommentarText = p_kommentarText;
        }
        public string GetKommentarliste()   //für die Synchronisation
        {
            return kommentarText;
        }
     
        

        public void SetKommentar(string p_neuKommentar)
        {
            string neuerKommentar = p_neuKommentar;
        }
    }
}
