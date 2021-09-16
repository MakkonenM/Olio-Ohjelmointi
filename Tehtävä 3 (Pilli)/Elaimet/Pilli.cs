using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Pilli
    {
        private String aani;
        public Pilli(String pillinAani)
        {
            aani = pillinAani;
        }


        public void soi()
        {
            Console.WriteLine(aani);
        }
    }
}
