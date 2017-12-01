using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdnaHodina
{
    class Pole
    {
        //pole - vzdy referencny typ
        public int[] VnutornePole = new int[4] { 10, 4, 5, 6 };

        public void VypisPole()
        {
            for (int i = 0; i < VnutornePole.Length; i++)
            {
                Console.WriteLine(VnutornePole[i]);
            }
        }

        public void VypisPoleForEach()
        {
            foreach (int item in VnutornePole)
            {
                Console.WriteLine(item);
            }
        }

    }
}
