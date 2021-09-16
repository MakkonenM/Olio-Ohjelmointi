using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Maksukortti
    {
        private double _saldo;

        public Maksukortti(double alkusaldo)
        {
            _saldo = alkusaldo;
        }

        public void lataaRahaa(double raha)
        {

            if (raha > 0)
            {
               _saldo = _saldo + raha;
            }
            else
            {
                _saldo = _saldo + 0;
            }
        }

        public override string ToString()
        {
            return "Kortilla on rahaa " + _saldo + " euroa ";
        }
    }
}