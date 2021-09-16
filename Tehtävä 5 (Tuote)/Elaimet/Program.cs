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
            Tuote tuote1 = new Tuote("Banaani", 1.1, 13);

            Console.WriteLine(tuote1.nimi + ", hinta " + tuote1.hinta + "euroa, "  + tuote1.maara + "kappaletta.");

            Console.ReadLine();
        }
    }
}
