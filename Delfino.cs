using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        readonly string verso = "non ne ho idea";
        readonly string cibo = "altri pesci";

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
