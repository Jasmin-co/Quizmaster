using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LitteQuizMaster
    
{
    [Serializable]
    class Antwort
    {
        //TODO: getter u setter / kapselung!
       public bool istRichtig { get; set; } //get und set für die Serialisierung
       public string antwortText { get; set; }

        public Antwort(bool istRichtig, string antwortText)  //Konstruktor
        {
            this.istRichtig = istRichtig;
            this.antwortText = antwortText;
        }

    }
}
