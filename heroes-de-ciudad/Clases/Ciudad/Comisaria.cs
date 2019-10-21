using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Comisaria: ICuartel
    {
        private static Comisaria unicaComisaria = null;
        private List<IVehiculo> vehiculos = new List<IVehiculo>();
        private List<IResponsable> personal = new List<IResponsable>();
        private List<IHerramienta> herramientas = new List<IHerramienta>();

        public void agregarHerramienta(IHerramienta h)
        {
            herramientas.Add(h);
        }

        public void agregarPersonal(IResponsable r)
        {
            personal.Add(r);
        }

        public void agregarVehiculo(IVehiculo v)
        {
            vehiculos.Add(v);
        }

        public IResponsable getPersonal()
        {
            IResponsable responsable = personal[0];
            responsable.setHerramienta(herramientas[0]);
            responsable.setVehiculo(vehiculos[0]);

            return responsable;

        }

        // start: 15 - Singleton
        public static Comisaria getInstance()
        {
            if (unicaComisaria == null)
                unicaComisaria = new Comisaria();
            return unicaComisaria;
        }
        private Comisaria() { }
        // end: 15 - Singleton 
    }
}
