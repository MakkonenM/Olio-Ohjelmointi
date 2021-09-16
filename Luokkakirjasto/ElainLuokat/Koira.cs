using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
   public class Koira : Nisakkaat
   {
        private int ika = 0;
        private string nimi = "";
        private string ääntely = "Hau!";

        public Koira(string name, int age, string ääni) : base(age, name)
        {
            nimi = name;
            ika = age;
            ääntely = ääni;
        }
        public override string ToString()
        {
            return ääntely;
        }
    }
}

//private int ika = 0;
//private string nimi = "";

//public int Ika { get => ika; }

//public Koira()
//{

//}
//public Koira(int ika, string nimi)
//{
//    this.ika = ika;
//    this.nimi = nimi;
//}
//public bool AsetaKoiranNimi(string uusiNimi = "Haukkuli")
//{

//    if (uusiNimi.ToLower() != "musti")
//    {
//        this.nimi = uusiNimi;
//        Console.WriteLine(uusiNimi);
//        return true;
//    }
//    return false;
//}

//public bool AsetaKoiranIka(int ika)
//{
//    if (ika >= 0)
//    {
//        this.ika = ika;
//        Console.WriteLine(ika);
//        return true;
//    }
//    return false;
//}

//public override string ToString()
//{
//    return nimi + " ja ikä on " + Ika;
//}
//    }
//}   