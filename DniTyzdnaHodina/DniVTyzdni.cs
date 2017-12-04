using System;
using System.Diagnostics;

namespace DniTyzdnaHodina
{
    class DniVTyzdni
    {
        public static void VypisDenTyzdna(string cisloDna)
        {        
            VypisDenTyzdna(cisloDna, false);
        }

        public static void VypisDenTyzdna(string cisloDna, bool nedelaJePrva)
        {
            int denTyzdna = int.Parse(cisloDna);

            if (!SkontrolujVstup(denTyzdna)) return;

            if (!nedelaJePrva)
            {
                denTyzdna++;
            }

            switch (denTyzdna)
            {
                case 8:
                case 1:
                    Console.WriteLine("Nedela");
                    break;
                case 2:
                    Console.WriteLine("Pondelok");
                    break;
                case 3:
                    Console.WriteLine("Utorok");
                    break;
                case 4:
                    Console.WriteLine("Streda");
                    break;
                case 5:
                    Console.WriteLine("Stvrtok");
                    break;
                case 6:
                    Console.WriteLine("Piatok");
                    break;
                case 7:
                    Console.WriteLine("Sobota");
                    break;
                default:
                    Console.WriteLine("neznamy den");
                    break;
            }
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
