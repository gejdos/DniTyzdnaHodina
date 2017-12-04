using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdnaHodina
{
    class DniVTyzdni
    {
        public static void VypisDenTyzdna(string cisloDna)
        {
            StackTrace stackTrace = new StackTrace();
            int denTyzdna = int.Parse(cisloDna);
        
            if (stackTrace.GetFrame(1).GetMethod().Name == "Main")
            {
                if (!SkontrolujVstup(denTyzdna)) return;
            }
            else
            {
                if (!SkontrolujVstup(denTyzdna + 1)) return;
            }

            switch (denTyzdna)
            {
                case 0:
                case 7:
                    Console.WriteLine("Nedela");
                    break;
                case 1:
                    Console.WriteLine("Pondelok");
                    break;
                case 2:
                    Console.WriteLine("Utorok");
                    break;
                case 3:
                    Console.WriteLine("Streda");
                    break;
                case 4:
                    Console.WriteLine("Stvrtok");
                    break;
                case 5:
                    Console.WriteLine("Piatok");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                default:
                    Console.WriteLine("neznamy den");
                    break;
            }
        }

        public static void VypisDenTyzdna(string cisloDna, bool nedelaJePrva)
        {
            int denTyzdna = int.Parse(cisloDna);

            if (nedelaJePrva)
            {
                denTyzdna--;
            }

            VypisDenTyzdna(denTyzdna.ToString());
        }

        /*public static bool SkontrolujVstup(int cisloDna)
        {
            return (cisloDna >= 1 && cisloDna <= 7);
        }*/

        public static bool SkontrolujVstup(int cisloDna)
        {
            if (cisloDna < 1 || cisloDna > 7)
            {
                Console.WriteLine("Nespravny vstup");
                return false;
            }

            return true;
        }

    }
}
