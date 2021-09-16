using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public class Papukaija : Linnut
    {
        int ika = 0;
        string nimi = "";

        public Papukaija()
        {

        }
        public Papukaija(string name, int age) : base(age, name)
        {
            nimi = name;
            ika = age;
        }
    }
}
