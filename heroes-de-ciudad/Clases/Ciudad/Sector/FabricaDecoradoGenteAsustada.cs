using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class FabricaDecoradoGenteAsustada : FabricaDeDecoradosSector
    {
        public override ISector decorarSector(ISector sector)
        {
            return new DecoratorGenteAsustada(sector);
        }
    }
}
