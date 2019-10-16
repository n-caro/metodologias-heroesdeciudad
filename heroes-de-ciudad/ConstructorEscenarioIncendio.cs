using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class ConstructorEscenarioIncendio
    {
        private ISector sector;
        Random random = new Random();

        public void crearSector()
        {
            sector = new Sector(random.Next(0,100));
        }
        public ISector obtenerSector()
        {
            return sector;
        }
        abstract public void decorarSector(int caudalLluvia, int temperatura, int velocidadViento);
    }
}
