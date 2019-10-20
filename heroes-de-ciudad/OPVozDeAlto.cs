using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class OPVozDeAlto : IOrdenPolicia
    {
        public void Ejecutar()
        {
            Console.WriteLine("   POLICIA: - ¡¡Alto!!");
        }
    }
}
