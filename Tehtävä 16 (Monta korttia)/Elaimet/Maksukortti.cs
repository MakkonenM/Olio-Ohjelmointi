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
            _saldo = _saldo + raha;
        }
        public void syoMaukkaasti(double raha2)
        {
            _saldo = _saldo - raha2;
        }
        public void syoEdullisesti(double raha3)
        {
            _saldo = _saldo - raha3;
        }

        public override string ToString()
        {
            return "Kortilla on rahaa " + _saldo + " euroa ";
        }
    }
}