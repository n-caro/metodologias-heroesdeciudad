using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class ApagadoSectores
    {
        abstract public void apagarIncendio(ILugar lugar, Calle calle);
        
        public void apagarIncendio(ILugar lugar)
        {
            this.apagarIncendio(lugar, lugar.getCalle());
        }

        protected void ApagarSector(int fila, int columna, ISector[,] matrizLugar, int caudalAgua)
        {
            double porcentajeIncendio = matrizLugar[fila, columna].getPorcentajeIncendio();
            ISector sectorProblematico = matrizLugar[fila, columna];
            StringBuilder estado_Incendio = new StringBuilder();
            if (porcentajeIncendio > caudalAgua)
            {
                sectorProblematico.mojar(caudalAgua);
                estado_Incendio.Append(" -> ");
                estado_Incendio.Append(sectorProblematico.getPorcentajeIncendio());
                while (!sectorProblematico.estaApagado())
                {
                    sectorProblematico.mojar(caudalAgua);
                    estado_Incendio.Append(" -> ");
                    estado_Incendio.Append(sectorProblematico.getPorcentajeIncendio());
                }
            }
            else
            {
                sectorProblematico.mojar(caudalAgua);
                estado_Incendio.Append(" -> 0");
            }
            Console.WriteLine("     ({0},{1}) -> {2}{3}", fila, columna, porcentajeIncendio, estado_Incendio);
        }
    }
}
