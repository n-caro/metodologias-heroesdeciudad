using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    /// <summary>
    /// 
    /// Utiliza Stacks como LISTA de integrantes, para hacer más eficiente el método getPersonal.
    /// </summary>
    class CuartelDeBomberos : ICuartel
    {
        private static CuartelDeBomberos unicoCuartelDeBomberos = null;
        private Stack<IVehiculo> vehiculos = new Stack<IVehiculo>();
        private Stack<IResponsable> personal = new Stack<IResponsable>();
        private Stack<IHerramienta> herramientas = new Stack<IHerramienta>();

        public void agregarHerramienta(IHerramienta h)
        {
            herramientas.Push(h);
        }

        public void agregarPersonal(IResponsable r)
        {
            personal.Push(r);
        }

        public void agregarVehiculo(IVehiculo v)
        {
            vehiculos.Push(v);
        }

        public IResponsable getPersonal()
        { 
            // Suerte si las pilas están vacías! 
            IResponsable responsable = personal.Pop();
            responsable.setVehiculo(vehiculos.Pop());
            responsable.setHerramienta(herramientas.Pop());
            return responsable;
        }

        // start: 15 - Singleton
        public static CuartelDeBomberos getInstance()
        {
            if (unicoCuartelDeBomberos == null)
                unicoCuartelDeBomberos = new CuartelDeBomberos();
            return unicoCuartelDeBomberos;
        }
        private CuartelDeBomberos() { }
        // end: 15 - Singleton 
    }
}
