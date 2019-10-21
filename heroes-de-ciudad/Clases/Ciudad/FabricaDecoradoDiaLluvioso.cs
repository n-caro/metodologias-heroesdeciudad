using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class FabricaDecoradoDiaLluvioso : FabricaDeDecoradosSector
    {
        public override ISector decorarSector(ISector sector)
        {
            return new DecoratorDiaLluvioso(sector);
        }
    }
}
