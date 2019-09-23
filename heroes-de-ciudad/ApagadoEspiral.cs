using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoEspiral : IEstrategiaDeApagado
    {
        public void RecorrerLugar(ILugar lugar, Calle calle)
        {
            /*
            int[,] matrizLugar = lugar.getSectores();
            int caudalAgua = calle.CaudalAgua;

            int CantFilas = matrizLugar.GetLength(0);
            int CantColumnas = matrizLugar.GetLength(1);
            int aux = CantColumnas - 1;
            int fila, columna;
            for (int i = 0; i < CantFilas; i++)
            {
                // a derecha
                for(int j = i; j < aux; j++)
                {
                    fila = CantFilas - (aux + 1);
                    columna = j;
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }

                // a abajo
                for (int j = i; j < aux; j++)
                {
                    fila = j;
                    columna = aux;
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }

                // a izquierda
                for (int j = aux; j > (i - 1); j--)
                {
                    fila = aux;
                    columna = j;
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }

                // increento aux
                aux--;

                // hacia arriba
                for (int j = aux; j > i; j--)
                {
                    fila = j;
                    columna = CantFilas - (aux + 2);
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }
            }

             */
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
