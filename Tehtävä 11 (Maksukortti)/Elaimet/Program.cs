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
            Maksukortti kortti = new Maksukortti (50.0);

            Console.WriteLine(kortti);
            Console.ReadLine();
        }
    }
}
