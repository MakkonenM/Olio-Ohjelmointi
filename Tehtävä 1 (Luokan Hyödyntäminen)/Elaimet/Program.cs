using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hevonen heppa = new Hevonen();

            
            heppa.Paino = 89;
            heppa.Nimi = "Histamiini";

            Console.WriteLine(" Hevosen paino on " + heppa.Paino + " ja" + " Hevosen nimi on " + heppa.Nimi + ".");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
