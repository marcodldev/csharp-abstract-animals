using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, Ivolante
    {
         public string verso = "Cip";
         public string cibo = "Vermi";

        public void Vola()
        {
            Console.WriteLine("Il passerotto sta volando.");
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
