using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdnaHodina
{
    class DniVTyzdni
    {
        public static void VypisDenTyzdna(string cisloDna)
        {
            int denTyzdna = int.Parse(cisloDna);

            if (SkontrolujVstup(denTyzdna))
            {
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

        }

        public static void VypisDenTyzdna(string cisloDna, bool nedelaJePrva)
        {
            int denTyzdna = int.Parse(cisloDna);

            if (SkontrolujVstup(denTyzdna))
            {
                if (denTyzdna > 0 && denTyzdna < 8)
                {
                    if (nedelaJePrva)
                    {
                        denTyzdna--;
                    }

                    VypisDenTyzdna(denTyzdna.ToString());

                }
                else
                {
                    Console.WriteLine("Nespravny vstup");
                }
            }

        }

        public static bool SkontrolujVstup(int cisloDna)
        {
            return (cisloDna >= 1 && cisloDna <= 7);
        }

    }
}
