using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface IEstrategiaDeApagado
    {
        void apagarIncendio(ILugar lugar, Calle calle);
        // actualización, ya que ahora cada ILugar tiene calle.
        void apagarIncendio(ILugar lugar);
    }

}