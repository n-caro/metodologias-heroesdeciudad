using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class DecoratorSector: ISector
    {
        protected ISector componente;
        protected Random random = new Random();

        public bool estaApagado()
        {
            return componente.estaApagado();
        }

        public double getPorcentajeIncendio()
        {
            return componente.getPorcentajeIncendio();
        }

        virtual public void mojar(double agua)
        {
            componente.mojar(agua);
        }
        // constructor
        public DecoratorSector(ISector componente)
        {
            this.componente = componente;
        }
    }
}
