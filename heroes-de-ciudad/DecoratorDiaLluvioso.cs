using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DecoratorDiaLluvioso: DecoratorSector
    {
        private int intesidadLluvia;
        public override void mojar(double agua)
        {
            base.mojar(agua + intesidadLluvia);
        }
        // constructor
        public DecoratorDiaLluvioso(ISector componente, int intesidadLluvia) : base(componente)
        {
            this.intesidadLluvia = intesidadLluvia;
        }
    }
}
