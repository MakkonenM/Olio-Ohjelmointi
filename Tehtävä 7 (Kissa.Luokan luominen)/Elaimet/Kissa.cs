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
    
        public bool AsetaKissanNimi(string uusiNimi = "Studio")
        {
           
            if (uusiNimi.ToLower() != "hilda")
            {
                this.nimi = uusiNimi;
                Console.WriteLine(uusiNimi);
                return true;
            }
            return false;
        }
        public bool AsetaKissanIka(int ika = -2)
        {
            if(ika >= 0)
            {
                this.ika = ika;
                Console.WriteLine(ika);
                return true;
            }
            return false;
        }
    }
}