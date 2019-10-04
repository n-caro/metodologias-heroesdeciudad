using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class FabricaDeDecoradosSector
    {
        // selecciones
        public const int 
            PastoSeco = 1, ArbolesGrandes = 2, GenteAsustada = 3, MuchoCalor = 4, MuchoViento= 5, DiaLLuvioso = 6;


        public static ISector decorarSector(ISector sector, int OpcionDecorado)
        {
            FabricaDeDecoradosSector fabrica = null;
            switch (OpcionDecorado)
            {
                case PastoSeco:
                    fabrica = new FabricaDecoradoPastoSeco();
                    break;
                case ArbolesGrandes:
                    fabrica = new FabricaDecoradoArbolesGrandes();
                    break;
                case GenteAsustada:
                    fabrica = new FabricaDecoradoGenteAsustada();
                    break;
                case MuchoCalor:
                    fabrica = new FabricaDecoradoMuchoCalor();
                    break;
                case MuchoViento:
                    fabrica = new FabricaDecoradoMuchoViento();
                    break;
                case DiaLLuvioso:
                    fabrica = new FabricaDecoradoDiaLluvioso();
                    break;
            }
            return fabrica.decorarSector(sector);
        }

        public abstract ISector decorarSector(ISector sector);

    }
}
