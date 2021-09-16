using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
   public class Kissa : Nisakkaat
   {
        private int ika = 0;
        private string nimi = "";
        private string ääntely = "Miau!";
        private string _kehräys;
        public Kissa(string kehrays, string name, int age, string ääni) : base(age, name)
        {
            _kehräys = kehrays;
            nimi = name;
            ika = age;
            ääntely = ääni;
        }
        public void Kehrää()
        {
            Console.WriteLine("Kissa kehrää: " + _kehräys + _kehräys);
        }
        public override string ToString()
        {
            return ääntely;
        }
    }
}   