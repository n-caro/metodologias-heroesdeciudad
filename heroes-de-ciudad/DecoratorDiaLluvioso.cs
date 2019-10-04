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
            //int intesidadLluvia = random.Next(1, 500);
            base.mojar(agua + intesidadLluvia);
        }
        // constructor
        public DecoratorDiaLluvioso(ISector componente) : base(componente)
        {
            this.intesidadLluvia = random.Next(1,500);
        }
    }
}
