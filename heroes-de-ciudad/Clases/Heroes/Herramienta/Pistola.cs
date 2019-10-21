using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Pistola: IHerramienta
    {
        public void guardar()
        {
            Console.WriteLine("Enfundando la pistola.");
        }

        public void usar()
        {
            Console.WriteLine("Desenfundando la pistola.");
        }
    }
}
