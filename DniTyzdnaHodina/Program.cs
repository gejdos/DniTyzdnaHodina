﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdnaHodina
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  while (true)
              {
                  Console.WriteLine("Zadaj den");
                  string den = Console.ReadLine();

                  DniVTyzdni.VypisDenTyzdna(cisloDna: den);
                  DniVTyzdni.VypisDenTyzdna(cisloDna: den, nedelaJePrva: true);

              }
              */
            //Cykly.CyklusWhile();
            //Cykly.CyklusDoWhile();

            /* Console.WriteLine("zadaj pocet opakovani");
             int cislo = int.Parse(Console.ReadLine());

            Cykly.CyklusFor(cislo);
            Cykly.CyklusForContinue();
            Cykly.HodnotVsReferencia();*/

            Auto autoPovodne = new Auto();
            autoPovodne.Farba = "cierna";

            Cykly.PrefarbiAuto(autoPovodne);
            Console.WriteLine(autoPovodne.Farba);

            //z "a-cka" urobime referencny typ - "boxing"
            int a = 10;
            object o = a;
            object o1 = o;
            o = (int)o + 1;
            //Console.WriteLine(o);

            int aPovodna = 10;
            Cykly.ZvysOJednotku(aPovodna);
            Console.WriteLine(aPovodna);
            Cykly.ZvysOJednotku(ref aPovodna);
            Console.WriteLine(aPovodna);


            Console.ReadKey();

        }
    }
}
