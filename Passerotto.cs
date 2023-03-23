﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
    {
        readonly string verso = "Cip";
        readonly string cibo = "Vermi";

        public string Cibo
        {
            get { return cibo; }
        }

        public string VersoEmesso
        {
            get { return verso; }
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
