using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class FabricaElectricista: IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return CentralElectrica.getInstance();
        }

        public IResponsable crearHeroe()
        {
            return new Electricista();
        }

        public IHerramienta crearHerramienta()
        {
            return new Buscapolo();
        }

        public IVehiculo crearVehiculo()
        {
            return new Camioneta();
        }
    }
}
