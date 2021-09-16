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
            if (_saldo >= 2.6)
            {
                _saldo = _saldo - 2.6;
            }
            else
            {
                Console.WriteLine( "Raha ei riitä " + _saldo);
            }
        }

        public void syoMaukkaasti()
        {
            if (_saldo >= 4.6) 
            {
                _saldo = _saldo - 4.6;
            }
            else
            {
                Console.WriteLine( "Raha ei riitä " + _saldo);
            }

        }

        public override string ToString()
        {
            return " Kortilla on rahaa: " + _saldo + " euroa ";
        }
    }
}