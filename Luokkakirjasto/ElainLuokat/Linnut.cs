using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
   public class Linnut : Elain
   {
        private int ika = 0;
        private string nimi = "";
        public Linnut()
        {

        }
        public Linnut(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        
        public void Taito()
        {
            Console.WriteLine("Linnut voivat lentää");
        }
    }
}
