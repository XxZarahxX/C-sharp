using System;
using System.Collections.Generic;
using System.Text;

namespace Allatok
{

    class Program
    {
        static void Main(string[] args)
        {
            Papagaj tollas = new Papagaj(9, 5, 3, "Szin");
            Console.WriteLine($", {tollas.eletkor}, {tollas.testsuly}, {tollas.tollassag}, {tollas.eletbenVanE}");
            tollas.Eszik();
            Console.WriteLine($" {tollas.eletkor}, {tollas.testsuly}, {tollas.tollassag}, {tollas.eletbenVanE}");
            Console.WriteLine(tollas.Beszel());
        }

    }
}