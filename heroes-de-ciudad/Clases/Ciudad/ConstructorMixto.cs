using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    /// <summary>
    /// ConstructorMixto
    /// Usa todos los tipos de decorados.
    /// </summary>
    class ConstructorMixto: ConstructorEscenarioIncendio
    {
        public override void decorarSector(int caudalLluvia, int temperatura, int velocidadViento)
        {
            double probabilidad_de_decorar = 0.2;
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
            if (caudalLluvia > 0)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.DiaLLuvioso);
        }
    }
}
