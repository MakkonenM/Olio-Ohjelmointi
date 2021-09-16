using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Velka
    {
        public double _saldo;
        public double _korkoProsentti;

        public Velka(double saldoAlussa, double _korkoprosentti)
        {
            _saldo = saldoAlussa;
            _korkoProsentti = _korkoprosentti;
        }

        public void TulostaSaldo()
        {
            Console.WriteLine();
        }
        public void OdotaVuosi()
        {
            Console.WriteLine(_saldo = _saldo * (1 + _korkoProsentti));
        }
    }

}
