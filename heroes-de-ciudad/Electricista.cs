using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Electricista
    {
        public void revisar(IIluminable iluminable)
        {
            Console.WriteLine("¡Estoy revisando un desperfecto eléctrico!");
            this.cambiarLamparasQuemadas(iluminable);
        }

        public void cambiarLamparasQuemadas(IIluminable lugar)
        {
            lugar.revisarYCambiarLamparasQuemadas();
        }
    }
}
