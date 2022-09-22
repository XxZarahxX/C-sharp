using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{
    class Kutya : Emlos
    {

        public string gazda;
        public Kutya(int eletkor, int testsuly, int szoros, string gazda) : base(eletkor, testsuly, szoros)
        {
            this.gazda = gazda;
        }

        public string Ugat()
        {
            return "Vau";
        }
    }
}