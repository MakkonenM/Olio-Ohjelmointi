using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Ovi
    {
        private String aani;
        public Ovi(String ovenAani)
        {
            aani = ovenAani;
        }
        public void Koputa()
        {
            Console.WriteLine(aani);
        }
    }
}
