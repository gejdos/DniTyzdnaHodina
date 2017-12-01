using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdnaHodina
{
    class Cykly
    {
        public static void CyklusWhile()
        {
            int i = 0;

            while (i < 4)
            {
                Console.WriteLine("Ahoj!");
                i++;
            }
        }

        public static void CyklusDoWhile()
        {
            int i = 0;

            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 4);
        }

        public static void CyklusFor(int input)
        {
            /*  for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine(i);
              }

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0, j = 10; i <= j; i++, j--)
            {
                Console.WriteLine(i + ", " + j);
            }*/

            Console.WriteLine(" ");

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("opakovanie cislo {0}", i);

                if (i == 7) break;

            }
        }

        public static void CyklusForContinue()
        {
            for (int i = 0; i < 15; i++)
            {
                //zvysok po deleni
                int zvysok = i % 2;

                //pokracuj s cyklom
                if (zvysok != 0) continue;

                Console.WriteLine(i);

            }


        }

        public static void HodnotVsReferencia()
        {
            int hodnota1 = 6;

            int hodnota2;

            hodnota2 = hodnota1;
            hodnota2++;

            //Console.WriteLine(hodnota1 + ", " + hodnota2);

            Auto auto1 = new Auto();
            auto1.Farba = "cervena";
            Auto auto2 = auto1;
            auto2.Farba = "cierna";

            Console.WriteLine(auto1.Farba);
            Console.WriteLine(auto2.Farba);
            
        }

        public static void PrefarbiAuto(Auto auto)
        {
            auto.Farba = "biela";
        }

        //nepredava hodnotu, ale referenciu
        public static void ZvysOJednotku(ref int a)
        {
            a++;
        }
        public static void ZvysOJednotku(int a)
        {
            a++;
        }



    }
}
