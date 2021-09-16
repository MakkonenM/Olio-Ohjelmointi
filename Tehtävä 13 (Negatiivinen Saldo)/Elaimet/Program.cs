using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Maksukortti kortti = new Maksukortti (5);
            Console.WriteLine(kortti);

            kortti.syoEdullisesti();
            Console.WriteLine(kortti);

            kortti.syoMaukkaasti();
            kortti.syoEdullisesti();

            Console.WriteLine(kortti);
            Console.ReadLine();

        }
    }
}
