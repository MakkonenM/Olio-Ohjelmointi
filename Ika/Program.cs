using System;
using ElainLuokat;

namespace Ika
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
      
            int d = 0;

            while (d < 10)
            {
                
                int luku = rnd.Next(15);
                Koira dog = new Koira(luku, "Koira");

                luku = rnd.Next(20);

              
                Kissa cat = new Kissa(luku, "Kissa");

                Console.WriteLine(cat);
                Console.WriteLine(dog);
                
               
                if(cat.palautaKissanIka()< dog.Ika)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
                Console.WriteLine("--------------------");

                d++;
            }
        }
    }
}