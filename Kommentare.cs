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

        public Kommentare(string p_kommentiere)
        {
            kommentarAufforderungsText = p_kommentiere;
        }
        public Kommentare()
        {
            SetKommentarTextAufforderung();
        }
        public void SetKommentarTextAufforderung()
        {
            kommentarAufforderungsText = "Hinterlasse hier Dein Feedback, damit ich den Little Quizmaster weiter verbessern kann";
        }

        public string GetKommentarTextAufforderung()
        {
            return kommentarAufforderungsText;
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
