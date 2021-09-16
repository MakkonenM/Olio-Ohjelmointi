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
            Ovi alexander = new Ovi("Who's There?");

            alexander.Koputa();
            alexander.Koputa();

            Console.ReadLine();
        }
    }
}
