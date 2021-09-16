using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Kissa
    {
        public int ika = 0;
        public String nimi = "";

        public Kissa()
        {

        }
        public Kissa(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public void AsetaKissanNimi(string nimi = "Studio")
        {
            this.nimi = nimi;
        }
        public void AsetaKissanIka(int ika = 3)
        {
            this.ika = ika;
        }
    }
}   

      
