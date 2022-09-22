using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    public class Madar : Allat
    {
        public int tollassag;
        public Madar(int eletkor, int testsuly, int tollas) : base(eletkor, testsuly)
        {
            this.tollassag = tollas;
        }

        public void Tojik()
        {
            if (tollassag > 0)
                tollassag--;
        }
    }
}
