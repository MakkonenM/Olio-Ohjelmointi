using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Kissa
    {
        private int ika = 0;
        public String nimi = "";

        public Kissa()
        {

        }
        public Kissa(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public void AsetaKissanNimi(String nimi)
        {
            this.nimi = nimi;
        }
        public void AsetaKissanIka(int ika)
        {
            this.ika = ika;
        }
    }
}   

      
