using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    class Macska : Emlos
    {
        public int karomElesseg;

        public Macska(int eletkor, int testsuly, int szoros, int karom) : base(eletkor, testsuly, szoros)
        {
            this.karomElesseg = karom;
        }

        public string Karmol()
        {
            return "Megkarmolt";
        }
    }
}