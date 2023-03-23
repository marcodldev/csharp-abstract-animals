using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class PulcinellaDiMare : Animale, Ivolante, Inuotante
    {
        string verso = "qualcosa più intimidatorio di 'cip' immagino.";
        string cibo = "pesci";

        public string Cibo
        {
            get { return cibo; }
        }

        public string VersoEmesso
        {
            get { return verso; }
        }

        public void Nuota()
        {
            Console.WriteLine("La pulcinella di mare sta nuotando.");
        }

        public void Vola()
        {
            Console.WriteLine("La pulcinella di mare sta volando.");
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
