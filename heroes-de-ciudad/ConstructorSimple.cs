using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    /// <summary>
    /// ConstructorSimple:
    /// No decora sectores
    /// </summary>
    class ConstructorSimple : ConstructorEscenarioIncendio
    {
        public override void decorarSector(int caudalLluvia, int temperatura, int velocidadViento)
        {
            // el escenario simple no decora
        }
    }
}
