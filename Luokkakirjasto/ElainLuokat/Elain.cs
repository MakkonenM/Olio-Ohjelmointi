using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public class Elain
    {
       private int ika = 0;
       private string nimi = "";
       private string Lihansyoja = "";
      
        public Elain()
        {

        }
        public Elain(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public bool PalautaElaimenNimi()
        {
            if (nimi == nimi)
            {
                Console.WriteLine(nimi);
                    return true;
            }
            else
            {
                Console.WriteLine("Virheellinen nimi.");
                    return false;
            }
        }
        public bool PalautaElaimenIka()
        {
            if (ika >= 0)
            {
                Console.WriteLine(ika);
                    return true;
            }
            else
            {
                Console.WriteLine("Negatiivinen ikä (vaihda positiiviseksi).");
                    return false;
                
            }
        }
        private bool OnLihanSyoja()
        {
            return true;
        }
        public void AsetaOnLihanSyoja()
        {
            
        }
        public bool PalautaOnLihanSyoja()
        {
            if (Lihansyoja == Lihansyoja)
            {
                Console.WriteLine("Eläin on lihansyöjä");
                return true;
            }
            else
            {
                Console.WriteLine("Eläin ei ole lihansyöjä");
                return false;
            }
        }
    }
}