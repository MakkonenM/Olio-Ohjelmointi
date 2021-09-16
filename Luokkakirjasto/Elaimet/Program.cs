using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Elaimet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Koira dog = new Koira();
            Koira koira1 = new Koira();
            
            Console.WriteLine(dog);
            dog.AsetaKoiranNimi("Musti");

            dog.AsetaKoiranNimi();
            Console.WriteLine(dog);

            Console.WriteLine(koira1);
            Console.ReadLine();
        }
    }
}