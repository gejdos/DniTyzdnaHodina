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

            while (true)
            {
                Console.WriteLine("Zadaj den");
                string den = Console.ReadLine();

                DniVTyzdni.VypisDenTyzdna(den, true);

            }

        }
    }
}
