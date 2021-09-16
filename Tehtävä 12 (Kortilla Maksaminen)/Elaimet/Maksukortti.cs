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

        public void syoEdullisesti()
        {
            _saldo = _saldo - 2.6;
        }

        public void syoMaukkaasti()
        {
            _saldo = _saldo - 4.6;
        }
        public override string ToString()
        {
            return " Kortilla on rahaa: " + _saldo + " euroa ";
        }
    }
}