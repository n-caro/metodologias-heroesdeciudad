using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoEspiral : IEstrategiaDeApagado
    {
        public void apagarIncendio(ILugar lugar)
        {
            this.apagarIncendio(lugar, lugar.getCalle());
        }

        public void apagarIncendio(ILugar lugar, Calle calle)
        {
            ISector[,] matrizLugar = lugar.getSectores();
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
            // Creo mensajes de finalización en consola
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
            Console.ResetColor();
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
