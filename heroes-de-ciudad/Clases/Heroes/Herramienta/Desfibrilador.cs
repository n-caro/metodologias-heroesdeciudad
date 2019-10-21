using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Desfibrilador: IHerramienta
    {
        public void guardar()
        {
            Console.WriteLine("Guardando la herramienta: Desfibrilador");
        }

        public void usar()
        {
            Console.WriteLine("Utilizando la herramienta: Desfibrilador");
        }
    }
}
