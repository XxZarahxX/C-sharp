using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Barchoba játék");
            Console.Write("Név: ");
            string nev = Console.ReadLine();
            // 1-3 könnyű nehéz
            Console.WriteLine("Nehézségi szit 1-3: ");
            Console.WriteLine("(1 - Könnyű; 2 - Közepes; 3 - Nehéz)");
            Console.Write("         ");
            byte nehezseg = byte.Parse(Console.ReadLine());
            byte tippek_szama = 0;
            if (nehezseg == 1)
                tippek_szama = 15;
            else if (nehezseg == 2)
                tippek_szama = 10;
            else if (nehezseg == 3)
                tippek_szama = 5;
            int pontszam = 1000;
            Random r = new Random();
            byte randszam = (byte)r.Next(0, 101);
            byte tipp = 0;
            do
            {
                if (tippek_szama == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Elfogytak a tippjeid - GAME OVER!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                //Tipp 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Maradt tipjjeid: " + tippek_szama );
                Console.WriteLine("Pontszám: " + pontszam );
                Console.Write("A tipped:  ");
                tipp = byte.Parse(Console.ReadLine());
                //Számok összehasonlítása
                if (tipp < randszam)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Nagyobb a szám!");
                    pontszam -= 50;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (tipp > randszam)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Kisebb a szám!");
                    pontszam -= 50;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nyerő, eltaláltad!");
                    Console.WriteLine("A végső pontszámod: " + pontszam);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("      ");
                tippek_szama--;
            } while (tipp != randszam);
            Console.ReadKey();
        }
    }
}

