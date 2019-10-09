using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface ICuartel
    {
        void agregarVehiculo(IVehiculo v);
        void agregarPersonal(IResponsable r);
        void agregarHerramienta(IHerramienta h);
        IResponsable getPersonal();
    }
}
