using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DecoratorPastoSeco: DecoratorSector
    {
        public override void mojar(double agua)
        {
            // pasto seco divide el caudal recibidio en dos
            base.mojar(agua / 2);
        }
        // constructor
        public DecoratorPastoSeco(ISector componente) : base(componente)
        {
        }
    }
}
