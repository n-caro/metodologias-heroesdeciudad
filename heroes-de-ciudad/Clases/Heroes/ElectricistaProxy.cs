using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ElectricistaProxy : Responsable, IResponsable
    {
        IFabricaDeHeroes fabrica = new FabricaElectricista();
        IResponsable heroeReal = null;

        override public void revisar(IIluminable iluminable)
        {
            if (heroeReal == null)
            {
                heroeReal = fabrica.crearHeroe(); 
                heroeReal.setHerramienta(fabrica.crearHerramienta());
                heroeReal.setVehiculo(fabrica.crearVehiculo());
            }
            heroeReal.revisar(iluminable);
            // devuelvo el bombero creado al cuartel
            fabrica.crearCuartel().agregarPersonal(heroeReal);
            fabrica.crearCuartel().agregarVehiculo(heroeReal.getVehiculo());
            fabrica.crearCuartel().agregarHerramienta(heroeReal.getHerramienta());
        }
    }
}
