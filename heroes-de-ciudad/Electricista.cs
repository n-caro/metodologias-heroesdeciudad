using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Electricista: IResponsable
    {
        private IHerramienta herramienta;
        private IVehiculo vehiculo;

        // getters-setters
        public IHerramienta getHerramienta() { return herramienta; }
        public void setHerramienta(IHerramienta herramienta) { this.herramienta = herramienta; }
        public IVehiculo getVehiculo() { return vehiculo; }
        public void setVehiculo(IVehiculo vehiculo) { this.vehiculo = vehiculo; }
        // Métodos

        public void revisar(IIluminable iluminable)
        {
            vehiculo.encenderSirena();
            vehiculo.conducir();
            herramienta.usar();
            Console.WriteLine("¡Estoy revisando un desperfecto eléctrico!");
            this.cambiarLamparasQuemadas(iluminable);
            herramienta.guardar();
        }

        public void cambiarLamparasQuemadas(IIluminable lugar)
        {
            lugar.revisarYCambiarLamparasQuemadas();
        }


    }
}
