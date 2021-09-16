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
            Kissa cat = new Kissa();
            cat.AsetaKissanNimi();
            Console.WriteLine("Kissan nimi on " + cat.nimi);
            cat.AsetaKissanNimi("Hilda");

            cat.AsetaKissanIka();
            Console.WriteLine("Kissan ikä on " + cat.ika);

            Console.ReadLine();
        }
    }
}
