using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Mittari
    {
        private int _mitta = 0;

        public void Lisaa()
        {
            _mitta++;
        }
        public void Vahenna()
        {
            _mitta--;
        }
        public int Mitta()
        {
            return _mitta;
        }
        public bool Taynna()
        {
            if (_mitta == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
