using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Maksukortti pekanKortti = new Maksukortti(20);
            Maksukortti matinKortti = new Maksukortti(30);

            pekanKortti.syoMaukkaasti(10);
            matinKortti.syoEdullisesti(5);
            Console.WriteLine(" Pekka syö maukkaasti ja matti edullisesti.");
            Console.WriteLine(" Pekan :" + pekanKortti);
            Console.WriteLine(" Matin :" + matinKortti);
            Console.WriteLine("-----------------------------------------");

            pekanKortti.lataaRahaa(20);
            Console.WriteLine(" Pekka tallettaa rahaa 17 euroa.");
            Console.WriteLine(" Pekan :" + pekanKortti);
            Console.WriteLine("-----------------------------------------");

            matinKortti.syoMaukkaasti(11);
            Console.WriteLine(" Matti syö edullisesti."); 
            Console.WriteLine(" Matin :" + matinKortti);
            Console.WriteLine("-----------------------------------------");

            pekanKortti.syoEdullisesti(5);
            pekanKortti.syoEdullisesti(8);
            Console.WriteLine(" Pekka syö edullisesti 2 kertaa.");
            Console.WriteLine(" Pekan :" + pekanKortti);
            Console.WriteLine("-----------------------------------------");

            matinKortti.lataaRahaa(50);
            Console.WriteLine(" Matti lataa rahaa 50 euroa.");
            Console.WriteLine(" Matin " + matinKortti);

            Console.ReadLine();
        }
    }
}