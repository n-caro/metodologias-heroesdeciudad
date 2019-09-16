using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface EstrategiaDeApagado
    {
        void RecorrerLugar(ILugar lugar, Calle calle);
    }

}