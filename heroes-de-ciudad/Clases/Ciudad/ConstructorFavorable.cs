using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    /// <summary>
    /// ConstructorFavorable
    /// Sólo decora favorablemente: 
    /// </summary>
    class ConstructorFavorable: ConstructorEscenarioIncendio
    {
        public override void decorarSector(int caudalLluvia, int temperatura, int velocidadViento)
        {
            if (caudalLluvia > 0)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.DiaLLuvioso);
        }
    }
}
