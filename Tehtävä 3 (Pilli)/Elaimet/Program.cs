using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilli sorsapilli = new Pilli("Kvaak");
            Pilli kukkopilli = new Pilli("Peef");

            sorsapilli.soi();
            kukkopilli.soi();
            sorsapilli.soi();

            Console.ReadLine();
        }
    }
}
