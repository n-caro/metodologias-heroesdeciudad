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
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("     [ELECTRICISTA]       ");
            Console.ResetColor();
            vehiculo.encenderSirena();
            vehiculo.conducir();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            herramienta.usar();
            Console.WriteLine("¡Estoy revisando un desperfecto eléctrico!");
            this.cambiarLamparasQuemadas(iluminable);
            herramienta.guardar();
            Console.ResetColor();
            Console.WriteLine("_______________________________________________ \n ");
        }

        public void cambiarLamparasQuemadas(IIluminable lugar)
        {
            lugar.revisarYCambiarLamparasQuemadas();
        }

    }
}
