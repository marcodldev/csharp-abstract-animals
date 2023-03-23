﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, Ivolante
    {
         string verso = "rahh rahh";
         string cibo = "scoiattoli";

        public string Cibo
        {
            get { return cibo; }
        }

        public string VersoEmesso
        {
            get { return verso; }
        }

        public void Vola()
        {
            Console.WriteLine("L'aquila sta volando.");
        }

        public override void Verso()
        {
            Console.WriteLine(verso);
        }

        public override void Mangia()
        {
            Console.WriteLine($"mangia {cibo}");
        }
    }
}
