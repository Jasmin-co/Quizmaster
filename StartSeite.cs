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
        string begruessungsTextTitelStartSeite;
       
        

        public StartSeite(string willkommen)
        {
            begruessungsText = willkommen;
          
        }
       
        
        
        public StartSeite()
        {
            SetBegruessungsTextStartSeiteTitel();
            SetBegruessungsTextStartSeite();
        }

        public void SetBegruessungsTextStartSeiteTitel()     //Willkommenstext auf der Startseite
        {
            begruessungsTextTitelStartSeite = "Herzlich Willkommen bei Little Quizmaster \n";
        }
        public string GetBegruessungsTextTitelStartSeite()
        {
            return begruessungsTextTitelStartSeite;
        }
        public void SetBegruessungsTextStartSeite()
        {
            begruessungsText =
                "\nTeste dein Wissen im Quiz\n" +
                "oder erweitere die Fragen im Frageeditor. \n" +
                "Deine Punkte kannst du bei Statistiken einsehen\n" +
                "Viel Spaß beim Quiz";
        }
        public string GetBegruessungsTextStartSeite()
        {
            return begruessungsText;
        }
        
    
        

        
    }
}
