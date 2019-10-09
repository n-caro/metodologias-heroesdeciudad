using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface IFabricaDeHeroes
    {
        IResponsable crearHeroe();
        IVehiculo crearVehiculo();
        IHerramienta crearHerramienta();
        ICuartel crearCuartel();
    }

}
