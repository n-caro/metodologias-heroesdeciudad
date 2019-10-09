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
            Console.WriteLine("Guardando el buscapolo.");
        }

        public void usar()
        {
            Console.WriteLine("Utilizando el buscapolo.");
        }
    }
}
