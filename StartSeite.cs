using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitteQuizMaster
{
    class StartSeite
    {
        string begruessungsText;
        

        public StartSeite(string willkommen)
        {
            begruessungsText = willkommen;
        }

        public StartSeite()
        {
            SetBegruessungsTextStartSeite();
        }

        public void SetBegruessungsTextStartSeite()     //Willkommenstext auf der Startseite
        {
            begruessungsText = "Herzlich Willkommen bei Little Quizmaster \n" +
                "\nTeste dein Wissen im Quiz\n" +
                "oder erweitere die Fragen im Frageeditor. \n" +
                " Deine Punkte kannst du bei Statistiken einsehen\n" +
                "Viel Spaß beim Quiz";
        }

        public string GetBegruessungsTextStartSeite()
        {
            return begruessungsText;
        }

        

        
    }
}
