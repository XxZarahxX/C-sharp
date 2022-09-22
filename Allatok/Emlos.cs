using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    public class Emlos : Allat
    {
        public int szorosseg;
        public Emlos(int eletkor, int testsuly, int szoros) : base(eletkor, testsuly)
        {
            this.szorosseg = szoros;
        }

        public void Vedlik()
        {
            if (szorosseg > 0)
                szorosseg--;
        }
    }
}