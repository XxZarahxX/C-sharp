using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp14
{
    class Program
        //viczjan.pal.edu@gmail.com
    {
        static void Main(string[] args)
        {
            List<Sorsolas> sorsolas_list = new List<Sorsolas>();
            string[] lines = File.ReadAllLines("lotto.txt");
            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Sorsolas sorsolas_object = new Sorsolas(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                sorsolas_list.Add(sorsolas_object);
            }

            foreach (var item in sorsolas_list)
            {
                Console.WriteLine($"Hét: {item.het},{item.szam1},{item.szam2},{item.szam3},{item.szam4},{item.szam5},{item.szam6} ");
            }

            Console.WriteLine("Hét: ");
            string bekert_szam = Console.ReadLine();

            foreach (var item in sorsolas_list)
            {
                if(item.het == bekert_szam)
                {
                    Console.WriteLine($"{item.het},{item.szam1},{item.szam2},{item.szam3},{item.szam4},{item.szam5},{item.szam6}");
                }
            }


            List<Szam> szamok = new List<Szam>();

            int db=0;
            for (int i = 1; i < 46; i++)
            {
                foreach (var item in sorsolas_list)
                {
                    if (i == item.szam1 || i == item.szam2 || i == item.szam3 || i == item.szam4 || i == item.szam5 || i == item.szam6)
                    {
                        db++;
                    }
                }
                Szam szam_object = new Szam(i, db);
                szamok.Add(szam_object);
                db = 0;
            }
            int max = int.MinValue;
            int legnagyobb_eredmeny = 0;

            foreach (var item in szamok)
            {
                if(max <= item.db)
                {
                    max = item.db;
                    legnagyobb_eredmeny = item.szam;
                }

            }
            Console.WriteLine($"A legtöbbször kihúzott: {legnagyobb_eredmeny} : {max}");

            int min = int.MaxValue;
            int legkisebb_eredmeny = 0;

            foreach (var item in szamok)
            {
                if (min >= item.db)
                {
                    min = item.db;
                    legkisebb_eredmeny = item.szam;
                }

            }
            Console.WriteLine($"A legkevesebbet kihúzott: {legkisebb_eredmeny} : {min}");

            int sum = 0;
           
            foreach (var item in szamok)
            {
                if (item.szam % 2 != 0)
                {
                    sum += item.db;
                }
            }
            Console.WriteLine($"A szám páratlan: {sum}");
          





            int szam1 = 0;
            int szam3 = 0;
            foreach (var item in szamok)
            {
                if(item.szam == 1)
                {
                    szam1 = item.db;
                }
            }
            Console.WriteLine("1: "+szam1);

            foreach (var item in szamok)
            {
                if (item.szam == 3)
                {
                    szam3 = item.db;
                }
            }
            Console.WriteLine("3: " + szam3);






            foreach (var item in szamok)
            {
                Console.WriteLine($"{item.szam}, {item.db}");
            }
         }
     }
}

