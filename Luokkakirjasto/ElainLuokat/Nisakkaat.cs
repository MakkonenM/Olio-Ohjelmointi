using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
   public class Nisakkaat : Elain
   {
        private int ika = 0;
        private string nimi = "";
        public Nisakkaat()
        {

        }
        public Nisakkaat(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public void Taito()
        {
            Console.WriteLine("Kyseinen nisäkäs ei voi lentää");
        }
    }
}
