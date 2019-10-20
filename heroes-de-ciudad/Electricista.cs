using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Electricista: Responsable, IResponsable
    {
        // Métodos

        override public void revisar(IIluminable iluminable)
        {
            //vehiculo.encenderSirena();
            //vehiculo.conducir();
            //herramienta.usar();
            Console.WriteLine("¡Estoy revisando un desperfecto eléctrico!");
            this.cambiarLamparasQuemadas(iluminable);
            //herramienta.guardar();
        }

        public void cambiarLamparasQuemadas(IIluminable lugar)
        {
            lugar.revisarYCambiarLamparasQuemadas();
        }

        // Chain of Responsability
        public Electricista(IResponsable r) : base(r)
        {

        }
        public Electricista() : base(null)
        {

        }
        // end Chain of responsability

    }
}
