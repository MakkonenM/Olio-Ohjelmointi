using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Tuote
    {
        public string nimi;
        public double hinta;
        public int maara;

        public Tuote(string nimiAlussa, double hintaAlussa, int maaraAlussa)
        {
            nimi = nimiAlussa;
            hinta = hintaAlussa;
            maara = maaraAlussa;
        }
    }
}
