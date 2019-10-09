using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface IResponsable
    {

        // setters y getter de herramientas
        IHerramienta getHerramienta();
        IVehiculo getVehiculo();
        void setHerramienta(IHerramienta h);
        void setVehiculo(IVehiculo v);
    }
}
