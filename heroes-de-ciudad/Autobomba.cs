using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Autobomba : IVehiculo
    {
        public void conducir()
        {
            Console.WriteLine("Conduciendo autobomba");
        }

        public void encenderSirena()
        {
            Console.WriteLine("Encendiendo la sirena de la autobomba");
        }
    }
}
