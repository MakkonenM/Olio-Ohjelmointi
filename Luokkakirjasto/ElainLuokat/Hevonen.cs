using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{  
     public class Hevonen : Nisakkaat
    {
        private string nimi;
        private int paino;

        public Hevonen()
        {
            nimi = "";
            paino = 0;
        }

        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
            }
        }

        public int Paino
        {
            get
            {
                return paino;
            }

            set
            {
                paino = value;
            }
        }
    }
}
