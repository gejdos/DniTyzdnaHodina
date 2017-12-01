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

        public static void CyklusFor()
        {
            /*  for (int i = 0; i < 10; i = i + 2)
              {
                  Console.WriteLine(i);
              }*/

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

        }
           
           



    }
}
