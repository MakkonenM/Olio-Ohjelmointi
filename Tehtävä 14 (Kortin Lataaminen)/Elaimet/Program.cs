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
            Maksukortti kortti = new Maksukortti (10);

            Console.WriteLine(kortti);
            kortti.lataaRahaa(15);

            Console.WriteLine(kortti);
            kortti.lataaRahaa(10);

            Console.WriteLine(kortti);
            kortti.lataaRahaa(115.0);

            Console.WriteLine(kortti);
            Console.ReadLine();

        }
    }
}
