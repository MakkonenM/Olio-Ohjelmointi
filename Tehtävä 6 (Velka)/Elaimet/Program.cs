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
            Velka velka1 = new Velka(100, 0.09);

            velka1.OdotaVuosi();

            Console.ReadLine();
        }
    }
}
