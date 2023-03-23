using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, Inuotante
    {
         public string verso = "non ne ho idea";
         public string cibo = "altri pesci";

     
        public void Nuota()
        {
            Console.WriteLine("Il delfino sta nuotando.");
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
