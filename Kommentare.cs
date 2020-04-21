using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitteQuizMaster
{
    class Kommentare
    {
        string kommentarAufforderungsText;

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
    }
}
