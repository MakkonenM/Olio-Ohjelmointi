using System;
using ElainLuokat;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {

            Kissa cat = new Kissa("hrrr", "Miuku", 2, "Hau!");
            Koira dog = new Koira("Musti", 3, "Miau!");
            Papukaija parrot = new Papukaija("Papu", 4);

            Console.Write("Kissan ikä on: ");
            cat.PalautaElaimenNimi();
            Console.Write("Kissan nimi on: ");
            cat.PalautaElaimenIka();
            cat.PalautaOnLihanSyoja();
            cat.Taito();

            cat.Kehrää();

            Console.WriteLine(cat);
            Console.WriteLine("-------------------------");

            Console.Write("Koiran nimi on: ");
            dog.PalautaElaimenNimi();
            Console.Write("Koiran ikä on: ");
            dog.PalautaElaimenIka();
            dog.PalautaOnLihanSyoja();
            dog.Taito();
            Console.WriteLine(dog);
            Console.WriteLine("-------------------------");



            Console.Write("Papukaijan nimi on: ");
            parrot.PalautaElaimenNimi();
            Console.Write("Papukaijan ikä on: ");
            parrot.PalautaElaimenIka();
            parrot.Taito();

            Console.ReadLine();
        }
    }
}
