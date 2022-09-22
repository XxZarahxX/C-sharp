using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    public class Papagaj : Madar
    {
        public string szin;

        public Papagaj(int eletkor, int testsuly, int tollas, string szin) : base(eletkor, testsuly, tollas)
        {
            this.szin = szin;
        }

        public string Beszel()
        {
            return "Beszélek";
        }
    }
}