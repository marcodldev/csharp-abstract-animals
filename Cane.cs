using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        readonly string verso = "wof wof";
        readonly string cibo = "quello che trova";

        public string Cibo
        {
            get { return cibo; }
        }

        public string VersoCane
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
