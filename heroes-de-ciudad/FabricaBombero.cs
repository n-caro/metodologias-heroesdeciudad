using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class FabricaBombero: IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return new CuartelDeBomberos();
        }

        public IResponsable crearHeroe()
        {
            return new Bombero();
        }

        public IHerramienta crearHerramienta()
        {
            return new Manguera();
        }

        public IVehiculo crearVehiculo()
        {
            return new Autobomba();
        }
    }
}
