using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LitteQuizMaster
{
    class Provesorisch
    {
        #region Serialisierung und Deserialisierung - umlagern gescheitert
        /* public object listeFragen { get; private set; }

         public void Serialisierung()
         {
             //TODO Pfad noch mit Openfield ändern und in einer anderen KLasse auslagern
             BinaryFormatter binaryFormatter = new BinaryFormatter();
             FileStream stream = new FileStream(@"C:\Users\black\source\repos\FrageAntwort.txt", FileMode.Create, FileAccess.Write);
             binaryFormatter.Serialize(stream, listeFragen);
             stream.Close();

         }

         public void Deserialisierung()
         {
             FileStream stream = new FileStream(@"C:\Users\black\source\repos\FrageAntwort.txt", FileMode.Open, FileAccess.Read);
             BinaryFormatter binaryFormatter = new BinaryFormatter();
             listeFragen = (List<Frage>)binaryFormatter.Deserialize(stream);

            // GuiSynch();
         }
     */
        #endregion
    }
}
