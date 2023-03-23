using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, Ivolante
    {
         public string verso = "rahh rahh";
         public string cibo = "scoiattoli";


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
