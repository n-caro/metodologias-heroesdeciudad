using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    /// <summary>
    /// ConstructorDesfavorable
    /// usa sólo decorados que complican el apagado de incendios
    /// </summary>
    class ConstructorDesfavorable : ConstructorEscenarioIncendio
    {
        public override void decorarSector(int caudalLluvia, int temperatura, int velocidadViento)
        {
            double probabilidad_de_decorar = 0.3;
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.PastoSeco);
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.ArbolesGrandes);
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.GenteAsustada);
            if (temperatura > 30)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.MuchoCalor);
            if (velocidadViento > 80)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.MuchoViento);
        }
    }
}
