using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class FabricaMedico: IFabricaDeHeroes
    {
        public ICuartel crearCuartel()
        {
            return Hospital.getInstance();
        }

        public IResponsable crearHeroe()
        {
            return new Medico();
        }

        public IHerramienta crearHerramienta()
        {
            return new Desfibrilador();
        }

        public IVehiculo crearVehiculo()
        {
            return new Ambulancia();
        }
    }
}
