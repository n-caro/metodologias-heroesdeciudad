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
            Sector[,] matrizLugar = lugar.getSectores();
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

        private void ApagarSector(int fila, int columna, Sector[,] matrizLugar, int caudalAgua)
        {
            double porcentajeIncendio = matrizLugar[fila, columna].PorcentajeIncendio;
            Sector sectorProblematico = matrizLugar[fila, columna];
            StringBuilder estado_Incendio = new StringBuilder();
            if (porcentajeIncendio > caudalAgua)
            {
                sectorProblematico.mojar(caudalAgua);
                estado_Incendio.Append("-> ");
                estado_Incendio.Append(sectorProblematico.PorcentajeIncendio);
                while (!sectorProblematico.estaApagado())
                {
                    sectorProblematico.mojar(caudalAgua);
                    estado_Incendio.Append("-> ");
                    estado_Incendio.Append(sectorProblematico.PorcentajeIncendio);
                }
            }
            else
            {
                sectorProblematico.mojar(caudalAgua);
            }
            Console.WriteLine("     ({0},{1}) -> {2} {3}-> 0", fila, columna, porcentajeIncendio, estado_Incendio);
        }
    }
}
