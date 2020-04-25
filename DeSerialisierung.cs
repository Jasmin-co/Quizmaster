using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace LitteQuizMaster
{
    class DeSerialisierung
    {
     /*   static Statistiken testdatenbesorgen = new Statistiken();
       

       static public void SerialisierungHighscore()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream stream = new FileStream(@"C:Users\black\source\repos\Highscoreliste.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(stream, testdatenbesorgen.GetHoleSpielDatenHighscore() );
            stream.Close();
        }

      /*  public void DeserialisierungHighscoreliste()//funkt. nicht
        {
            FileStream stream = new FileStream(@"C:\Users\black\source\repos\Highscoreliste.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            listehighscore = (List<Statistiken>)binaryFormatter.Deserialize(stream);
            SynHighscoreliste();
        }*/

        /*
         Person pers = new Person(56, "Schmidt");
FileStream stream; 
stream = new FileStream(@"D:\MyPerson.dat", FileMode.Create);
BinaryFormatter formatter = new BinaryFormatter();
formatter.Serialize(stream, pers);
stream.Close();*/

        /*    public void DeserialisierungHighscore()
            {
                FileStream stream = new FileStream(@"C:\Users\black\source\repos\Highscoreliste.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
         //       testdatenbesorgen = testdatenbesorgen.GetHoleSpielDatenHighscore() binaryFormatter.Deserialize(stream);




                //  GuiSynch();
            }*/
    }
}
