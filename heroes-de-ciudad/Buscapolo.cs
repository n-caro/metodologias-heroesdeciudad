using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Buscapolo: IHerramienta
    {
        public void guardar()
        {
            Console.WriteLine("Guardando el buscapolo");
        }

        public void usar()
        {
            Console.WriteLine("Preparando el buscapolo.");
        }
    }
}
