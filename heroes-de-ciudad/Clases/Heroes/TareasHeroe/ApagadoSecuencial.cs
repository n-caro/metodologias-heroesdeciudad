using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoSecuencial : IEstrategiaDeApagado
    {
        public void RecorrerLugar(ILugar lugar, Calle calle)
        { 
            // Obtengo las dimensiones de lugar
            ISector[,] matrizLugar = lugar.getSectores();
            int caudalAgua = calle.CaudalAgua;

            int lugarFilas = matrizLugar.GetLength(0);
            int lugarColumnas = matrizLugar.GetLength(1);

            for (int fila = 0; fila < lugarFilas; fila++)
            {
                for (int columna = 0; columna < lugarColumnas; columna++)
                {
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }
            }
        }

        private void ApagarSector(int fila, int columna, ISector[,] matrizLugar, int caudalAgua)
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
