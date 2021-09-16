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
            Mittari m = new Mittari();

            while (!m.Taynna())
            {
                Console.WriteLine("Ei täynnä! Mitta: " + m.Mitta());
                m.Lisaa();
            }

            Console.WriteLine("Täynnä! Mitta: " + m.Mitta());
            m.Vahenna();

            Console.WriteLine("Ei täynnä! Mitta: " + m.Mitta());
            Console.ReadLine();
        }
    }
}
